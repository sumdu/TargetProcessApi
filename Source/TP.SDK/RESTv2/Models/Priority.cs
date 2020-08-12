using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Priority
    {
        // Values

        public int Id { get; set; }
        public string Name { get; set; }
        public int Importance { get; set; }
        public bool IsDefault { get; set; }

        // Resource references

        public EntityType EntityType { get; set; }

        // Resource collections

        public Collection<Assignable> Assignables { get; set; }
        public Collection<TestCase> TestCases { get; set; }
    }
}
