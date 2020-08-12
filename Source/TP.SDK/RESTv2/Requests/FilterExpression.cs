using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TP.SDK.RESTv2
{
    public class FilterExpression
    {
        //"/api/v2/UserStory?where=&select={id,name,endDate:(endDate-StartDAte).TotalDays}&take=25&skip=25&type=UserStory",
        public FilterExpression()
        {
            Filters = new List<string>();
        }

        public List<string> Filters;

        public override string ToString()
        {
            // [0]      id = 123  and dateUpdate > today()

            if (Filters.Count == 0)
                return String.Empty;

            var res = "(" + String.Join(" and ", Filters) + ")";
            res = HttpUtility.UrlEncode(res);

            return res;
        }
    }
}
