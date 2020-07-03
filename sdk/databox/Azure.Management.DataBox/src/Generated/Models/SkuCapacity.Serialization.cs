// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class SkuCapacity
    {
        internal static SkuCapacity DeserializeSkuCapacity(JsonElement element)
        {
            string usable = default;
            string maximum = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximum"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetString();
                    continue;
                }
            }
            return new SkuCapacity(usable, maximum);
        }
    }
}
