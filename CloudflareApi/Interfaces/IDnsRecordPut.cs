using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MMKiwi.CloudflareDDNS.CloudflareApi.Interfaces
{
    public class IDnsRecordPut
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DnsRecord.RecordType Type { get; set; }

        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}
