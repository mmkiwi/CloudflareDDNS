/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MMKiwi.CloudflareDDNS.CloudflareApi;
using MMKiwi.CloudflareDDNS.CloudflareApi.Extensions;

namespace MMKiwi.CloudflareDDNS.Program
{
    public class Program
    {
        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddCommandLine(args);

            IConfigurationRoot configuration = builder.Build();

            var a = new ApiBase(configuration);
            var z = a.Zones;

            foreach (var i in z)
            {
                if(i.Name == "mmkiwi.com")
                {
                    var rec = i.GetDnsRecords(a);
                }
            }
        }
    }
}
