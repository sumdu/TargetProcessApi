using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestPlanRun : Assignable
    {
        // Values

        public int NotRunCount { get; set; }
        public int PassedCount { get; set; }
        public int FailedCount { get; set; }
        public int OnHoldCount { get; set; }
        public int BlockedCount { get; set; }
        public bool IsLastStarted { get; set; }

        // Resource references

        public Build Build { get; set; }
        public TestPlan TestPlan { get; set; }
        public TestPlanRun ParentTestPlanRun { get; set; }

        // Resource collections

        public Collection<TestCaseRun> TestCaseRuns { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestRunItemHierarchyLink> TestCaseRunLinks { get; set; }

    }
}
