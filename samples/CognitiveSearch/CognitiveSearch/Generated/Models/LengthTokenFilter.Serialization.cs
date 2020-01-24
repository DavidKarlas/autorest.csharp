// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class LengthTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Min != null)
            {
                writer.WritePropertyName("min");
                writer.WriteNumberValue(Min.Value);
            }
            if (Max != null)
            {
                writer.WritePropertyName("max");
                writer.WriteNumberValue(Max.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static LengthTokenFilter DeserializeLengthTokenFilter(JsonElement element)
        {
            LengthTokenFilter result = new LengthTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("min"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Min = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("max"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Max = property.Value.GetInt32();
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
