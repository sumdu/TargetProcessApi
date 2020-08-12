using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class OutboundAssignable
    {
        // Resource references

        public RelationType RelationType { get; set; }
        public General InboundGeneral { get; set; }
    }
}
