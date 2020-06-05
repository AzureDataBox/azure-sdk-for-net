// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Properties of create order limit for subscription validation response. </summary>
    public partial class CreateOrderLimitForSubscriptionValidationResponseProperties : ValidationInputResponse
    {
        /// <summary> Initializes a new instance of CreateOrderLimitForSubscriptionValidationResponseProperties. </summary>
        internal CreateOrderLimitForSubscriptionValidationResponseProperties()
        {
            ValidationType = "ValidateCreateOrderLimit";
        }

        /// <summary> Initializes a new instance of CreateOrderLimitForSubscriptionValidationResponseProperties. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="status"> Create order limit validation status. </param>
        internal CreateOrderLimitForSubscriptionValidationResponseProperties(string validationType, CloudError error, ValidationStatus? status) : base(validationType, error)
        {
            Status = status;
            ValidationType = validationType ?? "ValidateCreateOrderLimit";
        }

        /// <summary> Create order limit validation status. </summary>
        public ValidationStatus? Status { get; }
    }
}
