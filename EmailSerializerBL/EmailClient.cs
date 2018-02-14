using System.Collections.Generic;

namespace EmailSerializerBL
{
    public interface EmailClient
    {
        List<Email> ReadEmails();
        void SendEmail(Email email);
    }
}