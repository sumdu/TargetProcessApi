using System.Configuration;

namespace TpMigration.Model
{
    public class AppSettings
    {
        public static string TpBaseUrl { get { return ConfigurationManager.AppSettings["TpBaseUrl"]; } }
        public static string TpAuthToken { get { return ConfigurationManager.AppSettings["TpAuthToken"]; } }
        public static string TpAuthCookie { get { return ConfigurationManager.AppSettings["TpAuthCookie"]; } }
    }
}
