// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<be3237dac92707df731a46fa8af1c875>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// An enumeration that defines the type of the
    /// @internal_link(horizon.platform.iap.models.TrialOffer). This can be
    /// utilized to identify the specific type of offer, such as a free trial or an
    /// intro offer. By setting this field, you can easily differentiate between
    /// different types of offers and provide a better user experience for your
    /// customers.
    [Preserve]
    public enum OfferType : int
    {
        /// Represents that the OfferType is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// This value indicates that the offer is an intro offer, which is typically a
        /// special promotion or discount offered to new customers.
        [Description("INTRO_OFFER")]
        [Preserve]
        IntroOffer,

        /// This value indicates that the offer is a free trial, which allows customers
        /// to try out a product or service without paying for it.
        [Description("FREE_TRIAL")]
        [Preserve]
        FreeTrial,

        
        // Backward compatibility aliases
        UNKNOWN = Unknown,
        INTRO_OFFER = IntroOffer,
        INTROOFFER = IntroOffer,
        FREE_TRIAL = FreeTrial,
        FREETRIAL = FreeTrial,
        
    }

}
