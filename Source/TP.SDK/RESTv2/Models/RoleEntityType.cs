using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class RoleEntityType
    {
        // Values

        public int Id { get; set; }
        public bool IsDeleteEnabled { get; set; }
        public bool IsEditEnabled { get; set; }
        public bool IsAddEnabled { get; set; }

        // Resource references

        public EntityType EntityType { get; set; }
        public Role Role { get; set; }

    }
}
