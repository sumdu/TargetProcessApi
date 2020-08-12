using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TeamAssignment
    {
        // Values

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Resource references

        public Team Team { get; set; }
        public Assignable Assignable { get; set; }
        public EntityState EntityState { get; set; }

    }
}
