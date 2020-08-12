using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Team : General
    {
        // Values

        public string Icon { get; set; }
        public bool IsActive { get; set; }
        public string Abbreviation { get; set; }
        public string IconUri { get; set; }

        // Resource collections

        public Collection<TeamMember> TeamMembers { get; set; }
        public Collection<TeamProject> TeamProjects { get; set; }
        public Collection<Assignable> Assignables { get; set; }
        public Collection<UserStory> UserStories { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<PortfolioEpic> PortfolioEpics { get; set; }
        public Collection<TeamIteration> TeamIterations { get; set; }
        public Collection<TestPlan> TestPlans { get; set; }
        public Collection<Workflow> SuggestedWorkflows { get; set; }


    }
}
