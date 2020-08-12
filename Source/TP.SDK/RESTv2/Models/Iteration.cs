using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Iteration : General
    {
        // Properties

        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public bool IsCurrent { get; set; }
        public decimal Velocity { get; set; }
        public int Duration { get; set; }
        public decimal Progress { get; set; }
        public bool CanBeFinished { get; set; }
        public string Units { get; set; }
        public DateTime ForecastEndDate { get; set; }

        // Resource references

        public Release Release { get; set; }

        // Resource collections

        public Collection<Assignable> Assignables { get; set; }
        public Collection<UserStory> Userstories { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<Build> Builds { get; set; }
    }
}
