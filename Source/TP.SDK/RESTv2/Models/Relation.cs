using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Relation
    {
        // Properties

        public int Id { get; set; }

        // Resource references

        public General Master { get; set; }
        public General Slave { get; set; }
        public RelationType RelationType { get; set; }
    }
}
