// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<f27b76a71b4d8978672018a57531bbb8>>
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

    /// This object is a response from the server that contains information about
    /// the status of the request to update the leaderboard. It can be retrieved
    /// using two different API requests: @internal_link(horizon.platform.leaderboa
    /// rds.Leaderboards#write_entry(String, Long, List<Byte>, UInt, Boolean)) and 
    /// @internal_link(horizon.platform.leaderboards.Leaderboards#write_entry_with_
    /// supplementary_metric(String, Long, Long, List<Byte>, UInt, Boolean)).
    [Preserve]
    public class LeaderboardUpdateStatus
    {
        /// A `boolean` indicates whether the leaderboard was updated.
        [JsonProperty("did_update")]
        [Preserve]
        public bool DidUpdate { get; set; }
        /// If the leaderboard is updated, this represents the updated challenge IDs.
        /// The updated challenge IDs can be used by
        /// @internal_link(horizon.platform.challenges.Challenges#get_entries(ID,
        /// Integer, LeaderboardFilterType, LeaderboardStartAt)), @internal_link(horizo
        /// n.platform.challenges.Challenges#get_entries_after_rank(ID, Integer,
        /// ULong)), or @internal_link(horizon.platform.challenges.Challenges#get_entri
        /// es_by_ids(ID, Integer, LeaderboardStartAt, List<ID>, UInt)) APIs.
        [JsonProperty("updated_challenge_ids")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64[] UpdatedChallengeIds { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
