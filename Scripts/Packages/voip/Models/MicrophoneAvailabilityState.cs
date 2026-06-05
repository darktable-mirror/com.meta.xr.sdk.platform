// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<c04e9abd1173072fa1b650a6ce0aa5f2>>
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

    /// It represents the availability of a microphone device. It can be retrieved
    /// using
    /// @internal_link(horizon.platform.voip.Voip#get_microphone_availability()).
    /// It has only one field, microphone_available, which is a boolean value that
    /// indicates whether a microphone is available or not. This data structure can
    /// be used by applications to determine whether they can use the microphone
    /// for audio input or not.
    [Preserve]
    public class MicrophoneAvailabilityState
    {
        /// A `boolean` indicates whether the microphone is currently available or not.
        /// If there is any update on the microphone availability, it will be retrieved
        /// as a notification using @internal_link(horizon.platform.voip.Voip#microphon
        /// e_availability_state_update()).
        [JsonProperty("microphone_available")]
        [Preserve]
        public bool MicrophoneAvailable { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
