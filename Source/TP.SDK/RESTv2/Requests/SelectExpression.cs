using System;
using System.Linq;
using System.Reflection;
using TP.SDK.RESTv2.Models;

namespace TP.SDK.RESTv2
{
    public class SelectExpression : ISelectExpression
    {
        public string Expression { get; set; }

        private SelectExpression(string expression)
        {
            Expression = expression;
        }


        public static SelectExpression SelectExpressionAllUserStoryFields
        {
            get
            {
                var props = typeof(UserStory).GetProperties(BindingFlags.DeclaredOnly |
                           BindingFlags.Public |
                           BindingFlags.Instance).Select(p => p.Name);

                var expression = String.Join(",", props);
                expression = "{" + expression + "}";

                return new SelectExpression(expression);

                //return new SelectExpression("{Id,Name,Description,StartDate,EndDate,CreateDate,ModifyDate,LastCommentDate,Tags,NumericPriority,"+
                //    "IsNow,IsNext,IsPrevious,Effort,EffortCompleted,EffortToDo,Progress,TimeSpent,TimeRemain,LastStateChangeDate,PlannedStartDate,PlannedEndDate,"+
                //    "Units,LeadTime,CycleTime,ForecastEndDate,InitialEstimate,EntityType,Owner,Comments,CustomValues}");
            }
        }

        public override string ToString()
        {
            return Expression;
        }
    }
}
