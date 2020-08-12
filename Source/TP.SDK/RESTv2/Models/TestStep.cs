using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class TestStep
    {
        // Values

        public int Id { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public int RunOrder { get; set; }

        // Resource references

        public TestCase TestCase { get; set; }

    }
}
