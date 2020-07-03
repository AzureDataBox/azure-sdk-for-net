// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Map of data location to service location. </summary>
    public partial class DataLocationToServiceLocationMap
    {
        /// <summary> Initializes a new instance of DataLocationToServiceLocationMap. </summary>
        internal DataLocationToServiceLocationMap()
        {
        }

        /// <summary> Initializes a new instance of DataLocationToServiceLocationMap. </summary>
        /// <param name="dataLocation"> Location of the data. </param>
        /// <param name="serviceLocation"> Location of the service. </param>
        internal DataLocationToServiceLocationMap(string dataLocation, string serviceLocation)
        {
            DataLocation = dataLocation;
            ServiceLocation = serviceLocation;
        }

        /// <summary> Location of the data. </summary>
        public string DataLocation { get; }
        /// <summary> Location of the service. </summary>
        public string ServiceLocation { get; }
    }
}
