using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2
{
    public class SelectAllFieldsExpression<T> : ISelectExpression
    {
        public string Expression { get; set; }

        public SelectAllFieldsExpression()
        {
            var props = typeof(T)
                .GetProperties(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance)
                .Select(p => p.Name);

            var expression = String.Join(",", props);
            expression = "{" + expression + "}";

            Expression = expression;
        }
    }
}
