// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<d4f69d332e295fad98a60cd8816bdf2b>>
 */

namespace Oculus.Platform.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using UnityEngine.Scripting;

    /// Contains the details about the paid offer associated with a
    /// @internal_link(horizon.platform.iap.models.BillingPlan).
    [Preserve]
    public class PaidOffer
    {
        /// The @internal_link(horizon.platform.iap.models.Price) of the paid offer
        /// contains the currency code, the amount in hundredths, and the formatted
        /// string representation.
        [JsonProperty("price")]
        [Preserve]
        public Price Price { get; set; }
        /// An enum that specifies the term.
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#unknown): unknown
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#weekly): WEEKLY
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#biweekly): BIWEEKLY
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#monthly): MONTHLY
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#quarterly): QUARTERLY
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#semiannual): SEMIANNUAL
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#annual): ANNUAL
        /// @internal_link(horizon.platform.iap.enums.OfferTerm#biannual): BIANNUAL
        [JsonProperty("subscription_term")]
        [JsonConverter(typeof(EnumDescriptionConverter<OfferTerm>))]
        [Preserve]
        public OfferTerm SubscriptionTerm { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
