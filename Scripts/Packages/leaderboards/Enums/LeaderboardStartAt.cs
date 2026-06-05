// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<1c6c630f9b5ab2193bc61ffbadd62eb6>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// An enum that allows you to specify the starting point for the leaderboard
    /// entries. It can be used as a params in @internal_link(horizon.platform.lead
    /// erboards.Leaderboards#get_entries(String, Integer, LeaderboardFilterType,
    /// LeaderboardStartAt)) to the starting point for the leaderboard entries that
    /// are returned in the response.
    [Preserve]
    public enum LeaderboardStartAt : int
    {
        /// This value indicates that the leaderboard entries should start at the top
        /// of the leaderboard.
        [Description("TOP")]
        [Preserve]
        Top,

        /// This value indicates that the leaderboard entries should start at the
        /// viewer's position on the leaderboard
        [Description("CENTERED_ON_VIEWER")]
        [Preserve]
        CenteredOnViewer,

        /// This value indicates that the leaderboard entries should start at the
        /// viewer's position on the leaderboard, or at the top of the leaderboard if
        /// the viewer is not present.
        [Description("CENTERED_ON_VIEWER_OR_TOP")]
        [Preserve]
        CenteredOnViewerOrTop,

        /// Represents that the LeaderboardStartAt is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        
    }

}
