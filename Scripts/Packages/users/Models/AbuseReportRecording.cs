// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<4846c5fe22788ec87c933375b59ed26b>>
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

    /// A video recording evidence that can be used to collect video evidence when
    /// reporting abusive behavior or content within a platform. More details are
    /// available in our [User Reporting Service Virtual Reality Check
    /// guideline](https://developer.oculus.com/resources/reporting-service/)
    [Preserve]
    public class AbuseReportRecording
    {
        /// A unique UUID associated with the Abuse Report recording. It can be
        /// retrieved using @internal_link(horizon.platform.abuse_report.models.LaunchR
        /// eportFlowResult#user_report_id)
        [JsonProperty("recording_uuid")]
        [Preserve]
        public string RecordingUuid { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
