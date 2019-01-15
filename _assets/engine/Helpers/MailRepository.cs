/*
 * Created by Ranorex
 * User: DWood
 * Date: 26/11/2018
 * Time: 9:59 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using ActiveUp.Net.Mail;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace engine.Helpers
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class MailRepository
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        private Imap4Client client;
        
        public MailRepository(string mailServer, int port, bool ssl, string login, string password)
        {
        	if (ssl)
        		Client.ConnectSsl(mailServer, port);
        	else
        		Client.Connect(mailServer, port);
        	Client.Login(login, password);
        }
        
        private IEnumerable<Message> GetAllMails(string mailBox)
        {
        	return GetMails(mailBox, "ALL").Cast<Message>();
        }
        
        private IEnumerable<Message> GetUnreadMails(string mailBox)
        {
        	return GetMails(mailBox, "UNSEEN").Cast<Message>();
        }
        
        protected Imap4Client Client
        {
        	get { return client ?? (client = new Imap4Client()); }
        }
        
        private MessageCollection GetMails(string mailBox, string searchPhrase)
        {
        	Mailbox mails = Client.SelectMailbox(mailBox);
        	MessageCollection messages = mails.SearchParse(searchPhrase);
        	return messages;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        [UserCodeMethod]
        public static void ReadLastEmail(string emailAddress, string password)
        {
        	var mailRepository = new MailRepository(
        											"imap.gmail.com",
        	                                        993,
        	                                        true,
        	                                        emailAddress,
        	                                        password
        	                                       );
        	
        	var emailList = mailRepository.GetUnreadMails("inbox");
        	
        	foreach (Message email in emailList)
        	{
        		Report.Log(ReportLevel.Info, "User", string.Format("From: {0} Subject: {1} Body: {2}", email.From, email.Subject, email.BodyHtml.Text));
        	}
        	
        }
        
    }
}
