using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TeamMember
    {
        // Values

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Resource references

        public Team Team { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }

    }
}
