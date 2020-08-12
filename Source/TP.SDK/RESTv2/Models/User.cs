using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class User : GeneralUser
    {
        // Value

        public DateTime LastLoginDate { get; set; }
        public decimal WeeklyAvailableHours { get; set; }
        public decimal CurrentAvailableHours { get; set; }
        public DateTime AvailableFrom { get; set; }
        public int AvailableFutureAllocation { get; set; }
        public decimal AvailableFutureHours { get; set; }
        public bool IsObserver { get; set; }
        // public bool IsContributor { get; set; }
        public string Skills { get; set; }
        public string ActiveDirectoryName { get; set; }
        //public RichEditorTypeEnum RichEditor { get; set; }

        // Resource references

        public Role Role { get; set; }

        // Resource collections

        public Collection<Time> Times { get; set; }
        public Collection<Impediment> Impediments { get; set; }
        public Collection<CustomActivity> CustomActivities { get; set; }
        public Collection<Revision> Revisions { get; set; }
        public Collection<TeamMember> TeamMembers { get; set; }
        public Collection<ProjectMember> ProjectMembers { get; set; }
        public Collection<Milestone> Milestones { get; set; }
        public Collection<Process> AdminProcesses { get; set; }
        public Collection<GeneralFollower> Following { get; set; }

    }

    public enum RichEditorTypeEnum 
    {
        Html,
        Markdown
    }
}
