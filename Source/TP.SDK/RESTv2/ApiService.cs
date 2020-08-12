using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.SDK.RESTv2.Models;
using TP.SDK.RESTv2.Requests;

namespace TP.SDK.RESTv2
{
    public class ApiService
    {
        private string _baseUrl;
        private string _authToken;

        public ApiService(string baseUrl, string authToken)
        {
            _baseUrl = baseUrl;
            _authToken = authToken;
        }

        public CollectionPaged<T> GetAll<T>()
        {
            var executor = new ApiRequestExecutor(_baseUrl, _authToken);
            var request = new ApiRequest(typeof(T).Name, new FilterExpression(), new SelectAllFieldsExpression<T>(), 0, 10, new OrderByExpression());
            var response = executor.Execute<CollectionPaged<T>>(request);

            return response;
        }

        public List<int> GetAllIds<T>()
        {
            var res = new List<int>();

            var pageResult = GetIds<T>();
            while (pageResult.Items.Count > 0)
            {
                // process page
                res.AddRange(pageResult.Items);

                if (pageResult.Next == null)
                    break;

                // load next page
                pageResult = GetNextPage(pageResult);
            }

            res.Sort();
            return res;
        }

        private CollectionPaged<int> GetIds<T>()
        {
            var executor = new ApiRequestExecutor(_baseUrl, _authToken);
            var request = new ApiRequest(typeof(T).Name, new FilterExpression(), new SelectIdExpression(), 0, 1000, new OrderByExpression());
            var response = executor.Execute<CollectionPaged<int>>(request);

            return response;
        }

        public T GetById<T>(int id)
        {
            var filter = new FilterExpression();
            filter.Filters.Add($"id={id}");

            var executor = new ApiRequestExecutor(_baseUrl, _authToken);
            var request = new ApiRequest(typeof(T).Name, filter, new SelectAllFieldsExpression<T>(), 0, 10, new OrderByExpression());
            var response = executor.Execute<CollectionPaged<T>>(request);

            if (response.Items.Any())
            {
                return response.Items[0];
            }

            return default(T);
        }

        public CollectionPaged<T> GetNextPage<T>(CollectionPaged<T> pagedCollection)
        {
            var executor = new ApiRequestExecutor(_baseUrl, _authToken);
            var request = new ApiRequestNextPage(pagedCollection.Next);
            var response = executor.Execute<CollectionPaged<T>>(request);

            return response;
        }

        public byte[] GetAttachment(int id) 
        {
            var executor = new ApiRequestExecutor(_baseUrl, _authToken);
            var request = new AttachmentRequest(id);
            return executor.Execute<byte[]>(request);
        }
    }
}
