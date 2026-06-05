// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<80b2995d26dcb3e8b56444fefc358f22>>
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

    /// The livestreaming application status represents the status result of
    /// whether the livestreaming is enabled for an app. If your app is enabled,
    /// you will receive a notification by @internal_link(horizon.platform.livestre
    /// aming.Livestreaming#status_change()) when the livestreaming session gets
    /// updated.
    [Preserve]
    public class LivestreamingApplicationStatus
    {
        /// This is a boolean field and represents whether the app is allowed to do the
        /// livestreaming or not.
        [JsonProperty("streaming_enabled")]
        [Preserve]
        public bool StreamingEnabled { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
