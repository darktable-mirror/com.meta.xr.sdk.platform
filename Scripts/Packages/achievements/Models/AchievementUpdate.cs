// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<31ba32487c907e8d688950e9de426e99>>
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

    /// Represents an update to an existing achievement. It will be the payload if
    /// there is any updates on achievements, as unlocking an achievement by
    /// @internal_link(horizon.platform.achievements.Achievements#unlock(String)),
    /// adding 'count' to the achievement by
    /// @internal_link(horizon.platform.achievements.Achievements#add_count(String,
    /// ULong)), and unlocking fields of a BITFIELD achievement by @internal_link(h
    /// orizon.platform.achievements.Achievements#add_fields(String, String)).
    [Preserve]
    public class AchievementUpdate
    {
        /// This indicates if this update caused the achievement to unlock.
        [JsonProperty("just_unlocked")]
        [Preserve]
        public bool JustUnlocked { get; set; }
        /// The unique @internal_link(horizon.platform.achievements.models.AchievementD
        /// efinition#api_name) used to reference the updated achievement, as specified
        /// in the developer dashboard.
        [JsonProperty("api_name")]
        [Preserve]
        public string Name { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
