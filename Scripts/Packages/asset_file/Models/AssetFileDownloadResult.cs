// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<fdbd81a32add0c8f00bd2b26437abc12>>
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

    /// An AssetFileDownloadResult represents an asset that has been successfully
    /// downloaded. It's used to store information about an asset that has been
    /// downloaded, such as its location on the local file system and its unique
    /// identifier asset file ID. It can be retrieved using @internal_link(horizon.
    /// platform.asset_file.AssetFile#download_by_name(String)).
    [Preserve]
    public class AssetFileDownloadResult
    {
        /// ID of the asset file. It can be retrieved using
        /// @internal_link(horizon.platform.asset_file.models.AssetDetails#asset_id).
        /// It can be used to retrieve the AssetFileDownloadResult by
        /// @internal_link(horizon.platform.asset_file.AssetFile#download_by_id(ID)).
        [JsonProperty("asset_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 AssetId { get; set; }
        /// File path of the asset file.
        [JsonProperty("filepath")]
        [Preserve]
        public string Filepath { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
