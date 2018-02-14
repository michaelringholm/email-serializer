using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSerializerBL
{
    public class Email
    {
        public String Subject { get; set; }
        public String Body { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public DateTime Date { get; set; }
    }
}
