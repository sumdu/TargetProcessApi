using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    // https://md5.tpondemand.com/api/v1/UserStories/meta

    public class UserStory : Assignable
    {
        // Properties

        
        public decimal InitialEstimate { get; set; }

        // Resource references

        public Feature Feature { get; set; }
        // public Build Build { get; set; }

        // Resource collections

        public Collection<Task> Tasks { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestCase> UserStoryTestCases { get; set; }
        public Collection<TestPlan> UserStoryTestPlans { get; set; }
        public Collection<UserStorySimpleHistory> History { get; set; }
    }
}

