// Copyright 2001-2010 - Active Up SPRLU (http://www.agilecomponents.com)
//
// This file is part of MailSystem.NET.
// MailSystem.NET is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// MailSystem.NET is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with SharpMap; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using ActiveUp.Net.Mail;

namespace ActiveUp.Net.Security
{
#if !PocketPC
    [Serializable]
#endif
    public class Signature
    {
        private Signature()
        {

        }
        public Signature(Message signedMessage)
        {
            _signedMessage = signedMessage;
        }
        public static Signature Parse(string input)
        {
            return Parse(input,null);
        }
        public static Signature Parse(string input, Message signedMessage)
        {
            Signature signature = signedMessage != null ? new Signature(signedMessage) : new Signature();

            MatchCollection matches = Regex.Matches(input, @"[a-zA-Z]+=[^;]+(?=(;|\Z))");
            Logger.AddEntry(typeof(Signature), matches.Count.ToString());
            foreach (Match m in matches)
            {
                string tag = m.Value.Substring(0,m.Value.IndexOf('='));
                //TODO: This is an insane bug fix. Please try to parse 200711050949465352.tmp with the line commented
                //string value = m.Value.Substring(m.Value.IndexOf('=')+1);
                string value = m.Value.Substring(m.Value.IndexOf('=')+1).Split(',')[0];
                if (tag.Equals("a"))
                    signature._a = value;
                else if (tag.Equals("b"))
                {
                    value = value.Trim('\r', '\n').Replace(" ", "");
                    signature._b64 = value.Replace(" ", "").Replace("\t", "").Replace("\r\n", "");
                    signature._b = Convert.FromBase64String(signature._b64);
                }
                else if (tag.Equals("c"))
                {
                    if (value.Equals("nofws")) signature._c = CanonicalizationAlgorithm.NoFws;
                    else if (value.Equals("simple")) signature._c = CanonicalizationAlgorithm.Simple;
                    else signature._c = CanonicalizationAlgorithm.Other;
                }
                else if (tag.Equals("d"))
                    signature._d = value;
                else if (tag.Equals("s"))
                    signature._s = value;
                else if (tag.Equals("q"))
                    signature._q = value.Equals("dns") ? QueryMethod.Dns : QueryMethod.Other;
                else if (tag.Equals("h"))
                    signature._h = value.Split(':');
            }
            return signature;
        }
        private static string SelectFieldsAndCanonicalize(string header, Signature signature)
        {
            // Make a lowercase version for easy IndoxOf.
            string headerLower = header.ToLower();

            // We will only review the portion of the header after (before, in time) the signature.
            int start = headerLower.IndexOf("\ndomainkey-signature");
            header = header.Substring(start);

            StringBuilder sb = new StringBuilder();

            // Unfold.
            header = Parser.Unfold(header);

            // Build a list of header lines.
            string[] lines = Regex.Split(header, "\r?\n");

            // Do we have to take specific headers or all headers ?
            if (signature.SignedHeaders.Length > 0)
            {
                // There are specific headers. For each field name in the signature, loop through the lines and append found occurences.
                foreach (string str in signature.SignedHeaders)
                {
                    foreach (string line in lines)
                        if (line.ToLower().StartsWith(str)) sb.Append(string.Concat(Canonicalizer.Canonicalize(line, signature.CanonicalizationAlgorithm),Tokenizer.NewLine));
                }
            }
            else
            {
                // We take all headers subsequent to the signature field.
                bool firstPassed = false;
                foreach (string line in lines)
                {
                    if (!firstPassed)
                    {
                        firstPassed = true;
                        continue;
                    }
                    else sb.Append(string.Concat(line,Tokenizer.NewLine));
                }

            }

            return sb.ToString().TrimEnd('\r','\n') + "\r\n";
        }
        public static bool Verify(byte[] emailData, Signature signature)
        {
            string emailDatastr = Encoding.ASCII.GetString(emailData,0,emailData.Length);
            string header = emailDatastr.Substring(0, emailDatastr.IndexOf("\r\n\r\n"));
            header = Parser.Unfold(header);
            header = SelectFieldsAndCanonicalize(header, signature);
            string body = emailDatastr.Substring(Regex.Match(emailDatastr, @"(?<=\r?\n\r?\n).").Index - 1);
            System.IO.StringReader sr = new System.IO.StringReader(body);
            StringBuilder sb = new StringBuilder();
            while (sr.Peek() != -1)
                sb.Append(string.Concat(Canonicalizer.Canonicalize(sr.ReadLine(), signature.CanonicalizationAlgorithm),Tokenizer.NewLine));
            byte[] canonicalized = Encoding.ASCII.GetBytes(header + sb.ToString().TrimEnd('\r', '\n') + "\r\n");

            SHA1Managed sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(canonicalized);

            PublicKeyRecord record = signature.GetPublicKeyRecord();

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSAParameters rsap = new RSAParameters();
            FillRSAPublicKeyParameters(record.KeyData, ref rsap);
            rsa.ImportParameters(rsap);
            RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(rsa);
            RSADeformatter.SetHashAlgorithm("SHA1");

            return RSADeformatter.VerifySignature(hash, signature.Data);
        }
        /*public static bool Verify(Signature signature, byte[] emailData)
        {
            return Verify(signature, Encoding.ASCII.GetString(emailData));
        }
        /*public static bool Verify(Signature signature, string emailDatastr)
        {
            
        }*/
        public PublicKeyRecord GetPublicKeyRecord()
        {
            byte[] data = Validator.GetTxtRecords(Selector + "._domainkey." + Domain);
            return PublicKeyRecord.Parse(Encoding.ASCII.GetString(data,0,data.Length));
        }
        public SendingDomainPolicy GetSendingDomainPolicy()
        {
            byte[] data = Validator.GetTxtRecords("._domainkey." + Domain);
            return SendingDomainPolicy.Parse(Encoding.ASCII.GetString(data,0,data.Length));
        }
        public bool Verify()
        {
            if (_signedMessage == null) throw new NotSupportedException("The signature must me associated with a message in order to be verified");
            return Verify(_signedMessage.OriginalData, _signedMessage.Signatures.DomainKeys);
        }
        private static void FillRSAPublicKeyParameters(byte[] key, ref RSAParameters param)
        {
            int index = 0;
            int contentLength = 0;

            if (key[index] != 48)
                throw new FormatException("Main sequence OID tag not found");

            index++;
            // We skip the Sequence OID tag
            GetContentLength(key, ref index);

            if (key[index] != 48)
                throw new FormatException("RSA OID sequence not found");

            index++;
            // We skip the RSA OID sequence
            contentLength = GetContentLength(key, ref index);
            index += contentLength;

            if (key[index] != 3)
                throw new FormatException("Bit String OID tag not found");

            index++;
            // We skip the Bit String OID tag
            GetContentLength(key, ref index);

            // We skip an unused byte
            index++;

            if (key[index] != 48)
                throw new FormatException("Public key Sequence OID tag not found");

            index++;
            // We skip the Sequence OID tag
            GetContentLength(key, ref index);

            if (key[index] != 2)
                throw new FormatException("\"n\" Integer OID tag not found");

            index++;
            // This is "n", the Modulus
            CopyContent(key, ref index, ref param.Modulus);

            if (key[index] != 2)
                throw new FormatException("\"e\" Integer OID tag not found");

            index++;
            // This is "e", the Exponent
            CopyContent(key, ref index, ref param.Exponent);
        }
        /// <summary>
        /// This method extracts the DER encoded length of a content tag in the 
        /// byte array.
        /// This method assumes that the specified lengthStartIndex is located
        /// at the first length byte.
        /// When this method returns, the lengthStartIndex will have been modified to point
        /// to the first byte of the actual content that follows the length byte(s).
        /// </summary>
        private static int GetContentLength(byte[] key, ref int lengthStartIndex)
        {
            int length = 0;

            // DER does not allow the indefinite form of length encoding (== 128)
            if (key[lengthStartIndex] == 128)
                throw new FormatException("Indefinite length encoding not supported.");

            if (key[lengthStartIndex] > 128)
            {
                // The length is encoded on more than one byte.
                int lengthBytes = key[lengthStartIndex] - 128;

                lengthStartIndex++;
                while (lengthBytes > 0)
                {
                    length += key[lengthStartIndex] << (8 * (lengthBytes - 1));
                    lengthStartIndex++;
                    lengthBytes--;
                }
            }
            else
            {
                length = key[lengthStartIndex];
                lengthStartIndex++;
            }

            return length;
        }

