using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace TP.SDK.RESTv2.Models
{
    public class SsoSettings
    {
        // Values

        public bool IsEnabled { get; set; }
        public string SignonUrl { get; set; }
        public string Certificate { get; set; }
        public string RelayStateQueryStringParameterName { get; set; }
        public bool IsUserProvisioningEnabled { get; set; }
        public bool IsFormAuthenticationDisabled { get; set; }

        // Resource collections

        public Collection<User> ExceptionUsers { get; set; }
    }
}
