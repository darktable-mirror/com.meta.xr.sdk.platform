// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<f59e39bcb44d80c1c3e31d1be470edd3>>
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

    /// Represents the result of the download of an application. You can retrieve
    /// it using CheckAppDownloadProgress API (@internal_link(horizon.platform.appl
    /// ication.Application#check_app_download_progress())). You can use this to
    /// check the progress and the status of an ongoing app download operation.
    [Preserve]
    public class AppDownloadProgressResult
    {
        /// Total number of bytes that need to be downloaded
        [JsonProperty("downloadSizeBytes")]
        [Preserve]
        public long DownloadBytes { get; set; }
        /// Number of bytes that have already been downloaded. You can use this and @in
        /// ternal_link(horizon.platform.application.models.AppDownloadProgressResult#d
        /// ownload_bytes) to implement the progress bar.
        [JsonProperty("downloadedSizeBytes")]
        [Preserve]
        public long DownloadedBytes { get; set; }
        /// Status code of the current app status. You can use it to find out whether
        /// the app is being downloaded or queued for downloading
        [JsonProperty("statusCode")]
        [JsonConverter(typeof(EnumDescriptionConverter<AppStatus>))]
        [Preserve]
        public AppStatus StatusCode { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
