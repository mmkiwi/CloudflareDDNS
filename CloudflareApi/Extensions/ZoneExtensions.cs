using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MMKiwi.CloudflareDDNS.CloudflareApi.Extensions
{
    public static class ZoneExtensions
    {
        public static IEnumerable<DnsRecord>? GetDnsRecords(this Zone zone, ApiBase api)
        {
            return api.SendRequest<DnsRecord>($"zones/{zone.ID}/dns_records", HttpMethod.Get).Result;
        }
    }
}
