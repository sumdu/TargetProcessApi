using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TeamProject
    {
        // Values

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsFullProjectAccess { get; set; }

        // Resource references

        public Team Team { get; set; }
        public Project Project { get; set; }

        // Resource collections

        public Collection<Workflow> Workflows { get; set; }
        public Collection<TeamProjectAllocation> Allocations { get; set; }
    }
}
