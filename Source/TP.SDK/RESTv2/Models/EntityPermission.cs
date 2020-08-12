using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class EntityPermission
    {
        // Values

        public int Id { get; set; }
        public int EntityId { get; set; }
        public byte[] Version { get; set; }
        public bool GrantAccess { get; set; }
        public bool View { get; set; }
        public bool Comment { get; set; }
        public bool Edit { get; set; }

        // Resource references

        public EntityType EntityType { get; set; }
        public GeneralUser User { get; set; }
        public General General { get; set; }

    }
}
