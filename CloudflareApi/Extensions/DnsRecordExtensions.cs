using MMKiwi.CloudflareDDNS.CloudflareApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace MMKiwi.CloudflareDDNS.CloudflareApi.Extensions
{
    public static class DnsRecordExtensions
    {
        public static Response<dynamic> PushUpdates(this DnsRecord dnsRecord, ApiBase api, )
        {
            IDnsRecordPut content = dnsRecord;
            return api.SendRequest<dynamic>("zones", HttpMethod.Put, JsonSerializer.Serialize<IDnsRecordPut>(content));
        }
    }
}
