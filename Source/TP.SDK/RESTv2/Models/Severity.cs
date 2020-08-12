using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Severity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Importance { get; set; }
        public bool IsDefault { get; set; }

        // Resource collections

        public Collection<Bug> Bugs { get; set; }

    }
}
