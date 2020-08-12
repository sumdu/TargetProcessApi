using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    // https://md5.tpondemand.com/api/v1/Requests/meta

    public class Request : Assignable
    {
        // Properties

        public RequestSourceEnum SourceType { get; set; }
        public bool IsReplied { get; set; }
        public bool IsPrivate { get; set; }
        public int VotesCount { get; set; }

        // Resource references

        public RequestType RequestType { get; set; }
        // public Build Build { get; set; }

        // Resource collections

        public Collection<GeneralUser> Requesters { get; set; }
        // public Collection<User> Users { get; set; }
        public Collection<RequestSimpleHistory> History { get; set; }
    }
}

