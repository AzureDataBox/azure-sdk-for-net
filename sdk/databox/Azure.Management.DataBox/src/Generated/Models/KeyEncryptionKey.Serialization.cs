// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class KeyEncryptionKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kekType");
            writer.WriteStringValue(KekType.ToSerialString());
            if (KekUrl != null)
            {
                writer.WritePropertyName("kekUrl");
                writer.WriteStringValue(KekUrl);
            }
            if (KekVaultResourceID != null)
            {
                writer.WritePropertyName("kekVaultResourceID");
                writer.WriteStringValue(KekVaultResourceID);
            }
            writer.WriteEndObject();
        }

        internal static KeyEncryptionKey DeserializeKeyEncryptionKey(JsonElement element)
        {
            KekType kekType = default;
            string kekUrl = default;
            string kekVaultResourceID = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kekType"))
                {
                    kekType = property.Value.GetString().ToKekType();
                    continue;
                }
                if (property.NameEquals("kekUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kekVaultResourceID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekVaultResourceID = property.Value.GetString();
                    continue;
                }
            }
            return new KeyEncryptionKey(kekType, kekUrl, kekVaultResourceID);
        }
    }
}
