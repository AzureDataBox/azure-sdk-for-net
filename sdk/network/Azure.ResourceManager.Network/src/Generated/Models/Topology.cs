// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Topology of the specified resource group. </summary>
    public partial class Topology
    {
        /// <summary> Initializes a new instance of Topology. </summary>
        internal Topology()
        {
        }

        /// <summary> Initializes a new instance of Topology. </summary>
        /// <param name="id"> GUID representing the operation id. </param>
        /// <param name="createdDateTime"> The datetime when the topology was initially created for the resource group. </param>
        /// <param name="lastModified"> The datetime when the topology was last modified. </param>
        /// <param name="resources"> A list of topology resources. </param>
        internal Topology(string id, DateTimeOffset? createdDateTime, DateTimeOffset? lastModified, IReadOnlyList<TopologyResource> resources)
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastModified = lastModified;
            Resources = resources;
        }

        /// <summary> GUID representing the operation id. </summary>
        public string Id { get; }
        /// <summary> The datetime when the topology was initially created for the resource group. </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> The datetime when the topology was last modified. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> A list of topology resources. </summary>
        public IReadOnlyList<TopologyResource> Resources { get; }
    }
}
