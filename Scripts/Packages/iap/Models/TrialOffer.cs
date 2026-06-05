// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<4ef2f7aa8b205f367efcca7938fd843d>>
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

    /// Contains the details about the trial offer associated with a
    /// @internal_link(horizon.platform.iap.models.BillingPlan).
    [Preserve]
    public class TrialOffer
    {
        /// Represents the maximum term for which a trial_offer is valid.
        [JsonProperty("max_term_count")]
        [Preserve]
        public int MaxTermCount { get; set; }
        /// The @internal_link(horizon.platform.iap.models.Price) of the trial offer
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
        [JsonProperty("trial_term")]
        [JsonConverter(typeof(EnumDescriptionConverter<OfferTerm>))]
        [Preserve]
        public OfferTerm TrialTerm { get; set; }
        /// An enum that specifies the type of the trial.
        /// @internal_link(horizon.platform.iap.enums.OfferType#intro_offer): Intro
        /// Offer. @internal_link(horizon.platform.iap.enums.OfferType#free_trial):
        /// Free Trial.
        [JsonProperty("trial_type")]
        [JsonConverter(typeof(EnumDescriptionConverter<OfferType>))]
        [Preserve]
        public OfferType TrialType { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of TrialOffer elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class TrialOfferList : DeserializableList<TrialOffer>
    {
    }
}
