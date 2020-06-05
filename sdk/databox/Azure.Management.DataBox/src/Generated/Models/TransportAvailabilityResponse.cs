// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Transport options available for given sku in a region. </summary>
    public partial class TransportAvailabilityResponse
    {
        /// <summary> Initializes a new instance of TransportAvailabilityResponse. </summary>
        internal TransportAvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of TransportAvailabilityResponse. </summary>
        /// <param name="transportAvailabilityDetails"> List of transport availability details for given region. </param>
        internal TransportAvailabilityResponse(IReadOnlyList<TransportAvailabilityDetails> transportAvailabilityDetails)
        {
            TransportAvailabilityDetails = transportAvailabilityDetails;
        }

        /// <summary> List of transport availability details for given region. </summary>
        public IReadOnlyList<TransportAvailabilityDetails> TransportAvailabilityDetails { get; }
    }
}
