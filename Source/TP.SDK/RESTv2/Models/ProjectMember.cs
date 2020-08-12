using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class ProjectMember
    {
        // Values

        public int Id { get; set; }
        public decimal WeeklyAvailableHours { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public DateTime MembershipEndDate { get; set; }
        public int Allocation { get; set; }
        public bool IsActive { get; set; }

        // Resource references

        public Project Project { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }

        // Resource collections

        public Collection<UserProjectAllocation> Allocations { get; set; }

    }
}
