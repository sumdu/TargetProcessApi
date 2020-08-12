using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Tag
    {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; }

        // Resource collections

        public Collection<General> Generals { get; set; }
    }
}
