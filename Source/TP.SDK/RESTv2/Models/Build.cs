using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Build : General
    {
        // Values

        public DateTime BuildDate { get; set; }

        // Resource references

        public Release Release { get; set; }
        public Iteration Iteration { get; set; }

        // Resource collections

        public Collection<Bug> Bugs { get; set; }
        public Collection<UserStory> UserStories { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }

    }
}
