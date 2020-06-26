// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> The address validation output. </summary>
    public partial class AddressValidationProperties : ValidationInputResponse
    {
        /// <summary> Initializes a new instance of AddressValidationProperties. </summary>
        internal AddressValidationProperties()
        {
            ValidationType = ValidationInputDiscriminator.ValidateAddress;
        }

        /// <summary> Initializes a new instance of AddressValidationProperties. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="validationStatus"> The address validation status. </param>
        /// <param name="alternateAddresses"> List of alternate addresses. </param>
        internal AddressValidationProperties(ValidationInputDiscriminator validationType, CloudError error, AddressValidationStatus? validationStatus, IReadOnlyList<ShippingAddress> alternateAddresses) : base(validationType, error)
        {
            ValidationStatus = validationStatus;
            AlternateAddresses = alternateAddresses;
            ValidationType = validationType;
        }

        /// <summary> The address validation status. </summary>
        public AddressValidationStatus? ValidationStatus { get; }
        /// <summary> List of alternate addresses. </summary>
        public IReadOnlyList<ShippingAddress> AlternateAddresses { get; }
    }
}
