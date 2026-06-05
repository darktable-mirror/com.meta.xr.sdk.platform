// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<6df7e778119a051457748dfcc7afb4fe>>
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

    /// A leaderboard entry object contains information about the
    /// @internal_link(horizon.platform.users.models.User) who made the entry,
    /// their score, and other relevant details in the leaderboard. It provides a
    /// way for a game to keep track of players and their scores in relation to
    /// other. A single leaderboard entry can be written by @internal_link(horizon.
    /// platform.leaderboards.Leaderboards#write_entry(String, Long, List<Byte>,
    /// UInt, Boolean)). A block of leaderboard entries can be retrieved using @int
    /// ernal_link(horizon.platform.leaderboards.Leaderboards#get_entries(String,
    /// Integer, LeaderboardFilterType, LeaderboardStartAt)). Visit our [website](h
    /// ttps://developer.oculus.com/documentation/{{platform_doc_path}}/ps-
    /// leaderboards/) for more information about the leaderboard entry.
    [Preserve]
    public class LeaderboardEntry
    {
        /// The formatted score that will be displayed in the leaderboard of this
        /// entry. You can select a score type to determine how scores are displayed on
        /// Leaderboard. See
        /// [here](https://developer.oculus.com/documentation/{{platform_doc_path}}/ps-
        /// leaderboards/#create) for examples of different score type.
        [JsonProperty("display_score")]
        [Preserve]
        public string DisplayScore { get; set; }
        /// A 2KB custom data field that is associated with the leaderboard entry. This
        /// can be a game replay or anything that provides more detail about the entry
        /// to the viewer. It will be used by two entry methods: @internal_link(horizon
        /// .platform.leaderboards.Leaderboards#write_entry(String, Long, List<Byte>,
        /// UInt, Boolean)) and @internal_link(horizon.platform.leaderboards.Leaderboar
        /// ds#write_entry_with_supplementary_metric(String, Long, Long, List<Byte>,
        /// UInt, Boolean))
        [JsonProperty("extra_data_base64")]
        [Preserve]
        public byte[] ExtraData { get; set; }
        /// This is a unique identifier for the leaderboard entry. It is of type `id`
        /// and is optional.
        [JsonProperty("id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 ID { get; set; }
        /// The rank of this leaderboard entry in the leaderboard. It is of type `int`.
        /// It can be used in @internal_link(horizon.platform.leaderboards.Leaderboards
        /// #get_entries_after_rank(String, Integer, ULong)) to retrieve leaderboard
        /// entries starting from a specified rank.
        [JsonProperty("rank")]
        [Preserve]
        public int Rank { get; set; }
        /// The raw underlying value of the score achieved by the user in the
        /// leaderboard. It's of type `long_as_string` and it's used to determine the
        /// user's rank in the leaderboard.
        [JsonProperty("score")]
        [Preserve]
        public long Score { get; set; }
        /// @internal_link(horizon.platform.leaderboards.models.SupplementaryMetric) is
        /// a supplemental piece of data that can be used for tiebreakers by @internal_
        /// link(horizon.platform.leaderboards.Leaderboards#write_entry_with_supplement
        /// ary_metric(String, Long, Long, List<Byte>, UInt, Boolean)).
        [JsonProperty("supplementary_metric")]
        // May be null. Check before using.
        [Preserve]
        public SupplementaryMetric SupplementaryMetricOptional { get; set; }
        /// The timestamp of this entry being created in the leaderboard.
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [Preserve]
        public DateTime Timestamp { get; set; }
        /// User of this leaderboard entry. It is of type
        /// @internal_link(horizon.platform.users.models.User). You can request a block
        /// of leaderboard entries for the specified user ID(s) by @internal_link(horiz
        /// on.platform.leaderboards.Leaderboards#get_entries_by_ids(String, Integer,
        /// LeaderboardStartAt, List<ID>, UInt)).
        [JsonProperty("user")]
        [Preserve]
        public User User { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of LeaderboardEntry elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class LeaderboardEntryList : DeserializableList<LeaderboardEntry>
    {
    }
}
