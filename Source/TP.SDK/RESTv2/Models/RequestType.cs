using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class RequestType
    {
        // Values 

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public bool IsPrivateByDefault { get; set; }
        public bool IsVotingEnabled { get; set; }

        // Resource collections

        public Collection<Request> Requests { get; set; }

    }
}
