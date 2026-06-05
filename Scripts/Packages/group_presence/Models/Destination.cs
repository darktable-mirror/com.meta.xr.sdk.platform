// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<20e9205e59276738c81e73385be78386>>
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

    /// The destination represents where the user would like to go to in the app.
    /// It's usually associated with a travel or an invitation. Each destination
    /// has @internal_link(horizon.platform.group_presence.models.Destination#api_n
    /// ame), @internal_link(horizon.platform.group_presence.models.Destination#dis
    /// play_name), @internal_link(horizon.platform.group_presence.models.Destinati
    /// on#deeplink_message) and @internal_link(horizon.platform.group_presence.mod
    /// els.Destination#shareable_uri) link. Please refer to member data
    /// documentation for details.
    [Preserve]
    public class Destination
    {
        /// You can pass it into @internal_link(horizon.platform.group_presence.options
        /// .GroupPresenceOptions#destination_api_name) when calling @internal_link(hor
        /// izon.platform.group_presence.GroupPresence#set(GroupPresenceOptions)) to
        /// set this user's group presence.
        [JsonProperty("api_name")]
        [Preserve]
        public string ApiName { get; set; }
        /// The information that will be in @internal_link(horizon.platform.application
        /// _lifecycle.models.LaunchDetails#deeplink_message) when a user enters via a
        /// deeplink. Alternatively will be in @internal_link(horizon.platform.users.mo
        /// dels.User#presence_deeplink_message) if the group presence is set for the
        /// user.
        [JsonProperty("deeplink_message")]
        [Preserve]
        public string DeeplinkMessage { get; set; }
        /// A displayable string of the destination name and it can be retrieved with @
        /// internal_link(horizon.platform.group_presence.models.Destination#display_na
        /// me).
        [JsonProperty("display_name")]
        [Preserve]
        public string DisplayName { get; set; }
        /// A URI that allows the user to deeplink directly to this destination
        [JsonProperty("shareable_uri")]
        [Preserve]
        public string ShareableUri { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of Destination elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class DestinationList : DeserializableList<Destination>
    {
    }
}
