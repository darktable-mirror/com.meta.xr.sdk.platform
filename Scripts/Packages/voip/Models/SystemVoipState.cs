// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<cd963f521045d25f81c41a8b1743c97a>>
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

    /// The state of the voip that is used in parties and horizon home. This class
    /// contains different statuses that is used to control the microphone and
    /// input/output for commands or chat in your application. You can read more
    /// about system voip
    /// [here](https://developer.oculus.com/documentation/{{platform_doc_path}}/ps-
    /// parties/#voip-options).
    [Preserve]
    public class SystemVoipState
    {
        /// A flag that is used to indicate the current state of the microphone. The
        /// status can be of the following types: - Unknown:
        /// @internal_link(horizon.platform.voip.enums.VoipMuteState#unknown) - Muted:
        /// @internal_link(horizon.platform.voip.enums.VoipMuteState#muted) - Unmuted:
        /// @internal_link(horizon.platform.voip.enums.VoipMuteState#unmuted)
        [JsonProperty("microphone_muted")]
        [JsonConverter(typeof(EnumDescriptionConverter<VoipMuteState>))]
        [Preserve]
        public VoipMuteState MicrophoneMuted { get; set; }
        /// The flag indicates whether passthrough is currently enabled on the user's
        /// headset. Passthrough is important for enabling PCM.
        [JsonProperty("passthrough")]
        [Preserve]
        public bool Passthrough { get; set; }
        /// FIXME: Add doc comment for this field!
        [JsonProperty("shared_memory_handle")]
        [Preserve]
        public int SharedMemoryHandle { get; set; }
        /// The status enum that indicates the current state of the system voip. The
        /// status can be of the following types: - Unknown:
        /// @internal_link(horizon.platform.voip.enums.SystemVoipStatus#unknown) -
        /// Unavailable:
        /// @internal_link(horizon.platform.voip.enums.SystemVoipStatus#unavailable) -
        /// Suppressed:
        /// @internal_link(horizon.platform.voip.enums.SystemVoipStatus#suppressed) -
        /// Active: @internal_link(horizon.platform.voip.enums.SystemVoipStatus#active)
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumDescriptionConverter<SystemVoipStatus>))]
        [Preserve]
        public SystemVoipStatus Status { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
