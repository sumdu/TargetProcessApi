using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Milestone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string CssClass { get; set; }

        // Resource references

        public User Owner { get; set; }
        public EntityType EntityType { get; set; }

        // Resource collections

        public Collection<General> Generals { get; set; }
        public Collection<MilestoneProject> MilestoneProjects { get; set; }

    }
}
