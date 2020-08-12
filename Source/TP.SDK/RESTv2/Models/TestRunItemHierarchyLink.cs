using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestRunItemHierarchyLink
    {
        // Value

        public int Id { get; set; }

        // Resource references

        public TestCaseRun TestCaseRun { get; set; }
        public TestPlanRun TestPlanRun { get; set; }
    }
}
