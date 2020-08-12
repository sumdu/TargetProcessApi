using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP.SDK.RESTv2.Models
{
    public class CollectionPaged<T> : Collection<T>
    {
        [JsonPropertyName("next")]
        public string Next { get; set; }
    }
}
