// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<ef77f08087ecb5cb7b8740ddcdf36c5b>>
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

    /// Represents an update to an HTTP transfer, which is a process of
    /// transferring data over the internet using the HTTP protocol. It provides a
    /// way for developers to monitor the progress of an HTTP transfer and can be
    /// retrieved using @internal_link(horizon.platform.http.Http#transfer()).
    [Preserve]
    public class HttpTransferUpdate
    {
        /// An array of bytes that represents the data being transferred.
        [JsonProperty("bytes")]
        [Preserve]
        public byte[] Payload { get; set; }
        /// It's a unique identifier for the HTTP transfer. It is used to track the
        /// progress of the transfer and can be retrieved using
        /// @internal_link(horizon.platform.common.models.Message#request_id).
        [JsonProperty("id")]
        [Preserve]
        public UInt64 ID { get; set; }
        /// This field is a `boolean` value that indicates whether the HTTP transfer
        /// has been completed or not.
        [JsonProperty("is_completed")]
        [Preserve]
        public bool IsCompleted { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
