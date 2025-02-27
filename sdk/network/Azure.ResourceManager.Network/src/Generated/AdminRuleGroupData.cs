// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the AdminRuleGroup data model.
    /// Defines the admin rule collection.
    /// </summary>
    public partial class AdminRuleGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of AdminRuleGroupData. </summary>
        public AdminRuleGroupData()
        {
            AppliesToGroups = new ChangeTrackingList<NetworkManagerSecurityGroupItem>();
        }

        /// <summary> Initializes a new instance of AdminRuleGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description of the admin rule collection. </param>
        /// <param name="appliesToGroups"> Groups for configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="resourceGuid"> Unique identifier for this resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal AdminRuleGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, IList<NetworkManagerSecurityGroupItem> appliesToGroups, NetworkProvisioningState? provisioningState, Guid? resourceGuid, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Description = description;
            AppliesToGroups = appliesToGroups;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            ETag = etag;
        }

        /// <summary> A description of the admin rule collection. </summary>
        public string Description { get; set; }
        /// <summary> Groups for configuration. </summary>
        public IList<NetworkManagerSecurityGroupItem> AppliesToGroups { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Unique identifier for this resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
