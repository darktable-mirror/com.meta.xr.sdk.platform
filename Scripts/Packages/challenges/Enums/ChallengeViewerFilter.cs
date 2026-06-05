// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<dca55e344eb860eac696f51f06b7c539>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// The available filtering options on the
    /// @internal_link(horizon.platform.challenges.models.Challenge) returned by @i
    /// nternal_link(horizon.platform.challenges.Challenges#get_list(ChallengeOptio
    /// ns, Integer)). These filters allow users to customize their search results
    /// and retrieve only the challenges that meet specific criteria. See more
    /// details of Challenges in
    /// [here](https://developer.oculus.com/documentation/{{platform_doc_path}}/ps-
    /// challenges/).
    [Preserve]
    public enum ChallengeViewerFilter : int
    {
        /// Represents that the ChallengeViewerFilter is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// Returns all public ((@internal_link(horizon.platform.challenges.enums.Chall
        /// engeVisibility#public))) and invite-only (@internal_link(horizon.platform.c
        /// hallenges.enums.ChallengeVisibility#invite_only))
        /// @internal_link(horizon.platform.challenges.models.Challenge)s in which the
        /// user is a participant or invitee. Excludes private (@internal_link(horizon.
        /// platform.challenges.enums.ChallengeVisibility#private)) challenges. This
        /// filter is useful for users who want to see all challenges they are involved
        /// in, regardless of their visibility settings.
        [Description("ALL_VISIBLE")]
        [Preserve]
        AllVisible,

        /// Returns challenges in which the user is a participant. This filter is
        /// useful for users who want to see only the challenges they are actively
        /// participating in.
        [Description("PARTICIPATING")]
        [Preserve]
        Participating,

        /// Returns challenges that the user has been invited to. This filter is useful
        /// for users who want to see only the challenges they have been explicitly
        /// invited to.
        [Description("INVITED")]
        [Preserve]
        Invited,

        /// Returns challenges the user is either participating in or invited to. This
        /// filter is useful for users who want to see all challenges they are involved
        /// in, whether as a participant or an invitee.
        [Description("PARTICIPATING_OR_INVITED")]
        [Preserve]
        ParticipatingOrInvited,

        
    }

}
