using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class RequestSimpleHistory
    {
        // Values

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }

        // Resource references

        public Project Project { get; set; }
        public EntityState EntityState { get; set; }
        public GeneralUser Modifier { get; set; }
        public Request Request { get; set; }
        public Release Release { get; set; }
        public Iteration Iteration { get; set; }
    }
}
