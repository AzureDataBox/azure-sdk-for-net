// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Copy log details for a storage account of a DataBox job. </summary>
    public partial class DataBoxAccountCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of DataBoxAccountCopyLogDetails. </summary>
        public DataBoxAccountCopyLogDetails()
        {
            CopyLogDetailsType = "DataBox";
        }

        /// <summary> Initializes a new instance of DataBoxAccountCopyLogDetails. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="copyLogLink"> Link for copy logs. </param>
        /// <param name="copyVerboseLogLink"> Link for copy verbose logs. This will be set only when LogCollectionLevel is set to Verbose. </param>
        internal DataBoxAccountCopyLogDetails(string copyLogDetailsType, string accountName, string copyLogLink, string copyVerboseLogLink) : base(copyLogDetailsType)
        {
            AccountName = accountName;
            CopyLogLink = copyLogLink;
            CopyVerboseLogLink = copyVerboseLogLink;
            CopyLogDetailsType = copyLogDetailsType ?? "DataBox";
        }

        /// <summary> Account name. </summary>
        public string AccountName { get; }
        /// <summary> Link for copy logs. </summary>
        public string CopyLogLink { get; }
        /// <summary> Link for copy verbose logs. This will be set only when LogCollectionLevel is set to Verbose. </summary>
        public string CopyVerboseLogLink { get; }
    }
}
