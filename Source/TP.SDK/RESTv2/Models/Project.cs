using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    // https://md5.tpondemand.com/api/v1/Projects/meta

    public class Project : General
    {
        // Properties

        public decimal Effort { get; set; }
        public decimal EffortCompleted { get; set; }
        public decimal EffortToDo { get; set; }
        public bool IsActive { get; set; }
        public bool IsProduct { get; set; }
        public string Abbreviation { get; set; }
        public string MailReplyAddress { get; set; }
        public string Color { get; set; }
        public decimal Progress { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime LastStateChangeDate { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime ForecastEndDate { get; set; }
        public DateTime AnticipatedEndDate { get; set; }
        public double LeadTime { get; set; }
        public double CycleTime { get; set; }
        public string Units { get; set; }

        // Resource references

        public Program Program { get; set; }
        public Process Process { get; set; }
        public EntityState EntityState { get; set; }
        public Company Company { get; set; }

        // Resource collections

        public Collection<General> Generals { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<PortfolioEpic> PortfolioEpics { get; set; }
        public Collection<Release> Releases { get; set; }
        public Collection<Release> CrossProjectReleases { get; set; }
        public Collection<Iteration> Iterations { get; set; }
        public Collection<UserStory> UserStories { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestCase> TestCases { get; set; }
        public Collection<TestPlan> TestPlans { get; set; }
        public Collection<Build> Builds { get; set; }
        public Collection<Time> Times { get; set; }
        public Collection<Revision> Revisions { get; set; }
        public Collection<CustomActivity> CustomActivities { get; set; }
        public Collection<ProjectMember> ProjectMembers { get; set; }
        public Collection<TeamProject> TeamProjects { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
        public Collection<ProjectAllocation> Allocations { get; set; }
        public Collection<UserProjectAllocation> UserAllocations { get; set; }
        public Collection<TeamProjectAllocation> TeamAllocations { get; set; }
        public Collection<Impediment> Impediments { get; set; }
        public Collection<MilestoneProject> MilestoneProjects { get; set; }

    }
}
