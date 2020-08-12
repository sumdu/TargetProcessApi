using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Workflow
    {
        // Values 

        public int Id { get; set; }
        public string Name { get; set; }

        // Resource references

        public Process Process { get; set; }
        public EntityType EntityType { get; set; }
        public Workflow ParentWorkflow { get; set; }

        // Resource collections

        public Collection<EntityState> EntityStates { get; set; }
        public Collection<Workflow> SubWorkflows { get; set; }
        public Collection<TeamProject> TeamProjects { get; set; }
    }
}
