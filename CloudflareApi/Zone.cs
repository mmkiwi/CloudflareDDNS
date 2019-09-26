using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MMKiwi.CloudflareDDNS.CloudflareApi
{
    public class Zone
    {
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("development_mode")]
        public int DevelopmentMode { get; set; }

        [JsonPropertyName("original_name_servers")]
        public string[]? OriginalNameServers { get; set; }

        [JsonPropertyName("original_registrar")]
        public string? OriginalRegistrar { get; set; }

        [JsonPropertyName("original_dnshost")]
        public string? OriginalDnsHost { get; set; }

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [JsonPropertyName("activated_on")]
        public DateTime ActivatedOn { get; set; }

        [JsonPropertyName("owner")]
        public dynamic? Owner { get; set; }

        [JsonPropertyName("account")]
        public Account? Account { get; set; }

        //[JsonPropertyName("permissions")]
        //public dynamic? Permissions { get; set; }

        [JsonPropertyName("plan")]
        public dynamic? Plan { get; set; }

        [JsonPropertyName("plan_pending")]
        public dynamic? PlanPending { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("name_servers")]
        public IEnumerable<string>? NameServers { get; set; }
    }
}
