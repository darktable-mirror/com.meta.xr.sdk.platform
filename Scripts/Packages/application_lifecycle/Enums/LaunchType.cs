// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<0f64a59d7ce23d6e16f21e8bcc5ea922>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// It's an enum that defines several different types of launches for an
    /// application. It provides a way to differentiate between different types of
    /// launches and to access additional information about the launch details. It
    /// can be retrieved using @internal_link(horizon.platform.application_lifecycl
    /// e.models.LaunchDetails#launch_type) to get the launch type information of
    /// an application.
    [Preserve]
    public enum LaunchType : int
    {
        /// Represents that the LaunchType is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// Normal launch from the user's library
        [Description("NORMAL")]
        [Preserve]
        Normal,

        /// Launch from the user accepting an invite.  Check @internal_link(horizon.pla
        /// tform.application_lifecycle.models.LaunchDetails#lobby_session_id), @intern
        /// al_link(horizon.platform.application_lifecycle.models.LaunchDetails#match_s
        /// ession_id), @internal_link(horizon.platform.application_lifecycle.models.La
        /// unchDetails#destination_api_name) and @internal_link(horizon.platform.appli
        /// cation_lifecycle.models.LaunchDetails#deeplink_message).
        [Description("INVITE")]
        [Preserve]
        Invite,

        /// DEPRECATED
        [Description("COORDINATED")]
        [Preserve]
        Coordinated,

        /// Launched from @internal_link(horizon.platform.application.Application#launc
        /// h_other_app(ID, ApplicationOptions)). Check @internal_link(horizon.platform
        /// .application_lifecycle.models.LaunchDetails#launch_source) and @internal_li
        /// nk(horizon.platform.application_lifecycle.models.LaunchDetails#deeplink_mes
        /// sage).
        [Description("DEEPLINK")]
        [Preserve]
        Deeplink,

        
    }

}
