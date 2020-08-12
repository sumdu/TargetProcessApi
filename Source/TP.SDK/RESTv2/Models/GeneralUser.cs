using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class GeneralUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdministrator { get; set; }
        public string Locale { get; set; }
        public UserEntityKind Kind { get; set; }
        // public string GlobalId { get; set; }
        // public string Password { get; set; }
        public string AvatarUri { get; set; } // Uri type
    }

    public enum UserEntityKind
    {
        None,
        User,
        SystemUser,
        Requester,
        Contact
    }
}
