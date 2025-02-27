// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DeploymentManager
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ServiceTopologyResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ServiceTopologyResources and their operations over a ServiceTopologyResource. </returns>
        public virtual ServiceTopologyResourceCollection GetServiceTopologyResources()
        {
            return GetCachedClient(Client => new ServiceTopologyResourceCollection(Client, Id));
        }

        /// <summary> Gets a collection of StepResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StepResources and their operations over a StepResource. </returns>
        public virtual StepResourceCollection GetStepResources()
        {
            return GetCachedClient(Client => new StepResourceCollection(Client, Id));
        }

        /// <summary> Gets a collection of RolloutResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of RolloutResources and their operations over a RolloutResource. </returns>
        public virtual RolloutCollection GetRollouts()
        {
            return GetCachedClient(Client => new RolloutCollection(Client, Id));
        }

        /// <summary> Gets a collection of ArtifactSourceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArtifactSourceResources and their operations over a ArtifactSourceResource. </returns>
        public virtual ArtifactSourceCollection GetArtifactSources()
        {
            return GetCachedClient(Client => new ArtifactSourceCollection(Client, Id));
        }
    }
}
