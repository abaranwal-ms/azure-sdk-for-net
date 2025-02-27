// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The configuration for compute nodes in a pool based on the Azure Virtual Machines infrastructure. </summary>
    public partial class BatchVmConfiguration
    {
        /// <summary> Initializes a new instance of BatchVmConfiguration. </summary>
        /// <param name="imageReference"> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </param>
        /// <param name="nodeAgentSkuId"> The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageReference"/> or <paramref name="nodeAgentSkuId"/> is null. </exception>
        public BatchVmConfiguration(BatchImageReference imageReference, string nodeAgentSkuId)
        {
            Argument.AssertNotNull(imageReference, nameof(imageReference));
            Argument.AssertNotNull(nodeAgentSkuId, nameof(nodeAgentSkuId));

            ImageReference = imageReference;
            NodeAgentSkuId = nodeAgentSkuId;
            DataDisks = new ChangeTrackingList<BatchVmDataDisk>();
            Extensions = new ChangeTrackingList<BatchVmExtension>();
        }

        /// <summary> Initializes a new instance of BatchVmConfiguration. </summary>
        /// <param name="imageReference"> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </param>
        /// <param name="nodeAgentSkuId"> The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. </param>
        /// <param name="windowsConfiguration"> This property must not be specified if the imageReference specifies a Linux OS image. </param>
        /// <param name="dataDisks"> This property must be specified if the compute nodes in the pool need to have empty data disks attached to them. </param>
        /// <param name="licenseType">
        /// This only applies to images that contain the Windows operating system, and should only be used when you hold valid on-premises licenses for the nodes which will be deployed. If omitted, no on-premises licensing discount is applied. Values are:
        ///
        ///  Windows_Server - The on-premises license is for Windows Server.
        ///  Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </param>
        /// <param name="containerConfiguration"> If specified, setup is performed on each node in the pool to allow tasks to run in containers. All regular tasks and job manager tasks run on this pool must specify the containerSettings property, and all other tasks may specify it. </param>
        /// <param name="diskEncryptionConfiguration"> If specified, encryption is performed on each node in the pool during node provisioning. </param>
        /// <param name="nodePlacementConfiguration"> This configuration will specify rules on how nodes in the pool will be physically allocated. </param>
        /// <param name="extensions"> If specified, the extensions mentioned in this configuration will be installed on each node. </param>
        /// <param name="osDisk"> Contains configuration for ephemeral OSDisk settings. </param>
        internal BatchVmConfiguration(BatchImageReference imageReference, string nodeAgentSkuId, WindowsConfiguration windowsConfiguration, IList<BatchVmDataDisk> dataDisks, string licenseType, BatchVmContainerConfiguration containerConfiguration, DiskEncryptionConfiguration diskEncryptionConfiguration, NodePlacementConfiguration nodePlacementConfiguration, IList<BatchVmExtension> extensions, OSDisk osDisk)
        {
            ImageReference = imageReference;
            NodeAgentSkuId = nodeAgentSkuId;
            WindowsConfiguration = windowsConfiguration;
            DataDisks = dataDisks;
            LicenseType = licenseType;
            ContainerConfiguration = containerConfiguration;
            DiskEncryptionConfiguration = diskEncryptionConfiguration;
            NodePlacementConfiguration = nodePlacementConfiguration;
            Extensions = extensions;
            OSDisk = osDisk;
        }

        /// <summary> A reference to an Azure Virtual Machines Marketplace image or the Azure Image resource of a custom Virtual Machine. To get the list of all imageReferences verified by Azure Batch, see the 'List supported node agent SKUs' operation. </summary>
        public BatchImageReference ImageReference { get; set; }
        /// <summary> The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface between the node and the Batch service. There are different implementations of the node agent, known as SKUs, for different operating systems. You must specify a node agent SKU which matches the selected image reference. To get the list of supported node agent SKUs along with their list of verified image references, see the 'List supported node agent SKUs' operation. </summary>
        public string NodeAgentSkuId { get; set; }
        /// <summary> This property must not be specified if the imageReference specifies a Linux OS image. </summary>
        internal WindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary> If omitted, the default value is true. </summary>
        public bool? IsAutomaticUpdateEnabled
        {
            get => WindowsConfiguration is null ? default : WindowsConfiguration.IsAutomaticUpdateEnabled;
            set
            {
                if (WindowsConfiguration is null)
                    WindowsConfiguration = new WindowsConfiguration();
                WindowsConfiguration.IsAutomaticUpdateEnabled = value;
            }
        }

        /// <summary> This property must be specified if the compute nodes in the pool need to have empty data disks attached to them. </summary>
        public IList<BatchVmDataDisk> DataDisks { get; }
        /// <summary>
        /// This only applies to images that contain the Windows operating system, and should only be used when you hold valid on-premises licenses for the nodes which will be deployed. If omitted, no on-premises licensing discount is applied. Values are:
        ///
        ///  Windows_Server - The on-premises license is for Windows Server.
        ///  Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </summary>
        public string LicenseType { get; set; }
        /// <summary> If specified, setup is performed on each node in the pool to allow tasks to run in containers. All regular tasks and job manager tasks run on this pool must specify the containerSettings property, and all other tasks may specify it. </summary>
        public BatchVmContainerConfiguration ContainerConfiguration { get; set; }
        /// <summary> If specified, encryption is performed on each node in the pool during node provisioning. </summary>
        internal DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }
        /// <summary> On Linux pool, only "TemporaryDisk" is supported; on Windows pool, "OsDisk" and "TemporaryDisk" must be specified. </summary>
        public IList<BatchDiskEncryptionTarget> DiskEncryptionTargets
        {
            get
            {
                if (DiskEncryptionConfiguration is null)
                    DiskEncryptionConfiguration = new DiskEncryptionConfiguration();
                return DiskEncryptionConfiguration.Targets;
            }
        }

        /// <summary> This configuration will specify rules on how nodes in the pool will be physically allocated. </summary>
        internal NodePlacementConfiguration NodePlacementConfiguration { get; set; }
        /// <summary> Allocation policy used by Batch Service to provision the nodes. If not specified, Batch will use the regional policy. </summary>
        public BatchNodePlacementPolicyType? NodePlacementPolicy
        {
            get => NodePlacementConfiguration is null ? default : NodePlacementConfiguration.Policy;
            set
            {
                if (NodePlacementConfiguration is null)
                    NodePlacementConfiguration = new NodePlacementConfiguration();
                NodePlacementConfiguration.Policy = value;
            }
        }

        /// <summary> If specified, the extensions mentioned in this configuration will be installed on each node. </summary>
        public IList<BatchVmExtension> Extensions { get; }
        /// <summary> Contains configuration for ephemeral OSDisk settings. </summary>
        internal OSDisk OSDisk { get; set; }
        /// <summary> This property can be used by user in the request to choose which location the operating system should be in. e.g., cache disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer to Ephemeral OS disk size requirements for Windows VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. </summary>
        public BatchDiffDiskPlacement? EphemeralOSDiskPlacement
        {
            get => OSDisk is null ? default : OSDisk.EphemeralOSDiskPlacement;
            set
            {
                if (OSDisk is null)
                    OSDisk = new OSDisk();
                OSDisk.EphemeralOSDiskPlacement = value;
            }
        }
    }
}
