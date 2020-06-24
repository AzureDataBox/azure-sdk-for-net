// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class StopwordsTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Stopwords != null && Stopwords.Any())
            {
                writer.WritePropertyName("stopwords");
                writer.WriteStartArray();
                foreach (var item in Stopwords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (StopwordsList != null)
            {
                writer.WritePropertyName("stopwordsList");
                writer.WriteStringValue(StopwordsList.Value.ToSerialString());
            }
            if (IgnoreCase != null)
            {
                writer.WritePropertyName("ignoreCase");
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (RemoveTrailingStopWords != null)
            {
                writer.WritePropertyName("removeTrailing");
                writer.WriteBooleanValue(RemoveTrailingStopWords.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static StopwordsTokenFilter DeserializeStopwordsTokenFilter(JsonElement element)
        {
            IList<string> stopwords = default;
            StopwordsList? stopwordsList = default;
            bool? ignoreCase = default;
            bool? removeTrailing = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopwords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    stopwords = array;
                    continue;
                }
                if (property.NameEquals("stopwordsList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopwordsList = property.Value.GetString().ToStopwordsList();
                    continue;
                }
                if (property.NameEquals("ignoreCase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("removeTrailing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    removeTrailing = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new StopwordsTokenFilter(odataType, name, stopwords, stopwordsList, ignoreCase, removeTrailing);
        }
    }
}
