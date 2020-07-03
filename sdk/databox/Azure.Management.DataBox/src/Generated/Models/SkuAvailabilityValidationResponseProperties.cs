// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Properties of sku availability validation response. </summary>
    public partial class SkuAvailabilityValidationResponseProperties : ValidationInputResponse
    {
        /// <summary> Initializes a new instance of SkuAvailabilityValidationResponseProperties. </summary>
        internal SkuAvailabilityValidationResponseProperties()
        {
            ValidationType = ValidationInputDiscriminator.ValidateSkuAvailability;
        }

        /// <summary> Initializes a new instance of SkuAvailabilityValidationResponseProperties. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="status"> Sku availability validation status. </param>
        internal SkuAvailabilityValidationResponseProperties(ValidationInputDiscriminator validationType, CloudError error, ValidationStatus? status) : base(validationType, error)
        {
            Status = status;
            ValidationType = validationType;
        }

        /// <summary> Sku availability validation status. </summary>
        public ValidationStatus? Status { get; }
    }
}
