// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    internal class WorkloadNetworkDnsZoneOperationSource : IOperationSource<WorkloadNetworkDnsZoneResource>
    {
        private readonly ArmClient _client;

        internal WorkloadNetworkDnsZoneOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkloadNetworkDnsZoneResource IOperationSource<WorkloadNetworkDnsZoneResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WorkloadNetworkDnsZoneData.DeserializeWorkloadNetworkDnsZoneData(document.RootElement);
            return new WorkloadNetworkDnsZoneResource(_client, data);
        }

        async ValueTask<WorkloadNetworkDnsZoneResource> IOperationSource<WorkloadNetworkDnsZoneResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WorkloadNetworkDnsZoneData.DeserializeWorkloadNetworkDnsZoneData(document.RootElement);
            return new WorkloadNetworkDnsZoneResource(_client, data);
        }
    }
}
