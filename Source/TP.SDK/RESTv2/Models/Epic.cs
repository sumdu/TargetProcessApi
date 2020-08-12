using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    // https://md5.tpondemand.com/api/v1/Epic/meta

    public class Epic : Assignable
    {
        // Properties

        public decimal InitialEstimate { get; set; }

        // Resource references

        // public PortfolioEpic PortfolioEpic { get; set; }
        // public Build Build { get; set; }

        // Resource collections

        public Collection<Feature> Features { get; set; }
        public Collection<EpicSimpleHistory> History { get; set; }
    }
}

