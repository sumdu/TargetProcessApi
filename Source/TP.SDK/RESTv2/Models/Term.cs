using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Term
    {
        // Values

        public int Id { get; set; }
        public string WordKey { get; set; }
        public string Value { get; set; }

        // Resource references

        public Process Process { get; set; }
        public EntityType EntityType { get; set; }
    }
}
