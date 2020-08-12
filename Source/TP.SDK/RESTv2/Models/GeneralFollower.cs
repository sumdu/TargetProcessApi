using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class GeneralFollower
    {
        // Values

        public int Id { get; set; }

        // Resource references

        public General General { get; set; }
        public User User { get; set; }

    }
}
