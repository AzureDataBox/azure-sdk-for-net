// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class TransferConfigurationTransferAllDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Include != null)
            {
                writer.WritePropertyName("include");
                writer.WriteObjectValue(Include);
            }
            writer.WriteEndObject();
        }

        internal static TransferConfigurationTransferAllDetails DeserializeTransferConfigurationTransferAllDetails(JsonElement element)
        {
            TransferAllDetails include = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    include = TransferAllDetails.DeserializeTransferAllDetails(property.Value);
                    continue;
                }
            }
            return new TransferConfigurationTransferAllDetails(include);
        }
    }
}
