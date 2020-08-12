using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class Assignable : General
    {
        // Properties

        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public decimal Progress { get; set; }
        public decimal TimeSpent { get; set; }
        public decimal TimeRemain { get; set; }
        public DateTime LastStateChangeDate { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public string Units { get; set; }
        public double LeadTime { get; set; }
        public double CycleTime { get; set; }
        public DateTime ForecastEndDate { get; set; }

        // Resource references

        public Release Release { get; set; }
        public Iteration Iteration { get; set; }
        public TeamIteration TeamIteration { get; set; }
        public Priority Priority { get; set; }
        public EntityState EntityState { get; set; }
        public TeamAssignment ResponsibleTeam { get; set; }

        // Resource collections

        public Collection<GeneralUser> AssignedUser { get; set; }
        public Collection<Assignment> Assignments { get; set; }
        public Collection<Impediment> Impediments { get; set; }
        public Collection<Time> Times { get; set; }
        public Collection<RoleEffort> RoleEfforts { get; set; }
        public Collection<AssignedEffort> AssignedEfforts { get; set; }
        public Collection<Revision> Revisions { get; set; }
        public Collection<TeamAssignment> AssignedTeams { get; set; }
    }
}
