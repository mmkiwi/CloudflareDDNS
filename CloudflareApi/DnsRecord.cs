using MMKiwi.CloudflareDDNS.CloudflareApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MMKiwi.CloudflareDDNS.CloudflareApi
{
    public class DnsRecord : IDnsRecordPut
    {
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("meta")]
        public dynamic? Metadata { get; set; }

        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("ttl")]
        public int? TTL { get; set; }

        [JsonPropertyName("zone_id")]
        public string? ZoneId { get; set; }

        [JsonPropertyName("modified_on")]
        public DateTime? ModifiedOn { get; set; }

        [JsonPropertyName("created_on")]
        public DateTime? CreatedOn { get; set; }

        [JsonPropertyName("proxiable")]
        public bool? Proxiable { get; set; }

        [JsonPropertyName("content")]
        public string? Content { get; set; }

        [JsonPropertyName("proxied")]
        public bool? Proxied { get; set; }

        [JsonPropertyName("zone_name")]
        public string? ZoneName { get; set; }

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RecordType Type { get; set; }

        public enum RecordType { A, AAAA, CNAME, TXT, SRV, LOC, MX, NS, SPF, CERT, DNSKEY, DS, NAPTR, SMIMEA, SSHFP, TLSA, URI }

        [Flags]
        public enum OptionalParameters { TTL = 1, Proxied = 2 }
    }
}
