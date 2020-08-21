// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupLogProperties
    {
        internal static SyncGroupLogProperties DeserializeSyncGroupLogProperties(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<SyncGroupLogType> type = default;
            Optional<string> source = default;
            Optional<string> details = default;
            Optional<Guid> tracingId = default;
            Optional<string> operationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SyncGroupLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tracingId"))
                {
                    tracingId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("operationStatus"))
                {
                    operationStatus = property.Value.GetString();
                    continue;
                }
            }
            return new SyncGroupLogProperties(Optional.ToNullable(timestamp), Optional.ToNullable(type), source.Value, details.Value, Optional.ToNullable(tracingId), operationStatus.Value);
        }
    }
}