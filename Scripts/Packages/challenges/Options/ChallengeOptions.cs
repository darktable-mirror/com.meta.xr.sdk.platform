// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<c44411ff84f1a7b58e172f9c3407115f>>
 */

using System;
using System.Collections;
using Oculus.Platform.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;
using UnityEngine.Scripting;

namespace Oculus.Platform
{
    /// The Challenge Option is a parameter that can be passed in the @internal_lin
    /// k(horizon.platform.challenges.Challenges#get_list(ChallengeOptions,
    /// Integer)) method to retrieve a list of challenges that match the specified
    /// options. The
    /// @internal_link(horizon.platform.challenges.options.ChallengeOptions)
    /// parameter allows you to specify the criteria for the challenges you want to
    /// retrieve, such as the viewer filter, the visibility, or the date range.
    [Serializable]
    [Preserve]
    public class ChallengeOptions {
        /// The description of the challenge is a detailed and informative text that
        /// provides a comprehensive overview of the challenge's objectives, rules, and
        /// requirements, which can be retrieved with
        /// @internal_link(horizon.platform.challenges.models.Challenge#description).
        [JsonProperty("description")]
        [Preserve]
        public string Description = "";
        /// The challenge end date is the timestamp when this challenge ends, which can
        /// be retrieved using
        /// @internal_link(horizon.platform.challenges.models.Challenge#end_date).
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [Preserve]
        public DateTime? EndDate = null;
        /// This option indicates whether to include challenges that are currently
        /// active in the search results. By default, this is set to true, meaning that
        /// only active challenges will be returned.
        [JsonProperty("include_active_challenges")]
        [Preserve]
        public bool IncludeActiveChallenges = true;
        /// This option indicates whether to include challenges that have not yet
        /// started in the search results. By default, this is set to false, meaning
        /// that only active will be returned.
        [JsonProperty("include_future_challenges")]
        [Preserve]
        public bool IncludeFutureChallenges = false;
        /// This option indicates whether to include challenges that have already ended
        /// in the search results. By default, this is set to false, meaning that only
        /// active will be returned.
        [JsonProperty("include_past_challenges")]
        [Preserve]
        public bool IncludePastChallenges = false;
        /// Optional: Only find challenges belonging to this leaderboard. This filter
        /// allows you to narrow down the search results to only include challenges
        /// that are associated with a specific leaderboard.
        [JsonProperty("leaderboard_name")]
        [Preserve]
        public string LeaderboardName = "";
        /// The challenge start date is the timestamp when this challenge begins, which
        /// can be retrieved using
        /// @internal_link(horizon.platform.challenges.models.Challenge#start_date).
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [Preserve]
        public DateTime? StartDate = null;
        /// The title of the challenge is a descriptive label that provides a concise
        /// summary of the challenge's purpose and objectives, which can be retrieved
        /// with @internal_link(horizon.platform.challenges.models.Challenge#title).
        [JsonProperty("title")]
        [Preserve]
        public string Title = "";
        /// An enum that specifies what filter to apply to the list of returned
        /// challenges. Returns all public (@internal_link(horizon.platform.challenges.
        /// enums.ChallengeVisibility#public)) and invite-only (@internal_link(horizon.
        /// platform.challenges.enums.ChallengeVisibility#invite_only))
        /// @internal_link(horizon.platform.challenges.models.Challenge) in which the
        /// user is a participant or invitee. Excludes private (@internal_link(horizon.
        /// platform.challenges.enums.ChallengeVisibility#private)) challenges. @intern
        /// al_link(horizon.platform.challenges.enums.ChallengeViewerFilter#participati
        /// ng) - Returns challenges the user is participating in. @internal_link(horiz
        /// on.platform.challenges.enums.ChallengeViewerFilter#invited) - Returns
        /// challenges the user is invited to. @internal_link(horizon.platform.challeng
        /// es.enums.ChallengeViewerFilter#participating_or_invited) - Returns
        /// challenges the user is either participating in or invited to.
        [JsonProperty("viewer_filter")]
        [JsonConverter(typeof(EnumDescriptionConverter<ChallengeViewerFilter>))]
        [Preserve]
        public ChallengeViewerFilter ViewerFilter = ChallengeViewerFilter.Unknown;
        /// The challenge visibility setting specifies who can see and participate in
        /// this challenge, which be retrieved with
        /// @internal_link(horizon.platform.challenges.models.Challenge#visibility).
        /// There are three visibility levels: @internal_link(horizon.platform.challeng
        /// es.enums.ChallengeVisibility#public), @internal_link(horizon.platform.chall
        /// enges.enums.ChallengeVisibility#invite_only) and @internal_link(horizon.pla
        /// tform.challenges.enums.ChallengeVisibility#private).
        [JsonProperty("visibility")]
        [JsonConverter(typeof(EnumDescriptionConverter<ChallengeVisibility>))]
        [Preserve]
        public ChallengeVisibility Visibility = ChallengeVisibility.Unknown;
        
        public string Json => JsonUtility.ToJson(this);

        [Preserve]
        public ChallengeOptions()
        {
        }
        
        [Preserve]
        public void SetDescription(string value)
        {
            Description = value;
        }
        
        [Preserve]
        public void SetEndDate(DateTime? value)
        {
            EndDate = value;
        }
        
        [Preserve]
        public void SetIncludeActiveChallenges(bool value)
        {
            IncludeActiveChallenges = value;
        }
        
        [Preserve]
        public void SetIncludeFutureChallenges(bool value)
        {
            IncludeFutureChallenges = value;
        }
        
        [Preserve]
        public void SetIncludePastChallenges(bool value)
        {
            IncludePastChallenges = value;
        }
        
        [Preserve]
        public void SetLeaderboardName(string value)
        {
            LeaderboardName = value;
        }
        
        [Preserve]
        public void SetStartDate(DateTime? value)
        {
            StartDate = value;
        }
        
        [Preserve]
        public void SetTitle(string value)
        {
            Title = value;
        }
        
        [Preserve]
        public void SetViewerFilter(ChallengeViewerFilter value)
        {
            ViewerFilter = value;
        }
        
        [Preserve]
        public void SetVisibility(ChallengeVisibility value)
        {
            Visibility = value;
        }
        
        ~ChallengeOptions()
        {
        }
    }
}
