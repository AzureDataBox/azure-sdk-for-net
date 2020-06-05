// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Databox Heavy Device Job Details. </summary>
    public partial class DataBoxHeavyJobDetails : JobDetails
    {
        /// <summary> Initializes a new instance of DataBoxHeavyJobDetails. </summary>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        public DataBoxHeavyJobDetails(ContactDetails contactDetails) : base(contactDetails)
        {
            if (contactDetails == null)
            {
                throw new ArgumentNullException(nameof(contactDetails));
            }

            JobDetailsType = "DataBoxHeavy";
        }

        /// <summary> Initializes a new instance of DataBoxHeavyJobDetails. </summary>
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
        /// <param name="copyProgress"> Copy progress per account. </param>
        /// <param name="devicePassword"> Set Device password for unlocking Databox Heavy. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have atleast one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+. </param>
        internal DataBoxHeavyJobDetails(IList<JobStages> jobStages, ContactDetails contactDetails, ShippingAddress shippingAddress, PackageShippingDetails deliveryPackage, PackageShippingDetails returnPackage, IList<DataImportDetails> dataImportDetails, IList<DataExportDetails> dataExportDetails, string jobDetailsType, Preferences preferences, IList<CopyLogDetails> copyLogDetails, string reverseShipmentLabelSasKey, string chainOfCustodySasKey, KeyEncryptionKey keyEncryptionKey, int? expectedDataSizeInTerabytes, IList<CopyProgress> copyProgress, string devicePassword) : base(jobStages, contactDetails, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, jobDetailsType, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, keyEncryptionKey, expectedDataSizeInTerabytes)
        {
            CopyProgress = copyProgress;
            DevicePassword = devicePassword;
            JobDetailsType = jobDetailsType ?? "DataBoxHeavy";
        }

        /// <summary> Copy progress per account. </summary>
        public IList<CopyProgress> CopyProgress { get; }
        /// <summary> Set Device password for unlocking Databox Heavy. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have atleast one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+. </summary>
        public string DevicePassword { get; set; }
    }
}
