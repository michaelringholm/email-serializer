using EmailSerializerBL;
using System;
using System.Diagnostics;

namespace EmailSerializerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Debug.WriteLine("Starting!");
                EmailSerializer emailSerializer = new EmailSerializer();
                emailSerializer.ReadEmails();
            }
            finally
            {
                Debug.WriteLine("Done.");
            }
        }
    }
}
