// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<fd5a931bb51b42cf0105b0862c08a897>>
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

    /// A @internal_link(horizon.platform.net_sync.models.NetSyncConnection) allows
    /// multiple clients to connect and communicate with each other in real-time.
    /// This is the payload from setting the properties of
    /// @internal_link(horizon.platform.net_sync.models.NetSyncSession). You can
    /// retrieve the result session via @internal_link(horizon.platform.net_sync.mo
    /// dels.NetSyncSetSessionPropertyResult#session).
    [Preserve]
    public class NetSyncSetSessionPropertyResult
    {
        /// It contains the
        /// @internal_link(horizon.platform.net_sync.models.NetSyncSession) that the
        /// operation was modifying.
        [JsonProperty("session")]
        [Preserve]
        public NetSyncSession Session { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
