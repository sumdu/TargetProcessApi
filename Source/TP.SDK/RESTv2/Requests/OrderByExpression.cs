using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2
{
    public class OrderByExpression
    {
        // https://md5.tpondemand.com/api/v2/userstory?select={id,name,effort}&orderBy=effort desc,name)

        public OrderByExpression() { }

        public override string ToString()
        {
            return String.Empty;
        }
    }
}
