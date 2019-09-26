using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MMKiwi.CloudflareDDNS.CloudflareApi
{
    public class Account
    {
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("settings")]
        public Dictionary<string,string>? Settings { get; set; }

        [JsonPropertyName("created_on")]
        public DateTime? CreatedOn { get; set; }

    }
}
