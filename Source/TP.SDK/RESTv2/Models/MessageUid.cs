using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class MessageUid
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string MailServer { get; set; }
        public string MailLogin { get; set; }

    }
}
