// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> The filters for showing the available skus. </summary>
    public partial class AvailableSkuRequest
    {
        /// <summary> Initializes a new instance of AvailableSkuRequest. </summary>
        /// <param name="transferType"> Type of the transfer. </param>
        /// <param name="country"> ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements. </param>
        /// <param name="location"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        public AvailableSkuRequest(TransferType transferType, string country, string location)
        {
            if (country == null)
            {
                throw new ArgumentNullException(nameof(country));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            TransferType = transferType;
            Country = country;
            Location = location;
        }

        /// <summary> Initializes a new instance of AvailableSkuRequest. </summary>
        /// <param name="transferType"> Type of the transfer. </param>
        /// <param name="country"> ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements. </param>
        /// <param name="location"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="skuNames"> Sku Names to filter for available skus. </param>
        internal AvailableSkuRequest(TransferType transferType, string country, string location, IList<string> skuNames)
        {
            TransferType = transferType;
            Country = country;
            Location = location;
            SkuNames = skuNames;
        }

        /// <summary> Type of the transfer. </summary>
        public TransferType TransferType { get; }
        /// <summary> ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements. </summary>
        public string Country { get; }
        /// <summary> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </summary>
        public string Location { get; }
        /// <summary> Sku Names to filter for available skus. </summary>
        public IList<string> SkuNames { get; set; }
    }
}
