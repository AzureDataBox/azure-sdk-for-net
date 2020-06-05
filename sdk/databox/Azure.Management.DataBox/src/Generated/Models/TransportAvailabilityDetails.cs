// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Transport options availability details for given region. </summary>
    public partial class TransportAvailabilityDetails
    {
        /// <summary> Initializes a new instance of TransportAvailabilityDetails. </summary>
        internal TransportAvailabilityDetails()
        {
        }

        /// <summary> Initializes a new instance of TransportAvailabilityDetails. </summary>
        /// <param name="shipmentType"> Transport Shipment Type supported for given region. </param>
        internal TransportAvailabilityDetails(TransportShipmentTypes? shipmentType)
        {
            ShipmentType = shipmentType;
        }

        /// <summary> Transport Shipment Type supported for given region. </summary>
        public TransportShipmentTypes? ShipmentType { get; }
    }
}
