// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> DataBox Disk Job Details. </summary>
    public partial class DataBoxDiskJobDetails : JobDetails
    {
        /// <summary> Initializes a new instance of DataBoxDiskJobDetails. </summary>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        public DataBoxDiskJobDetails(ContactDetails contactDetails) : base(contactDetails)
        {
            if (contactDetails == null)
            {
                throw new ArgumentNullException(nameof(contactDetails));
            }

            JobDetailsType = ClassDiscriminator.DataBoxDisk;
        }

        /// <summary> Initializes a new instance of DataBoxDiskJobDetails. </summary>
        /// <param name="jobStages"> List of stages that run in the job. </param>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deliveryPackage"> Delivery package shipping details. </param>
        /// <param name="returnPackage"> Return package shipping details. </param>
        /// <param name="dataImportDetails"> Details of the data to be imported into azure. </param>
        /// <param name="dataExportDetails"> Details of the data to be exported from azure. </param>
        /// <param name="jobDetailsType"> Indicates the type of job details. </param>
        /// <param name="preferences"> Preferences for the order. </param>
        /// <param name="copyLogDetails"> List of copy log details. </param>
        /// <param name="reverseShipmentLabelSasKey"> Shared access key to download the return shipment label. </param>
        /// <param name="chainOfCustodySasKey"> Shared access key to download the chain of custody logs. </param>
        /// <param name="keyEncryptionKey"> Details about which key encryption type is being used. </param>
        /// <param name="expectedDataSizeInTerabytes"> The expected size of the data, which needs to be transfered in this job, in tera bytes. </param>
        /// <param name="preferredDisks"> User preference on what size disks are needed for the job. The map is from the disk size in TB to the count. Eg. {2,5} means 5 disks of 2 TB size. Key is string but will be checked against an int. </param>
        /// <param name="copyProgress"> Copy progress per disk. </param>
        /// <param name="disksAndSizeDetails"> Contains the map of disk serial number to the disk size being used for the job. Is returned only after the disks are shipped to the customer. </param>
        /// <param name="passkey"> User entered passkey for DataBox Disk job. </param>
        internal DataBoxDiskJobDetails(IList<JobStages> jobStages, ContactDetails contactDetails, ShippingAddress shippingAddress, PackageShippingDetails deliveryPackage, PackageShippingDetails returnPackage, IList<DataImportDetails> dataImportDetails, IList<DataExportDetails> dataExportDetails, ClassDiscriminator jobDetailsType, Preferences preferences, IList<CopyLogDetails> copyLogDetails, string reverseShipmentLabelSasKey, string chainOfCustodySasKey, KeyEncryptionKey keyEncryptionKey, int? expectedDataSizeInTerabytes, IDictionary<string, int> preferredDisks, IList<DataBoxDiskCopyProgress> copyProgress, IDictionary<string, int> disksAndSizeDetails, string passkey) : base(jobStages, contactDetails, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, jobDetailsType, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, keyEncryptionKey, expectedDataSizeInTerabytes)
        {
            PreferredDisks = preferredDisks;
            CopyProgress = copyProgress;
            DisksAndSizeDetails = disksAndSizeDetails;
            Passkey = passkey;
            JobDetailsType = jobDetailsType;
        }

        /// <summary> User preference on what size disks are needed for the job. The map is from the disk size in TB to the count. Eg. {2,5} means 5 disks of 2 TB size. Key is string but will be checked against an int. </summary>
        public IDictionary<string, int> PreferredDisks { get; set; }
        /// <summary> Copy progress per disk. </summary>
        public IList<DataBoxDiskCopyProgress> CopyProgress { get; }
        /// <summary> Contains the map of disk serial number to the disk size being used for the job. Is returned only after the disks are shipped to the customer. </summary>
        public IDictionary<string, int> DisksAndSizeDetails { get; }
        /// <summary> User entered passkey for DataBox Disk job. </summary>
        public string Passkey { get; set; }
    }
}
