// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class PatternCaptureTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("patterns");
            writer.WriteStartArray();
            foreach (var item in Patterns)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (PreserveOriginal != null)
            {
                writer.WritePropertyName("preserveOriginal");
                writer.WriteBooleanValue(PreserveOriginal.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static PatternCaptureTokenFilter DeserializePatternCaptureTokenFilter(JsonElement element)
        {
            PatternCaptureTokenFilter result = new PatternCaptureTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patterns"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Patterns.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("preserveOriginal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PreserveOriginal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
