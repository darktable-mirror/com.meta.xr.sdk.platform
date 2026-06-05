// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<4582a7a2958dfacfa87a16ebf1e08032>>
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

    /// The details for an IAP @internal_link(horizon.platform.iap.models.Product)
    /// that was purchased
    [Preserve]
    public class PurchaseItem
    {
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
    
}
