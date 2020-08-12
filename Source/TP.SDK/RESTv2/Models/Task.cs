using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Task : Assignable
    {
        // Resource references

        public UserStory UserStory { get; set; }

        // Resource collections

        public Collection<TaskSimpleHistory> History { get; set; }
    }
}
