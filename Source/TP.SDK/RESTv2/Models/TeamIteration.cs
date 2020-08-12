using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TeamIteration : General
    {
        // Properties

        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public bool IsCurrent { get; set; }
        public decimal Capacity { get; set; }
        public decimal Velocity { get; set; }
        public int Duration { get; set; }
        public decimal Progress { get; set; }
        public string Units { get; set; }
        public DateTime ForecastEndDate { get; set; }
        public bool CanBeFinished { get; set; }

        // Resource references

        public Team Team { get; set; }
        public Release Release { get; set; }

        // Resource collections

        public Collection<Assignable> Assignables { get; set; }
        public Collection<UserStory> Userstories { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<TestPlan> TestPlans { get; set; }
    }
}
