// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<5ad3e89bfdb0068fcc5f7c4838356566>>
 */

#pragma warning disable 0618

namespace Oculus.Platform.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using UnityEngine.Scripting;

    /// Details about the launch of the appplication. It can be used to check if
    /// your app is being launched using App to App Travel. It can be retrieved
    /// using @internal_link(horizon.platform.application_lifecycle.ApplicationLife
    /// cycle#get_launch_details()).
    [Preserve]
    public class LaunchDetails
    {
        /// An opaque string provided by the developer to help them deeplink to content
        /// on app startup.
        [JsonProperty("deeplink_message")]
        [Preserve]
        public string DeeplinkMessage { get; set; }
        /// If provided, the intended destination the user would like to go to
        [JsonProperty("destination_api_name")]
        [Preserve]
        public string DestinationApiName { get; set; }
        /// A string typically used to distinguish where the deeplink came from. For
        /// instance, a DEEPLINK launch type could be coming from events or rich
        /// presence.
        [JsonProperty("launch_source")]
        [Preserve]
        public string LaunchSource { get; set; }
        /// A @internal_link(horizon.platform.application_lifecycle.enums.LaunchType)
        /// that defines the different ways in which an application can be launched. @i
        /// nternal_link(horizon.platform.application_lifecycle.enums.LaunchType#normal
        /// ) - Normal launch from the user's library. @internal_link(horizon.platform.
        /// application_lifecycle.enums.LaunchType#invite) - Launch from the user
        /// accepting an invite. @internal_link(horizon.platform.application_lifecycle.
        /// enums.LaunchType#deeplink) - Launched from a deeplink. This flow is
        /// typically kicked off from @internal_link(horizon.platform.application.Appli
        /// cation#launch_other_app(ID, ApplicationOptions))
        [JsonProperty("type")]
        [JsonConverter(typeof(EnumDescriptionConverter<LaunchType>))]
        [Preserve]
        public LaunchType LaunchType { get; set; }
        /// If provided, the intended lobby the user would like to be in
        [JsonProperty("lobby_session_id")]
        [Preserve]
        public string LobbySessionID { get; set; }
        /// If provided, the intended session the user would like to be in
        [JsonProperty("match_session_id")]
        [Preserve]
        public string MatchSessionID { get; set; }
        /// A unique identifier to keep track of a user going through the deeplinking
        /// flow
        [JsonProperty("tracking_id")]
        [Preserve]
        public string TrackingID { get; set; }
        /// If provided, the intended users the user would like to be with
        [JsonProperty("users")]
        // May be null. Check before using.
        [Preserve]
        public UserList UsersOptional { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
