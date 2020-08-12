using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Time
    {
        // Values

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Spent { get; set; }
        public decimal Remain { get; set; }
        public bool IsEstimation { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }

        // Resource references

        public Assignable Assignable { get; set; }
        public UserStory UserStory { get; set; }
        public Task Task { get; set; }
        public Bug Bug { get; set; }
        public Request Request { get; set; }
        public TestPlan TestPlan { get; set; }
        public TestPlanRun TestPlanRun { get; set; }
        public CustomActivity CustomActivity { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }

        // Resource collections

        public CustomFieldValueCollection CustomValues { get; set; }
    }
}
