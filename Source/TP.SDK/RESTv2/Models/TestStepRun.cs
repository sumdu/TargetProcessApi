using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestStepRun
    {
        // Values

        public int Id { get; set; }
        public bool Passed { get; set; }
        public bool Runned { get; set; }
        public int RunOrder { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }

        // Resource references

        public TestCaseRun TestCaseRun { get; set; }
        public TestStep TestStep { get; set; }

    }
}
