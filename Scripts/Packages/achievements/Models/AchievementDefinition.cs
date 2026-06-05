// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<84dd177df8830c54d9030986704adf74>>
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

    /// An AchievementDefinition defines an achievement; this includes its name and
    /// how it is unlocked. For an individual user's progress in unlocking an
    /// achievement, see AchievementProgress. It can be retrieved using @internal_l
    /// ink(horizon.platform.achievements.Achievements#get_all_definitions()).
    [Preserve]
    public class AchievementDefinition
    {
        /// This is the type of achievement. There are three types of achievement:
        /// @internal_link(horizon.platform.achievements.enums.AchievementType#simple)
        /// - unlocked by completion of a single event or objective, @internal_link(hor
        /// izon.platform.achievements.enums.AchievementType#bitfield) - unlocked when
        /// a number of bits in a bitfield are set, and
        /// @internal_link(horizon.platform.achievements.enums.AchievementType#count) -
        /// unlocked when a counter reaches a defined target.
        [JsonProperty("achievement_type")]
        [JsonConverter(typeof(EnumDescriptionConverter<AchievementType>))]
        [Preserve]
        public AchievementType Type { get; set; }
        /// A string of the api name of the achievement. It can be used to get the
        /// achievement progress by name by the function @internal_link(horizon.platfor
        /// m.achievements.Achievements#get_progress_by_name(List<String>, Integer)).
        [JsonProperty("api_name")]
        [Preserve]
        public string Name { get; set; }
        /// It is required for bitfield achievements: @internal_link(horizon.platform.a
        /// chievements.enums.AchievementType#bitfield). This represents the size of
        /// the bitfield for this achievement.
        [JsonProperty("bitfield_length")]
        [Preserve]
        public uint BitfieldLength { get; set; }
        /// FIXME: Add doc comment for this field!
        [JsonProperty("target")]
        [Preserve]
        public ulong Target { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of AchievementDefinition elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class AchievementDefinitionList : DeserializableList<AchievementDefinition>
    {
    }
}
