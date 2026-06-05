// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<dca205ddf8db4bb18c6bfc5a30c6b20c>>
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

    /// An AssetFileDeleteResult contains the result of a deleted asset file. You
    /// can delete an asset file by using
    /// @internal_link(horizon.platform.asset_file.AssetFile#delete_by_id(ID)) or @
    /// internal_link(horizon.platform.asset_file.AssetFile#delete_by_name(String))
    /// . The delete result contains the @internal_link(horizon.platform.asset_file
    /// .models.AssetFileDeleteResult#asset_id), the file path, and the success
    /// status of the deleted asset.
    [Preserve]
    public class AssetFileDeleteResult
    {
        [JsonProperty("asset_file_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 AssetFileId { get; set; }
        /// This represents the ID of the asset file. When you want to use @internal_li
        /// nk(horizon.platform.asset_file.models.AssetFileDeleteResult#asset_file_id),
        /// you need to use @internal_link(horizon.platform.asset_file.models.AssetFile
        /// DeleteResult#asset_id) instead. It can be retrieved using
        /// @internal_link(horizon.platform.asset_file.models.AssetDetails#asset_id).
        [JsonProperty("asset_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 AssetId { get; set; }
        /// File path of the asset file.
        [JsonProperty("filepath")]
        [Preserve]
        public string Filepath { get; set; }
        /// You can use this to determine whether deleting an asset file was successful
        /// or not.
        [JsonProperty("success")]
        [Preserve]
        public bool Success { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
