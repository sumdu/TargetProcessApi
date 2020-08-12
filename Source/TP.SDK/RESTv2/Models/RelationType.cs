using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class RelationType
    {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; }

        // Resource collections

        public Collection<Relation> Relations { get; set; }
    }
}
