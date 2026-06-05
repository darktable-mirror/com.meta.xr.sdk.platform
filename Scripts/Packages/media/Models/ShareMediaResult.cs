// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<41d33698445c559974194a296aad5780>>
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

    /// The result from users launching the Share to Facebook modal which enables
    /// them to share local media files through
    /// @internal_link(horizon.platform.media.Media#share_to_facebook(String,
    /// String, MediaContentType)). The result will contain a status field,
    /// @internal_link(horizon.platform.media.enums.ShareMediaStatus).
    [Preserve]
    public class ShareMediaResult
    {
        /// The status of the share media result. The status can be of the following
        /// types:
        /// @internal_link(horizon.platform.media.enums.ShareMediaStatus#unknown)
        /// @internal_link(horizon.platform.media.enums.ShareMediaStatus#shared)
        /// @internal_link(horizon.platform.media.enums.ShareMediaStatus#canceled)
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumDescriptionConverter<ShareMediaStatus>))]
        [Preserve]
        public ShareMediaStatus Status { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
