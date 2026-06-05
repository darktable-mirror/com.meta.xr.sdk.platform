// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<4c6f491ca496f391ec0df742d1977d9f>>
 */

#pragma warning disable 0618

namespace Oculus.Platform.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using UnityEngine.Scripting;

    /// A purchase is made when a user buys a
    /// @internal_link(horizon.platform.iap.models.Product). The IAP product, which
    /// can represent a consumable item, a durable item, or a subscription, must be
    /// defined for purchase through the developer dashboard.
    [Preserve]
    public class Purchase
    {
        /// The developer payload feature is unimplemented.
        [JsonProperty("developer_payload")]
        [Preserve]
        public string DeveloperPayload { get; set; }
        /// The time when the purchased
        /// @internal_link(horizon.platform.iap.models.Product) expires. This value
        /// only applies to subscriptions, and will be null for durable and consumable
        /// IAP items.
        [JsonProperty("expiration_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [Preserve]
        public DateTime ExpirationTime { get; set; }
        /// The timestamp that represents when the user was granted entitlement to the
        /// @internal_link(horizon.platform.iap.models.Product) that was purchased.
        [JsonProperty("grant_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [Preserve]
        public DateTime GrantTime { get; set; }
        /// The unique identifier of a
        /// @internal_link(horizon.platform.iap.models.Purchase) represents a user's
        /// unique entitlement to a
        /// @internal_link(horizon.platform.iap.models.Product). This value is 0 for
        /// shared IAP entitlements.
        [JsonProperty("id")]
        [Preserve]
        public string ID { get; set; }
        /// The Reporting ID feature is not implemented.
        [JsonProperty("reporting_id")]
        [Preserve]
        public string ReportingId { get; set; }
        /// The SKU of the IAP @internal_link(horizon.platform.iap.models.Product) that
        /// was purchased. This value is case-sensitive. To retrieve the product
        /// information, you can use this value when calling
        /// @internal_link(horizon.platform.iap.Iap#get_products_by_sku(List<String>,
        /// Integer)).
        [JsonProperty("sku")]
        [Preserve]
        public string Sku { get; set; }
        /// The Type of the IAP @internal_link(horizon.platform.iap.models.Product)
        /// that was purchased. The values can be
        /// @internal_link(horizon.platform.iap.enums.ProductType#durable),
        /// @internal_link(horizon.platform.iap.enums.ProductType#consumable), or a
        /// @internal_link(horizon.platform.iap.enums.ProductType#subscription).
        [JsonProperty("type")]
        [Preserve]
        public ProductType Type { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of Purchase elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class PurchaseList : DeserializableList<Purchase>
    {
    }
}
