using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    // https://md5.tpondemand.com/api/v1/Features/meta

    public class Feature : Assignable
    {
        // Properties

        public decimal InitialEstimate { get; set; }

        // Resource references

        // public PortfolioEpic PortfolioEpic { get; set; }
        public Epic Epic { get; set; }
        // public Build Build { get; set; }

        // Resource collections

        public Collection<UserStory> UserStories { get; set; }
        public Collection<FeatureSimpleHistory> History { get; set; }
        public Collection<Bug> Bugs { get; set; }
    }
}

