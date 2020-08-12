using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Message
    {
        // Properties

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Recipients { get; set; }
        public string Body { get; set; }
        public bool IsRead { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime SendDate { get; set; }
        public MessageTypeEnum MessageType { get; set; }
        public ContentTypeEnum ContentType { get; set; }

        // Resource references

        public GeneralUser From { get; set; }
        public GeneralUser To { get; set; }
        public MessageUid MessageUid { get; set; }

    }

    public enum MessageTypeEnum
    {
        None,
        Inbox,
        Outbox,
        Public
    }

    public enum ContentTypeEnum
    {
        None,
        Mail,
        Error,
        Email
    }
}
