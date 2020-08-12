using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class RoleEntityTypeProcessSetting
    {
        // Values

        public int Id { get; set; }

        public bool CanBeAssigned { get; set; }

        // Resource references

        public Role Role { get; set; }
        public EntityType EntityType { get; set; }
        public Process Process { get; set; }
    }
}
