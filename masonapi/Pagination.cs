using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Mason.API
{
    public class Pagination<T>
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IList<T> Data { get; set; }

        [JsonProperty("prev")]
        [JsonPropertyName("prev")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        [JsonPropertyName("next")]
        public string Next { get; set; }
    }
}