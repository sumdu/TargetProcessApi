using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using TP.SDK.RESTv2.Requests.Converters;

namespace TP.SDK.RESTv2.Requests
{
    public class ApiRequestExecutor
    {
        private string _baseUrl;
        private string _authToken;

        public ApiRequestExecutor(string baseUrl, string authToken)
        {
            _baseUrl = baseUrl;
            _authToken = authToken;
        }

        public T Execute<T>(IRequest req)
        {
            HttpWebResponse response;
            try
            {
                var relativePath = req.ToString();
                var baseUrl = relativePath.ToLower().StartsWith("http") ? relativePath : _baseUrl + relativePath;
                var request = (HttpWebRequest)WebRequest.Create(baseUrl + $"&token={_authToken}&dateformat=ms");
                response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();

                var encoding = UTF8Encoding.UTF8;

                if (req is AttachmentRequest)
                {
                    //var responsestream = response.GetResponseStream();
                    using (var memoryStream = new MemoryStream())
                    {
                        responseStream.CopyTo(memoryStream);
                        return (T)Convert.ChangeType(memoryStream.ToArray(), typeof(T));
                    }

                }
                else
                {
                    using (var reader = new StreamReader(responseStream, encoding))
                    {
                        var responseText = reader.ReadToEnd();
                        var deserializeOptions = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        deserializeOptions.Converters.Add(new MicrosoftDateTimeConverter());
                        deserializeOptions.Converters.Add(new JsonStringEnumConverter());
                        var res = JsonSerializer.Deserialize<T>(responseText, deserializeOptions);

                        return res;
                    }
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;

                    if ((int)response.StatusCode == 500)
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            var result = sr.ReadToEnd();
                            throw new Exception($"API response: \r\n {result}", e);
                        }
                    }
                    else
                    {
                        throw;
                    }
                }
                else
                {
                    throw;
                }
            }
        }

    }


}
