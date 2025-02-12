// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtLRO.Models
{
    public partial class FakePostResult
    {
        internal static FakePostResult DeserializeFakePostResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FakePostResultProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = FakePostResultProperties.DeserializeFakePostResultProperties(property.Value);
                    continue;
                }
            }
            return new FakePostResult(properties.Value);
        }
    }
}
