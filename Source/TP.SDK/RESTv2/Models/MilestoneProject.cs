using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class MilestoneProject
    {
        // Values

        public int Id { get; set; }

        // Resource references

        public Project Project { get; set; }
        public Milestone Milestone { get; set; }

    }
}
