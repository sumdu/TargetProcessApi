using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class AssignedEffort
    {
        // Values

        public int Id { get; set; }
        public decimal InitialEstimate { get; set; }
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public decimal TimeSpent { get; set; }
        public decimal TimeRemain { get; set; }

        // Resource references

        public Assignable Assignable { get; set; }
        public Role Role { get; set; }
        public User GeneralUser { get; set; }
    }
}
