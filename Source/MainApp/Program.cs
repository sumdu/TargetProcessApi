using TP.SDK.RESTv2;
using TP.SDK.RESTv2.Models;
using TpMigration.Model;

namespace TpMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            var tpApi = new ApiService(AppSettings.TpBaseUrl, AppSettings.TpAuthToken);

            // get basic info for user story #123
            var userStory = tpApi.GetById<UserStory>(123);

            foreach (var teamAssignment in userStory.AssignedTeams.Items)
            {
                // fetch full team info
                teamAssignment.Team = tpApi.GetById<Team>(teamAssignment.Team.Id);
            }
        }
    }
}
