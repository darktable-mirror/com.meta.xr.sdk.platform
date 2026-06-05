// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<d6fd2d414871e0aa95b4f41ff00c2721>>
 */

using System;
using System.Collections;
using Oculus.Platform.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;
using UnityEngine.Scripting;

namespace Oculus.Platform
{
    /// The Abuse Report Options provide a way for developers to customize the
    /// reporting flow and specify the type of content being reported, which can be
    /// either a
    /// @internal_link(horizon.platform.abuse_report.enums.AbuseReportType#user) or
    /// an
    /// @internal_link(horizon.platform.abuse_report.enums.AbuseReportType#object),
    /// helping to maintain a safe and respectful community within their
    /// application.
    [Serializable]
    [Preserve]
    public class AbuseReportOptions {
        /// Set whether or not to show the user selection step. If the reported object
        /// is a user, they can choose to block the reported user from further
        /// interactions within the platform.
        [JsonProperty("prevent_people_chooser")]
        [Preserve]
        public bool PreventPeopleChooser;
        /// The intended entity type
        /// @internal_link(horizon.platform.abuse_report.enums.AbuseReportType) being
        /// reported, it can be either a user
        /// @internal_link(horizon.platform.abuse_report.enums.AbuseReportType#user) or
        /// an object/content
        /// @internal_link(horizon.platform.abuse_report.enums.AbuseReportType#object).
        [JsonProperty("report_type")]
        [JsonConverter(typeof(EnumDescriptionConverter<AbuseReportType>))]
        [Preserve]
        public AbuseReportType ReportType = AbuseReportType.Unknown;
        
        public string Json => JsonUtility.ToJson(this);

        [Preserve]
        public AbuseReportOptions()
        {
        }
        
        [Preserve]
        public void SetPreventPeopleChooser(bool value)
        {
            PreventPeopleChooser = value;
        }
        
        [Preserve]
        public void SetReportType(AbuseReportType value)
        {
            ReportType = value;
        }
        
        ~AbuseReportOptions()
        {
        }
    }
}
