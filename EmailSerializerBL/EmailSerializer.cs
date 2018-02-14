using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace EmailSerializerBL
{
    public class EmailSerializer
    {
        private EmailClient emailClient = new SmtpEmailClient();
        private PersistanceService persister = new JsonPersister();

        public void ReadEmails()
        {
            List<Email> emails = emailClient.ReadEmails();

            foreach(Email email in emails)
            {
                persister.Persist(email);
            }
        }
    }
}
