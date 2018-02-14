using S22.Imap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace EmailSerializerBL
{
    public class SmtpEmailClient : EmailClient
    {
        public List<Email> ReadEmails()
        {
            List<Email> emails = new List<Email>();
            S22.Imap.IImapClient imapClient = new S22.Imap.ImapClient("imap.gmail.com", 993, "mrs.commentor@gmail.com", "Demo1234!", AuthMethod.Login, true);
            IEnumerable<String> mailboxes = imapClient.ListMailboxes();
            foreach(String mailbox in mailboxes)
            {
                Debug.WriteLine(mailbox);
            }

            IEnumerable<uint> uids = imapClient.Search(SearchCondition.All(), "INBOX");
            IEnumerable<MailMessage> messages = imapClient.GetMessages(uids);

            foreach (MailMessage message in messages)
            {
                Debug.WriteLine(message.Subject);
                emails.Add(new Email { Subject = message.Subject, Body = message.Body, From = message.From.ToString(), To = message.To.ToString(), Date = message.Date().Value });
            }

            return emails;
        }

        public void SendEmail(Email email)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            //return null;
        }
    }
}
