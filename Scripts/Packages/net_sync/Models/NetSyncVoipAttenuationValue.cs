// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<a79b4b3fae2d64192d8189e796ed1ec5>>
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

    /// The value is used in the [VoIP system](https://developer.oculus.com/documen
    /// tation/{{platform_doc_path}}/ps-parties/#voip-options). The value
    /// determines how much the audio volume is reduced as the distance between
    /// players increases. This helps to create a more immersive experience by
    /// making distant players' voices sound fainter.
    [Preserve]
    public class NetSyncVoipAttenuationValue
    {
        /// fall-off value in decibel
        [JsonProperty("decibels")]
        [Preserve]
        public float Decibels { get; set; }
        /// The starting distance of the attenuation value. As the distance between
        /// players increases, the audio volumn is reduced.
        [JsonProperty("distance")]
        [Preserve]
        public float Distance { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of NetSyncVoipAttenuationValue elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class NetSyncVoipAttenuationValueList : DeserializableList<NetSyncVoipAttenuationValue>
    {
    }
}
