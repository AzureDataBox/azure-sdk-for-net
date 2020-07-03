// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class UpdateJobDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ContactDetails != null)
            {
                writer.WritePropertyName("contactDetails");
                writer.WriteObjectValue(ContactDetails);
            }
            if (ShippingAddress != null)
            {
                writer.WritePropertyName("shippingAddress");
                writer.WriteObjectValue(ShippingAddress);
            }
            if (KeyEncryptionKey != null)
            {
                writer.WritePropertyName("keyEncryptionKey");
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            writer.WriteEndObject();
        }
    }
}
