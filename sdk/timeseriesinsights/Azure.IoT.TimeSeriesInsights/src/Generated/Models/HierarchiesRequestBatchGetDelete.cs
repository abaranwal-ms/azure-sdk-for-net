// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to get or delete multiple time series hierarchies. Exactly one of "hierarchyIds" or "names" must be set. </summary>
    internal partial class HierarchiesRequestBatchGetDelete
    {
        /// <summary> Initializes a new instance of HierarchiesRequestBatchGetDelete. </summary>
        public HierarchiesRequestBatchGetDelete()
        {
            HierarchyIds = new ChangeTrackingList<string>();
            Names = new ChangeTrackingList<string>();
        }

        /// <summary> List of hierarchy IDs. </summary>
        public IList<string> HierarchyIds { get; }
        /// <summary> List of hierarchy names. </summary>
        public IList<string> Names { get; }
    }
}
