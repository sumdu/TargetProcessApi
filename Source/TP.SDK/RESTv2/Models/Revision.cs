using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Revision
    {
        // Values

        public int Id { get; set; }
        public string SourceControlId { get; set; }
        public string Description { get; set; }
        public DateTime CommitDate { get; set; }

        // Resource references

        public Project Project { get; set; }
        public User Author { get; set; }

        // Resource collections

        public Collection<RevisionFile> RevisionFiles { get; set; }
        public Collection<Assignable> Assignables { get; set; }
    }
}
