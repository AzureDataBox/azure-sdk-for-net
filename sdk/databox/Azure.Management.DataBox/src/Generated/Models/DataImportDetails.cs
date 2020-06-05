// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Details of the data to be used for importing data to azure. </summary>
    public partial class DataImportDetails
    {
        /// <summary> Initializes a new instance of DataImportDetails. </summary>
        /// <param name="accountDetails"> Account details of the data to be transferred. </param>
        public DataImportDetails(DataAccountDetails accountDetails)
        {
            if (accountDetails == null)
            {
                throw new ArgumentNullException(nameof(accountDetails));
            }

            AccountDetails = accountDetails;
        }

        /// <summary> Account details of the data to be transferred. </summary>
        public DataAccountDetails AccountDetails { get; set; }
    }
}
