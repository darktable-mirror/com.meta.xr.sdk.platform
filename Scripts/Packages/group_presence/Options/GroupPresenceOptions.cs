// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<43190df3e0796c35edcadee7ec6a5c4d>>
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
    /// The Group Presence Option, to be passed in to @internal_link(horizon.platfo
    /// rm.group_presence.GroupPresence#set(GroupPresenceOptions)), is a set of
    /// fields that allows developers to specify the presence of a user in a
    /// group/squad/party. It provides a way for developers to create a more
    /// immersive and social experience for their users by allowing them to join
    /// and interact with other users.
    [Serializable]
    [Preserve]
    public class GroupPresenceOptions {
        /// Use @internal_link(horizon.platform.group_presence.options.GroupPresenceOpt
        /// ions#lobby_session_id) or @internal_link(horizon.platform.group_presence.op
        /// tions.GroupPresenceOptions#match_session_id) to specify the session. Use
        /// the deeplink message override for any additional data in whatever format
        /// you wish to aid in bringing users together. If not specified, the
        /// deeplink_message for the user will default to the one on the destination.
        [JsonProperty("deeplink_message_override")]
        [Preserve]
        public string DeeplinkMessageOverride = "";
        /// This the unique API Name that refers to an in-app destination
        [JsonProperty("destination_api_name")]
        [Preserve]
        public string DestinationApiName = "";
        /// Set whether or not the person is shown as joinable or not to others.  A
        /// user that is joinable can invite others to join them. Set this to false if
        /// other users would not be able to join this user. For example: the current
        /// session is full, or only the host can invite others and the current user is
        /// not the host.
        [JsonProperty("is_joinable")]
        [Preserve]
        public bool IsJoinable = false;
        /// This is a session that represents a closer group/squad/party of users. It
        /// is expected that all users with the same lobby session id can see or hear
        /// each other. Users with the same lobby session id in their group presence
        /// will show up in the roster and will show up as "Recently Played With" for
        /// future invites if they aren't already Oculus friends. This must be set in
        /// addition to is_joinable being true for a user to use invites.
        [JsonProperty("lobby_session_id")]
        [Preserve]
        public string LobbySessionId = "";
        /// This is a session that represents all the users that are playing a specific
        /// instance of a map, game mode, round, etc. This can include users from
        /// multiple different lobbies that joined together and the users may or may
        /// not remain together after the match is over. Users with the same match
        /// session id in their group presence will not show up in the Roster, but will
        /// show up as "Recently Played with" for future invites.
        [JsonProperty("match_session_id")]
        [Preserve]
        public string MatchSessionId = "";
        
        public string Json => JsonUtility.ToJson(this);

        [Preserve]
        public GroupPresenceOptions()
        {
        }
        
        [Preserve]
        public void SetDeeplinkMessageOverride(string value)
        {
            DeeplinkMessageOverride = value;
        }
        
        [Preserve]
        public void SetDestinationApiName(string value)
        {
            DestinationApiName = value;
        }
        
        [Preserve]
        public void SetIsJoinable(bool value)
        {
            IsJoinable = value;
        }
        
        [Preserve]
        public void SetLobbySessionId(string value)
        {
            LobbySessionId = value;
        }
        
        [Preserve]
        public void SetMatchSessionId(string value)
        {
            MatchSessionId = value;
        }
        
        ~GroupPresenceOptions()
        {
        }
    }
}
