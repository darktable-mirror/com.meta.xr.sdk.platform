// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<6671ce1ffabf87972923e7673a3145cc>>
 */

namespace Oculus.Platform.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using UnityEngine.Scripting;

    /// This is a supplemental piece of data that is used for a single write to
    /// leaderboard entries. This metric is used for tiebreaker scenarios. You can
    /// make such an entry by using @internal_link(horizon.platform.leaderboards.Le
    /// aderboards#write_entry_with_supplementary_metric(String, Long, Long,
    /// List<Byte>, UInt, Boolean))
    [Preserve]
    public class SupplementaryMetric
    {
        /// The ID of the leaderboard that this supplementary metric belongs to. This
        /// is the unique value for every
        /// @internal_link(horizon.platform.leaderboards.models.Leaderboard).
        [JsonProperty("id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 ID { get; set; }
        /// This is the metric that is used to determine tiebreaks.
        [JsonProperty("metric")]
        [Preserve]
        public long Metric { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
