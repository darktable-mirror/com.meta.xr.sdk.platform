// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<a38bb3f892de8750cb1c0140ad612745>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// The age category in a Meta account is used to determine eligibility for
    /// certain features and services. This information is important for ensuring
    /// that users are able to access the appropriate content and functionality
    /// based on their age. The values are used in @internal_link(horizon.platform.
    /// user_age_category.models.UserAccountAgeCategory) API. See more details
    /// [here](https://developer.oculus.com/documentation/android-apps/ps-get-age-
    /// category-api).
    [Preserve]
    public enum AppAgeCategory : int
    {
        /// Represents that the AppAgeCategory is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// Child age group for users between the ages of 10-12 (or applicable age in
        /// user's region).
        [Description("CH")]
        [Preserve]
        Ch,

        /// Non-child age group for users ages 13 and up (or applicable age in user's
        /// region).
        [Description("NCH")]
        [Preserve]
        Nch,

        
    }

}
