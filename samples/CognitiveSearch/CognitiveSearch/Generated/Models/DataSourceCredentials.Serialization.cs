// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class DataSourceCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ConnectionString != null)
            {
                writer.WritePropertyName("connectionString");
                writer.WriteStringValue(ConnectionString);
            }
            writer.WriteEndObject();
        }
        internal static DataSourceCredentials DeserializeDataSourceCredentials(JsonElement element)
        {
            DataSourceCredentials result = new DataSourceCredentials();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ConnectionString = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
