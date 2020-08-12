using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    public class Collection<T>
    {
        [JsonPropertyName("items")]
        public List<T> Items { get; set; }
    }
}
