// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<36f02dcd8afaf4821eee4a3297f35813>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// Describe the current status of the user and it can be retrieved with
    /// @internal_link(horizon.platform.users.models.User#presence_status).
    [Preserve]
    public enum UserPresenceStatus : int
    {
        /// Represents that the UserPresenceStatus is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// The user status is currently online.
        [Description("ONLINE")]
        [Preserve]
        Online,

        /// The user status is currently offline.
        [Description("OFFLINE")]
        [Preserve]
        Offline,

        
    }

}
