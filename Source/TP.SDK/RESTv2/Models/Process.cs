using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Process
    {
        // Values

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Resource collections

        public Collection<Project> Projects { get; set; }
        public Collection<Practice> Practices { get; set; }
        public CustomFieldValueCollection CustomValues { get; set; }
        public Collection<User> ProcessAdmins { get; set; }
        public Collection<Term> Term { get; set; }
        public Collection<Workflow> Workflows { get; set; }
        public Collection<RoleEntityTypeProcessSetting> RoleEntityTypeProcessSettings { get; set; }
    }
}
