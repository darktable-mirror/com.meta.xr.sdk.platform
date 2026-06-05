// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<3b99b451fd0dd5f261685454e019d86c>>
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

    /// The class that represents the product information for a specific IAP which
    /// is available for purchase in your app. You can retrieve more information
    /// about the product(s) by using their SKU with
    /// @internal_link(horizon.platform.iap.Iap#get_products_by_sku(List<String>,
    /// Integer))
    [Preserve]
    public class Product
    {
        /// Billing plans related to the product.
        [JsonProperty("billing_plans")]
        // May be null. Check before using.
        [Preserve]
        public BillingPlanList BillingPlansOptional { get; set; }
        /// The content rating of a @internal_link(horizon.platform.iap.models.Product)
        /// that specifies the age rating as well as other important information that
        /// needs to be displayed to the user per local regulations.
        [JsonProperty("content_rating")]
        // May be null. Check before using.
        [Preserve]
        public ContentRating ContentRatingOptional { get; set; }
        /// The URI for the cover image for the
        /// @internal_link(horizon.platform.iap.models.Product) being sold.
        [JsonProperty("cover_url")]
        [Preserve]
        public string CoverUrl { get; set; }
        /// The description for the product. The description should be meaningful and
        /// explanatory to help outline the product and its features.
        [JsonProperty("description")]
        [Preserve]
        public string Description { get; set; }
        /// The formatted string for the
        /// @internal_link(horizon.platform.iap.models.Price). This is the same value
        /// stored in @internal_link(horizon.platform.iap.models.Price).
        [JsonProperty("formatted_price")]
        [Preserve]
        public string FormattedPrice { get; set; }
        /// The URI for @internal_link(horizon.platform.iap.models.Product) icon.
        [JsonProperty("icon_url")]
        [Preserve]
        public string IconUrl { get; set; }
        /// The name of the product. This will be used as a the display name and should
        /// be aligned with the user facing title.
        [JsonProperty("name")]
        [Preserve]
        public string Name { get; set; }
        /// The @internal_link(horizon.platform.iap.models.Price) of the product
        /// contains the currency code, the amount in hundredths, and the formatted
        /// string representation.
        [JsonProperty("price")]
        [Preserve]
        public Price Price { get; set; }
        /// The short description of a
        /// @internal_link(horizon.platform.iap.models.Product) which provides more
        /// information about the @internal_link(horizon.platform.iap.models.Product).
        /// To be used in conjunction with the description of the
        /// @internal_link(horizon.platform.iap.models.Product).
        [JsonProperty("short_description")]
        [Preserve]
        public string ShortDescription { get; set; }
        /// The unique string that you use to reference the product in your app. The
        /// SKU is case-sensitive and should match the SKU reference in your code.
        [JsonProperty("sku")]
        [Preserve]
        public string Sku { get; set; }
        /// The type of product. An In-app purchase (IAP) add-on can be
        /// @internal_link(horizon.platform.iap.enums.ProductType#durable),
        /// @internal_link(horizon.platform.iap.enums.ProductType#consumable), or a
        /// @internal_link(horizon.platform.iap.enums.ProductType#subscription).
        [JsonProperty("type")]
        [JsonConverter(typeof(EnumDescriptionConverter<ProductType>))]
        [Preserve]
        public ProductType Type { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of Product elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class ProductList : DeserializableList<Product>
    {
    }
}
