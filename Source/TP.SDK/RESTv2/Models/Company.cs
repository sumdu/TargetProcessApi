using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Company
    {
        // Values

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        // Resource collections

        public Collection<Project> Projects { get; set; }
        public Collection<Requester> Requesters { get; set; }

    }
}
