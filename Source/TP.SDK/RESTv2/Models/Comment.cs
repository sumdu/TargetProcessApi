using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Comment
    {
        // Properties

        public int Id { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public DateTime CreateDate { get; set; }

        // Resource references

        public GeneralUser Owner { get; set; }

    }
}
