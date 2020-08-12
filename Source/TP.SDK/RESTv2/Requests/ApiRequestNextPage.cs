using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Requests
{
    public class ApiRequestNextPage : IRequest
    {
        private string NextUrl { get; set; }

        public ApiRequestNextPage(string nextUrl)
        {
            this.NextUrl = nextUrl;
        }

        public override string ToString()
        {
            return NextUrl;
        }
    }
}
