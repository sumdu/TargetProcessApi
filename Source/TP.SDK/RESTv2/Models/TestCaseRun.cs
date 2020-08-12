using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestCaseRun
    {
        // Values

        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime EndRunDate { get; set; }
        public DateTime StartRunDate { get; set; }
        public TestCaseRunStatus Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        public string Success { get; set; }

        // Resource references

        public TestPlanRun TestPlanRun { get; set; }
        public TestPlanRun RootTestPlanRun { get; set; }
        public TestCase TestCase { get; set; }
        public EntityType EntityType { get; set; }
        public Priority Priority { get; set; }
        public User LastExecutor { get; set; }

        // Resource collections

        public Collection<TestStepRun> TestStepRuns { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestRunItemHierarchyLink> TestPlanRunLinks { get; set; }

    }
}
