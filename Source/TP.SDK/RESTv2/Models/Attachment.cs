using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Attachment
    {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public string Uri { get; set; }
        public string ThumbnailUri { get; set; }
        public string MimeType { get; set; }
        public Int32 Size { get; set; }

        // Resource references

        public GeneralUser Owner { get; set; }
        public General General { get; set; }
        public Message Message { get; set; }
    }
}
