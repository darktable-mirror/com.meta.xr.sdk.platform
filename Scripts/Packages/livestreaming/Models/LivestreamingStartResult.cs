// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<ef2250223d297d528bc41f2b4e99434d>>
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

    /// You will receive this livestreaming start result once you start a
    /// livestream to Facebook or to a party in your app. This result will show if
    /// the start status is a success or unknown or a failure because of various
    /// reasons including no Facebook connection or missing parameters.
    [Preserve]
    public class LivestreamingStartResult
    {
        /// This livestreaming result represents the start status of your livestream.
        /// You can refer to @internal_link(horizon.platform.livestreaming.enums.Livest
        /// reamingStartStatus) for possible status info.
        [JsonProperty("streaming_result_string")]
        [JsonConverter(typeof(EnumDescriptionConverter<LivestreamingStartStatus>))]
        [Preserve]
        public LivestreamingStartStatus StreamingResult { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
