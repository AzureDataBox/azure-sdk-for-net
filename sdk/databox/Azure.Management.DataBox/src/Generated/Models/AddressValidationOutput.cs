// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Output of the address validation api. </summary>
    public partial class AddressValidationOutput
    {
        /// <summary> Initializes a new instance of AddressValidationOutput. </summary>
        internal AddressValidationOutput()
        {
        }

        /// <summary> Initializes a new instance of AddressValidationOutput. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="validationStatus"> The address validation status. </param>
        /// <param name="alternateAddresses"> List of alternate addresses. </param>
        internal AddressValidationOutput(ValidationInputDiscriminator? validationType, CloudError error, AddressValidationStatus? validationStatus, IReadOnlyList<ShippingAddress> alternateAddresses)
        {
            ValidationType = validationType;
            Error = error;
            ValidationStatus = validationStatus;
            AlternateAddresses = alternateAddresses;
        }

        /// <summary> Identifies the type of validation response. </summary>
        internal ValidationInputDiscriminator? ValidationType { get; set; }
        /// <summary> Error code and message of validation response. </summary>
        public CloudError Error { get; }
        /// <summary> The address validation status. </summary>
        public AddressValidationStatus? ValidationStatus { get; }
        /// <summary> List of alternate addresses. </summary>
        public IReadOnlyList<ShippingAddress> AlternateAddresses { get; }
    }
}