        /// <summary>
        /// This method copies the content bytes of the current content node specified
        /// by the startIndex value.
        /// This method assumes that startIndex is located at the first byte of the length
        /// byte(s).
        /// This method assumes that the content is an DER encoded Integer value.
        /// </summary>
        private static void CopyContent(byte[] source, ref int startIndex, ref byte[] destination)
        {
            int length = GetContentLength(source, ref startIndex);

            if (source[startIndex] == 0)
            {
                // The first bit of the first byte indicates the sign of the integer (it is
                // represented as the two's complement of the integer). Since, in RSA, the
                // integer are always positive, the first byte will either be significant
                // (less than 128) or 0, in which case we simply ignore it.
                startIndex++;
                length--;
            }

            destination = new byte[length];
            Array.Copy(source, startIndex, destination, 0, length);
            startIndex += length;
        }

        private Message _signedMessage;
        private byte[] _b;
        private string _a = "rsa-sha1", _b64, _d, _s;
        private QueryMethod _q = QueryMethod.Dns;
        private CanonicalizationAlgorithm _c;
        private string[] _h;

        public string Algorithm
        {
            get { return _a; }
            set { _a = value; }
        }
        public byte[] Data
        {
            get { return _b; }
            set { _b = value; }
        }
        public string DataBase64
        {
            get { return _b64; }
            set { _b64 = value; }
        }
        public CanonicalizationAlgorithm CanonicalizationAlgorithm
        {
            get { return _c; }
            set { _c = value; }
        }
        public QueryMethod QueryMethod
        {
            get { return _q; }
            set { _q = value; }
        }
        public string[] SignedHeaders
        {
            get { return _h; }
            set { _h = value; }
        }
        public string Domain
        {
            get { return _d; }
            set { _d = value; }
        }
        public string Selector
        {
            get { return _s; }
            set { _s = value; }
        }
    }
}