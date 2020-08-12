using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class ProjectAllocation
    {
        // Values

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public int Percentage { get; set; }
        public bool IsEffective { get; set; }
        public DateTime EffectiveEndDate { get; set; }

        // Resource references

        public EntityType EntityType { get; set; }
        public Project Project { get; set; }
    }
}
