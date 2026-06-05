// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<e71668817ad7d64ae73666b7b21bf295>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// A user can have multiple sdk accounts associated with it. An
    /// @internal_link(horizon.platform.users.models.SdkAccount) represents the
    /// oculus user and the particular x-account that is linked to the  user. SDK
    /// accounts can be retrived for a particular user by calling
    /// @internal_link(horizon.platform.users.Users#get_sdk_accounts()). This
    /// enumeration represents the specific type of SDK account that is associated.
    [Preserve]
    public enum SdkAccountType : int
    {
        /// Represents that the SdkAccountType is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// TODO: Add comment for this enum member!
        [Description("OCULUS")]
        [Preserve]
        Oculus,

        /// TODO: Add comment for this enum member!
        [Description("FACEBOOK_GAMEROOM")]
        [Preserve]
        FacebookGameroom,

        
    }

}
