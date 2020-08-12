using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TeamProjectAllocation : ProjectAllocation
    {
        // Resource references

        public TeamProject TeamProject { get; set; }
    }
}
