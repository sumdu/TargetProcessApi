using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class General
    {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime LastCommentDate { get; set; }
        public string Tags { get; set; }
        public double NumericPriority { get; set; }
        public bool IsNow { get; set; }
        public bool IsNext { get; set; }
        public bool IsPrevious { get; set; }

        // Resource references

        public EntityType EntityType { get; set; }
        // public GeneralUser LastEditor { get; set; }
        public GeneralUser Owner { get; set; }
        public GeneralUser LastCommentedUser { get; set; }
        public Project Project { get; set; }
        public Team Team { get; set; }
        //public TestPlan LinkedTestPlan { get; set; }
        //public Milestone Milestone { get; set; }

        // Resource collections

        public CustomFieldValueCollection CustomValues { get; set; }
        public Collection<Comment> Comments { get; set; }
        public Collection<Message> Messages { get; set; }

        public Collection<Tag> TagObjects { get; set; }
        public Collection<Relation> MasterRelations { get; set; }
        public Collection<Relation> SlaveRelations { get; set; }
        //public Collection<GeneralFollower> Followers { get; set; }
        public Collection<InboundAssignable> InboundAssignables { get; set; }
        public Collection<OutboundAssignable> OutboundAssignables { get; set; }
        public Collection<Attachment> Attachments { get; set; }
        // public Collection<EntityPermission> EntityPermissions { get; set; }
    }
}
