// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Copy log details for a storage account for Databox heavy. </summary>
    public partial class DataBoxHeavyAccountCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of DataBoxHeavyAccountCopyLogDetails. </summary>
        public DataBoxHeavyAccountCopyLogDetails()
        {
            CopyLogDetailsType = ClassDiscriminator.DataBoxHeavy;
        }

        /// <summary> Initializes a new instance of DataBoxHeavyAccountCopyLogDetails. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="copyLogLink"> Link for copy logs. </param>
        /// <param name="copyVerboseLogLink"> Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose. </param>
        internal DataBoxHeavyAccountCopyLogDetails(ClassDiscriminator copyLogDetailsType, string accountName, IList<string> copyLogLink, IList<string> copyVerboseLogLink) : base(copyLogDetailsType)
        {
            AccountName = accountName;
            CopyLogLink = copyLogLink;
            CopyVerboseLogLink = copyVerboseLogLink;
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Account name. </summary>
        public string AccountName { get; }
        /// <summary> Link for copy logs. </summary>
        public IList<string> CopyLogLink { get; }
        /// <summary> Link for copy verbose logs. This will be set only when the LogCollectionLevel is set to verbose. </summary>
        public IList<string> CopyVerboseLogLink { get; }
    }
}
