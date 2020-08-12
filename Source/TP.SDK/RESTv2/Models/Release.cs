using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Process = TP.SDK.RESTv2.Models.Process;

namespace TP.SDK.RESTv2.Models
{
    public class Release : General
    {

        // Properties

        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public bool IsCurrent { get; set; }
        public decimal Progress { get; set; }
        public string Units { get; set; }
        public DateTime ForecastEndDate { get; set; }

        // Resource references

        public Process Process { get; set; }

        // Resource collections

        public Collection<Iteration> Iterations { get; set; }
        public Collection<TeamIteration> TeamIterations { get; set; }
        public Collection<Assignable> Assignables { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<UserStory> Userstories { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<Build> Builds { get; set; }
        public Collection<TestPlan> TestPlans { get; set; }
        public Collection<Project> Projects { get; set; }
    }
}
