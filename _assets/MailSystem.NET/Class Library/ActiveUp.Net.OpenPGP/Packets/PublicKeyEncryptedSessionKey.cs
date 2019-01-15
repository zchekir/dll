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
using ActiveUp.Net.OpenPGP;

namespace ActiveUp.Net.Security.OpenPGP.Packets
{
    public class PublicKeyEncryptedSessionKey : Packet
    {
        // TODO : Cl�s sp�cifiques � l'algorithme

        public static PublicKeyEncryptedSessionKey Parse(Packet input)
        {
            PublicKeyEncryptedSessionKey pkesk = (PublicKeyEncryptedSessionKey)input;
            byte[] content = pkesk.RawData;
            pkesk.VersionNumber = content[0];
            
            byte[] keyID = new byte[8];
            Array.Copy(content, 1, keyID, 0, 8);
            //ActiveUp.Net.Mail.Logger.AddEntry(Encoding.ASCII.GetString(keyID));
            pkesk.KeyID = Converter.ToULong(keyID);

            pkesk.PublicKeyAlgorithm = (PublicKeyAlgorithm)content[9];

            return pkesk;
        }

        public int VersionNumber { get; set; }
        public ulong KeyID { get; set; }
        public PublicKeyAlgorithm PublicKeyAlgorithm { get; set; }
        public byte[] SessionKey { get; set; }
    }
}