using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestCase : General
    {
        // Values

        public TestCaseRunStatus LastRunStatus { get; set; }
        public string LastFailureComment { get; set; }
        public DateTime LastRunDate { get; set; }

        // Resource references

        public Priority Priority { get; set; }

        // Resource collections

        public Collection<UserStory> UserStories { get; set; }
        public Collection<TestPlan> TestPlans { get; set; }
        public Collection<TestCaseRun> TestCaseRuns { get; set; }
        public Collection<TestStep> TestSteps { get; set; }

    }

    public enum TestCaseRunStatus 
    { 
        NotRun,
        Passed,
        Failed,
        OnHold,
        Blocked
    }
}
