using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.SDK.RESTv2.Models;
using TP.SDK.RESTv2.Requests;

namespace TP.SDK.RESTv2
{
    public class ApiRequest : IRequest
    {
        string ResourceType { get; set; }
        FilterExpression Filter { get; set; }
        ISelectExpression Select { get; set; }
        int Skip { get; set; }
        int Take { get; set; }
        OrderByExpression Order { get; set; }

        /*
         /api/v2/{entity}/{id}?where={where}&select={select}&result={result}&take={take}&skip={skip}&orderBy={orderby}&callback={callback}&filter={filter}

            {entity} - entity type name in single case (Userstory, Bug) or plural case (Userstories, Bugs) - see here for the list of available entity types
            {id} - optional entity id. If specified, the response will contain only one item in {items} collection
            {where} - filter expression over collection of entities
            {select} - select projection.
            {result} - final expression, used for aggregations' calculation on root entity.
            {skip}, {take} - paging parameters, how many entities skip and take. If the result contains more entities, the response will have fields "next" or/and "prev" links to another pages.
            {orderBy} - orderings
            {callback} - JSONP callback
            {filter} - a DSL Filter or Simple Filter like on boards. filter and where clauses are combined with and operator.
 
         **/

        public ApiRequest(string resourceType, FilterExpression filter, ISelectExpression select, int skip, int take, OrderByExpression order)
        {
            this.ResourceType = resourceType;
            this.Filter = filter;
            this.Select = select;
            this.Skip = skip;
            this.Take = take;
            this.Order = order;
        }

        public override string ToString()
        {
            return $"/api/v2/{ResourceType}/?where={Filter}&select={Select.Expression}&take={Take}&skip={Skip}&orderBy={Order}&prettify=prettify";
        }
    }
}
