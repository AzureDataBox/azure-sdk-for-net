// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Request body to get the availability for scheduling disk orders. </summary>
    public partial class DiskScheduleAvailabilityRequest : ScheduleAvailabilityRequest
    {
        /// <summary> Initializes a new instance of DiskScheduleAvailabilityRequest. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="expectedDataSizeInTerabytes"> The expected size of the data, which needs to be transferred in this job, in terabytes. </param>
        public DiskScheduleAvailabilityRequest(string storageLocation, int expectedDataSizeInTerabytes) : base(storageLocation)
        {
            if (storageLocation == null)
            {
                throw new ArgumentNullException(nameof(storageLocation));
            }

            ExpectedDataSizeInTerabytes = expectedDataSizeInTerabytes;
            SkuName = SkuName.DataBoxDisk;
        }

        /// <summary> Initializes a new instance of DiskScheduleAvailabilityRequest. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="skuName"> Sku Name for which the order is to be scheduled. </param>
        /// <param name="country"> Country in which storage location should be supported. </param>
        /// <param name="expectedDataSizeInTerabytes"> The expected size of the data, which needs to be transferred in this job, in terabytes. </param>
        internal DiskScheduleAvailabilityRequest(string storageLocation, SkuName skuName, string country, int expectedDataSizeInTerabytes) : base(storageLocation, skuName, country)
        {
            ExpectedDataSizeInTerabytes = expectedDataSizeInTerabytes;
            SkuName = skuName;
        }

        /// <summary> The expected size of the data, which needs to be transferred in this job, in terabytes. </summary>
        public int ExpectedDataSizeInTerabytes { get; }
    }
}
