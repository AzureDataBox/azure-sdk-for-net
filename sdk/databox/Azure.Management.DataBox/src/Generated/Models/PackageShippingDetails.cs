// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Shipping details. </summary>
    public partial class PackageShippingDetails
    {
        /// <summary> Initializes a new instance of PackageShippingDetails. </summary>
        public PackageShippingDetails()
        {
        }

        /// <summary> Initializes a new instance of PackageShippingDetails. </summary>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="trackingId"> Tracking Id of shipment. </param>
        /// <param name="trackingUrl"> Url where shipment can be tracked. </param>
        internal PackageShippingDetails(string carrierName, string trackingId, string trackingUrl)
        {
            CarrierName = carrierName;
            TrackingId = trackingId;
            TrackingUrl = trackingUrl;
        }

        /// <summary> Name of the carrier. </summary>
        public string CarrierName { get; }
        /// <summary> Tracking Id of shipment. </summary>
        public string TrackingId { get; }
        /// <summary> Url where shipment can be tracked. </summary>
        public string TrackingUrl { get; }
    }
}
