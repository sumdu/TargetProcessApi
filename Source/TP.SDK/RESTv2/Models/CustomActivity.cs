using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class CustomActivity
    {
        // Values

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public decimal Estimate { get; set; }

        // Resource references

        public Project Project { get; set; }
        public User User { get; set; }

        // Resource collections

        public Collection<Time> Times { get; set; }
    }
}
