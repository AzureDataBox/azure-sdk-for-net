// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class ValidationInputResponse
    {
        internal static ValidationInputResponse DeserializeValidationInputResponse(JsonElement element)
        {
            if (element.TryGetProperty("validationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ValidateAddress": return AddressValidationProperties.DeserializeAddressValidationProperties(element);
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationResponseProperties.DeserializeCreateOrderLimitForSubscriptionValidationResponseProperties(element);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationResponseProperties.DeserializeDataTransferDetailsValidationResponseProperties(element);
                    case "ValidatePreferences": return PreferencesValidationResponseProperties.DeserializePreferencesValidationResponseProperties(element);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationResponseProperties.DeserializeSkuAvailabilityValidationResponseProperties(element);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationResponseProperties.DeserializeSubscriptionIsAllowedToCreateJobValidationResponseProperties(element);
                }
            }
            string validationType = default;
            CloudError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationType"))
                {
                    validationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = CloudError.DeserializeCloudError(property.Value);
                    continue;
                }
            }
            return new ValidationInputResponse(validationType, error);
        }
    }
}
