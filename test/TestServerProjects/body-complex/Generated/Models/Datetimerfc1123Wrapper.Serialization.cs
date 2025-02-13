// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class Datetimerfc1123Wrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Field))
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field.Value, "R");
            }
            if (Optional.IsDefined(Now))
            {
                writer.WritePropertyName("now"u8);
                writer.WriteStringValue(Now.Value, "R");
            }
            writer.WriteEndObject();
        }

        internal static Datetimerfc1123Wrapper DeserializeDatetimerfc1123Wrapper(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> field = default;
            Optional<DateTimeOffset> now = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    field = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("now"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    now = property.Value.GetDateTimeOffset("R");
                    continue;
                }
            }
            return new Datetimerfc1123Wrapper(Optional.ToNullable(field), Optional.ToNullable(now));
        }
    }
}
