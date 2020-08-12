using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace TP.SDK.RESTv2.Models
{
    public class Assignment
    {
        // Values

        public int Id { get; set; }

        // Resource references

        public Assignable Assignable { get; set; }
        public User GeneralUser { get; set; }
        public Role Role { get; set; }

    }
}
