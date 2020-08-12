using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Impediment : General
    {
        // Values

        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }

        // Resource references

        public Assignable Assignable { get; set; }
        public EntityState EntityState { get; set; }
        public Priority Priority { get; set; }
        public User Responsible { get; set; }

        // Resource collections

        public Collection<ImpedimentSimpleHistory> History { get; set; }
    }
}
