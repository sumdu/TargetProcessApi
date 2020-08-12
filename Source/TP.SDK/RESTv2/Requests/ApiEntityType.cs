using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2
{
    public enum ApiEntityType
    {
        Assignable,                      // Base entity for Epic, Feature, User Story, Task, Bug, Test Plan, Test Plan Run, Request. It can be assigned to people and has workflow.
        AssignedEffort,                  // Effort for Assignable by Role and User.
        Assignment,                      // An assignment of the User Story, Task, Bug, etc. with a specific Role and user.
        Attachment,                      // A file (image, archive, whatever) attached to Entity.
        Bug,                             // Bug or defect (error, flaw, mistake, failure or fault in a computer program). Can relate to User Story. Can be assigned to Release and Iteration.
        Build,                           // Build in a project. Bugs and source code Revisions can be assigned to Build.
        Comment,                         // Can be added to almost any Entity.
        Company,                         // Used to limit Requests visibility in Help Desk. Requesters from Company A will not see Requests from Company B.
        Context,                         // Context contains information about logged User, Culture, selected Projects and Processes.
        CustomActivity,                  // Special type of work you can track Time against.
        CustomField,                     // Custom field is an entity extension which is declared on a process level. As a result entity can contain declared custom field values. Custom fields has following types: Text, DropDown, CheckBox, Url, Date, RichText, Number, Entity. See reference for more details.
        CustomRule,                      // Custom business rules defined by user.
        EntityPermission,                // Container for entity permissions
        EntityState,                     // State of Entity. Collection of EntityStates form Workflow for Entity. For example, Bug has four EntityStates by default: Open, Fixed, Invalid and Done.
        EntityType,                      // Type of Entity. For example: Bug, TestCase, Project.
        Epic,                            // A high-level scope of work which contains Features. Can be assigned to Release. Can't be assigned to Iteration.
        Feature,                         // A high-level requirement which contains user stories. Can be assigned to Release. Can't be assigned to Iteration.
        General,                         // Base entity for Assignable, Build, Impediment, Iteration, Program, Project, Release, Test Case, Test Plan, Bug, Feature, Request, Task, Test Plan Run, User Story.
        GeneralFollower,                 // Relation between user and following entity.
        GeneralUser,                     // Base entity for User and Requester.
        GlobalSettings,                  // Global Application Settings.
        Impediment,                      // Anything that prevents a team member from working as efficiently as possible. Impediment can relate to Task, User Story, Bug or Feature.
        InboundAssignable,               // Inbound relation for Assignable.
        Iteration,                       // A single iteration results in an increment(s) of product functionality. Iteration should relate to a Release.
        Message,                         // Email message from email integration
        MessageUid,                      // Represents reference to downloaded message
        Milestone,                       // Milestones for projects
        MilestoneProject,                // Milestone assigned to a project
        OutboundAssignable,              // Outbound relation for Assignable.
        PortfolioEpic,                   // A high-level scope of work which contains Epics and Features. Can be assigned to Release. Can't be assigned to Iteration.
        Priority,                        // Priority of User Story, Bug or Feature. Examples: Must Have, Nice to Have.
        Process,                         // Set of practices, terms, workflows and custom fields that can be applied to Project.
        Program,                         // Several Projects can be grouped into a Program.
        Project,                         // Core entity which contains Releases, Features, User Stories, Bugs, etc.
        ProjectAllocation,               // Base allocation to a Project
        ProjectMember,                   // Any User that is a part of a Project Team.
        Relation,                        // Relation between two Entities.
        RelationType,                    // Type of relation between Entities.
        Release,                         // Delivering an increment(s) of product functionality to public. Release contains several Iterations.
        ReleaseProject,                  // Project assigned to a release
        Request,                         // Request can represent Idea, Issue or Question from users. Bugs, User Stories and Features can be linked to Requests.
        Requester,                       // Represents a requester.
        RequestType,                     // Type of request (Idea, Issue or Question).
        Revision,                        // A single commit into repository. Contains a set of source files.
        RevisionFile,                    // A source file included to Revision.
        Role,                            // Defines permissions for User.
        RoleEffort,                      // Effort for Assignable by Role. For example, User Story can have 5 hours of Developer effort + 3 hours of Tester effort. The total effort will be 8 hours.
        RoleEntityType,                  // Defines Role permissions for Entities.
        RoleEntityTypeProcessSetting,    // Describe if role can be assigned to entity type in process
        Severity,                        // Severity (badness) of Bug. For example, Blocking, Critical, Small.
        Tag,                             // Tags that can be attached to entities.
        Task,                            // A small chunk of work, typically less than 16 hours. Task must relate to User Story. It is not possible to create Tasks without User Story.
        Team,                            // Group of people working on some projects.
        TeamAssignment,                  // Assignment of the Team with a specific State on Assignable. Known as TeamState.
        TeamIteration,                   // A single iteration results in an increment(s) of product functionality. Team iteration should relate to a Team.
        TeamMember,                      // Any User that is a part of a Team.
        TeamProject,                     // Any Project in which team participates.
        TeamProjectAllocation,           // Team allocation to a Project
        Term,                            // Beta version: Term in Process. Like Bug, User Story, Feature, etc.
        TestCase,                        // A set of steps to determine if a product functionality is working correctly. TestCase relates to User Story.
        TestCaseRun,                     // A single Test Case Run. TestCase can be run many times. It is impossible to create a Test Case Run, instead Add Test Case to Test Plan to create a Test Case Run
        TestPlan,                        // A group of TestCases. For example, you can create 'Smoke Tests' TestPlan and add TestCases there.
        TestPlanRun,                     // A single TestPlan Run. TestPlan can have multiple runs by various Iterations, Releases or Builds.
        TestRunItemHierarchyLink,        // Link between test plan run and test case run. In hierarchical test plan runs each test case run is linked to all parent test plan runs
        TestStep,                        // Single Step of Test Case
        TestStepRun,                     // A single Test Step Run
        Time,                            // Spent/Remaining time for Assignable (Task, User Story, Bug, etc.).
        User,                            // Represents an user. User has Role and can be added to project teams.
        UserProjectAllocation,           // User allocation to a Project
        UserStory,                       // A statement of end user requirements in a couple of sentences. User Story can be assigned to Iteration or Release.
        Workflow, 	                     // Set of states

    }
}
