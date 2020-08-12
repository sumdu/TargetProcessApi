using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestPlan : Assignable
    {
        // Values

        public decimal InitialEstimate { get; set; }
        public decimal CalculatedEstimate { get; set; }

        // Resource references

        public General LinkedGeneral { get; set; }
        public Assignable LinkedAssignable { get; set; }
        public Epic LinkedEpic { get; set; }
        public Feature LinkedFeature { get; set; }
        public UserStory LinkedUserStory { get; set; }
        public Task LinkedTask { get; set; }
        public Bug LinkedBug { get; set; }
        public Request LinkedRequest { get; set; }
        public Build LinkedBuild { get; set; }
        public Release LinkedRelease { get; set; }
        public Iteration LinkedIteration { get; set; }
        public TeamIteration LinkedTeamIteration { get; set; }

        // Resource collections

        public Collection<TestCase> TestCases { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<TestPlan> ChildTestPlans { get; set; }
        public Collection<TestPlan> ParentTestPlans { get; set; }
        public Collection<UserStory> UserStories { get; set; }

    }
}
