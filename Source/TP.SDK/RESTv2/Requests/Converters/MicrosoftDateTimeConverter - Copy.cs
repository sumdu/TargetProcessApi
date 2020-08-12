using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TP.SDK.RESTv2.Requests.Converters
{
    public class MicrosoftDateTimeConverter2 : JsonConverter<object>
    {
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var val = reader.GetString();
            if (val != null && val.ToString().Contains("Date("))
            {
                return GetUserDateTimeFromJSON(val);
            }
            else
            {
                return val;
            }
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            if (value is DateTime)
            {
                writer.WriteStringValue(GetJSONFromUserDateTime((DateTime)value));
            }
            else
            {
                writer.WriteStringValue(value.ToString());
            }
            
        }

        /// <summary>
        /// Convert UserDateTime({9/7/2018 8:37:20 AM}) to JSON datetime(1536309440373) format
        /// </summary>
        /// <param name="givenDateTime"></param>
        /// <returns></returns>
        private string GetJSONFromUserDateTime(DateTime givenDateTime)
        {
            string jsonDateTime = string.Empty;
            if (givenDateTime != null)
            {
                Newtonsoft.Json.JsonSerializerSettings microsoftDateFormatSettings = new Newtonsoft.Json.JsonSerializerSettings
                {
                    DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat
                };
                jsonDateTime = Newtonsoft.Json.JsonConvert.SerializeObject(givenDateTime, microsoftDateFormatSettings);
                jsonDateTime = jsonDateTime.Replace("\"\\/Date(", "").Replace(")\\/\"", "");
            }
            return jsonDateTime;
        }

        /// <summary>
        /// Convert JSON datetime(1536309440373) to user datetime({9/7/2018 8:37:20 AM})
        /// </summary>
        /// <param name="jsonDateTime"></param>
        /// <returns></returns>
        private dynamic GetUserDateTimeFromJSON(string jsonDateTime)
        {
            dynamic userDateTime = null;
            if (!string.IsNullOrEmpty(jsonDateTime))
            {
                Newtonsoft.Json.JsonSerializerSettings microsoftDateFormatSettings = new Newtonsoft.Json.JsonSerializerSettings
                {
                    DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat
                };
                userDateTime = Newtonsoft.Json.JsonConvert.DeserializeObject("\"" + jsonDateTime + "\"", microsoftDateFormatSettings);
            }
            return userDateTime;
        }
    }
}
