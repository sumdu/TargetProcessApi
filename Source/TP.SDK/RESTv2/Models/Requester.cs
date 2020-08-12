using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Requester : GeneralUser
    {
        // Values
        public string Phone { get; set; }
        public string Notes { get; set; }
        public RequesterSourceTypeEnum SourceType { get; set; }

        // Resource references

        public Company Company { get; set; }

    }

    public enum RequesterSourceTypeEnum 
    { 
        None,
        Mail,
        External,
        Internal
    }
}
