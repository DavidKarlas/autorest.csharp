// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    public partial class DeliveryRuleAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static DeliveryRuleAction DeserializeDeliveryRuleAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("name", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CacheExpiration": return DeliveryRuleCacheExpirationAction.DeserializeDeliveryRuleCacheExpirationAction(element);
                    case "CacheKeyQueryString": return DeliveryRuleCacheKeyQueryStringAction.DeserializeDeliveryRuleCacheKeyQueryStringAction(element);
                    case "ModifyRequestHeader": return DeliveryRuleRequestHeaderAction.DeserializeDeliveryRuleRequestHeaderAction(element);
                    case "ModifyResponseHeader": return DeliveryRuleResponseHeaderAction.DeserializeDeliveryRuleResponseHeaderAction(element);
                    case "OriginGroupOverride": return OriginGroupOverrideAction.DeserializeOriginGroupOverrideAction(element);
                    case "RouteConfigurationOverride": return DeliveryRuleRouteConfigurationOverrideAction.DeserializeDeliveryRuleRouteConfigurationOverrideAction(element);
                    case "UrlRedirect": return UrlRedirectAction.DeserializeUrlRedirectAction(element);
                    case "UrlRewrite": return UrlRewriteAction.DeserializeUrlRewriteAction(element);
                    case "UrlSigning": return UrlSigningAction.DeserializeUrlSigningAction(element);
                }
            }
            return UnknownDeliveryRuleAction.DeserializeUnknownDeliveryRuleAction(element);
        }
    }
}
