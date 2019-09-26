using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MMKiwi.CloudflareDDNS.CloudflareApi
{
    public class Response<TRes>
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<string>? Errors { get; set; }
        [JsonPropertyName("messages")]
        public IEnumerable<string>? Messages { get; set; }
        [JsonPropertyName("result")]
        public IEnumerable<TRes>? Result { get; set; }
        [JsonPropertyName("result_info")]
        public dynamic? ResultInfo { get; set; }
    }
}
