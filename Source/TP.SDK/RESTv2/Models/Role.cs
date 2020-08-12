using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Role
    {
        // Values

        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasEffort { get; set; }
        public bool CanChangeOwner { get; set; }
        public bool TimeSheetAccess { get; set; }
        public bool PeopleAccess { get; set; }

        // Resource collections

        public Collection<Time> Times { get; set; }
        public Collection<User> Users { get; set; }
        public Collection<RoleEntityType> RoleEntityTypes { get; set; }
        public Collection<RoleEffort> RoleEfforts { get; set; }
        public Collection<EntityState> EntityStates { get; set; }

    }
}
