using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class GlobalSettings
    {
        // Values

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public string SMTPLogin { get; set; }
        public string SMTPPassword { get; set; }
        public bool SMTPAuthentication { get; set; }
        public bool SMTPEnableSslViaStartTls { get; set; }
        public string SMTPSender { get; set; }
        public bool IsEmailNotificationsEnabled { get; set; }
        public string HelpDeskPortalPath { get; set; }
        public string AppHostAndPath { get; set; }
        public bool NotifyRequester { get; set; }
        public bool NotifyAutoCreatedRequester { get; set; }
        public bool DisableHttpAccess { get; set; }
        public string CsvExportDelimiter { get; set; }
        public bool SecureJsonp { get; set; }
        public bool Tp3Available { get; set; }
        public RichEditorTypeEnum DefaultRichEditor { get; set; }
        public bool IsDefaultFullProjectAccess { get; set; }

        // Resource references

        public SsoSettings SsoSettings { get; set; }
    }
}
