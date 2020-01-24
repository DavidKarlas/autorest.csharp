// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class IndexerExecutionResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage");
                writer.WriteStringValue(ErrorMessage);
            }
            if (StartTime != null)
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime.Value, "S");
            }
            if (EndTime != null)
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime.Value, "S");
            }
            if (Errors != null)
            {
                writer.WritePropertyName("errors");
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Warnings != null)
            {
                writer.WritePropertyName("warnings");
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ItemCount != null)
            {
                writer.WritePropertyName("itemsProcessed");
                writer.WriteNumberValue(ItemCount.Value);
            }
            if (FailedItemCount != null)
            {
                writer.WritePropertyName("itemsFailed");
                writer.WriteNumberValue(FailedItemCount.Value);
            }
            if (InitialTrackingState != null)
            {
                writer.WritePropertyName("initialTrackingState");
                writer.WriteStringValue(InitialTrackingState);
            }
            if (FinalTrackingState != null)
            {
                writer.WritePropertyName("finalTrackingState");
                writer.WriteStringValue(FinalTrackingState);
            }
            writer.WriteEndObject();
        }
        internal static IndexerExecutionResult DeserializeIndexerExecutionResult(JsonElement element)
        {
            IndexerExecutionResult result = new IndexerExecutionResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Status = property.Value.GetString().ToIndexerExecutionStatus();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StartTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.EndTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Errors = new List<ItemError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Errors.Add(ItemError.DeserializeItemError(item));
                    }
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Warnings = new List<ItemWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Warnings.Add(ItemWarning.DeserializeItemWarning(item));
                    }
                    continue;
                }
                if (property.NameEquals("itemsProcessed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("itemsFailed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FailedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialTrackingState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InitialTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("finalTrackingState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FinalTrackingState = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
