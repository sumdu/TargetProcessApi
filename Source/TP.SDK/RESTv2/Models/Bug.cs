using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    // https://md5.tpondemand.com/api/v1/Bugs/meta

    public class Bug : Assignable
    {
        // Properties

        // Resource references

        public Build Build { get; set; }
        public UserStory UserStory { get; set; }
        public Feature Feature { get; set; }
        public Severity Severity { get; set; }

        // Resource collections

        public Collection<BugSimpleHistory> History { get; set; }
        public Collection<TestCaseRun> TestCaseRuns { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}

