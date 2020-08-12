using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace TP.SDK.RESTv2.Models
{
    public class EntityState
    {
        // Values

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInitial { get; set; }
        public bool IsFinal { get; set; }
        public bool IsPlanned { get; set; }
        public bool IsCommentRequired { get; set; }
        public double NumericPriority { get; set; }

        // Resource references

        public Role Role { get; set; }
        public EntityState ParentEntityState { get; set; }
        public Workflow Workflow { get; set; }

        // Resource collections

        public Collection<EntityState> NextStates { get; set; }
        public Collection<EntityState> PreviousStates { get; set; }
        public Collection<Assignable> Assignables { get; set; }
        public Collection<Impediment> Impediments { get; set; }
        public Collection<Project> Projects { get; set; }
        public Collection<EntityState> SubEntityStates { get; set; }
        public Collection<TeamAssignment> TeamAssignments { get; set; }

    }
}
