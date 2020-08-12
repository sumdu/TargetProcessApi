using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class PortfolioEpic : Assignable
    {
        // Values
        public decimal InitialEstimate { get; set; }

        // Resource collections

        public Collection<Epic> Epics { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<PortfolioEpicSimpleHistory> History { get; set; }
    }
}
