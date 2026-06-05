// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<3022cedde31b4d37e4546aa8d25107e6>>
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

    /// The notification about updating a party status information to a
    /// participating user. Party Notifications are intended to update the user on
    /// various actions that are occurring in the user's party. It can be retrieved
    /// using @internal_link(horizon.platform.parties.Parties#party_update()).
    [Preserve]
    public class PartyUpdateNotification
    {
        /// An enum that specifies the type of action related to the party and user
        /// that this notification holds.
        /// @internal_link(horizon.platform.parties.enums.PartyUpdateAction#join): The
        /// user joined the party.
        /// @internal_link(horizon.platform.parties.enums.PartyUpdateAction#leave): The
        /// user left the party.
        /// @internal_link(horizon.platform.parties.enums.PartyUpdateAction#invite):
        /// The user was invited to the party.
        /// @internal_link(horizon.platform.parties.enums.PartyUpdateAction#uninvite):
        /// The user was uninvited to the party.
        [JsonProperty("action")]
        [JsonConverter(typeof(EnumDescriptionConverter<PartyUpdateAction>))]
        [Preserve]
        public PartyUpdateAction Action { get; set; }
        /// The ID of the party that will be updated. This can be retrieved with
        /// @internal_link(horizon.platform.parties.models.PartyID).
        [JsonProperty("party_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 PartyId { get; set; }
        /// The id of the @internal_link(horizon.platform.users.models.User) who
        /// initiated the action that this party update status notification is in
        /// reference to. This is equivalent to
        /// @internal_link(horizon.platform.users.models.User#id) for this user.
        [JsonProperty("sender_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 SenderId { get; set; }
        /// A timestamp denoting when the party action occurred that this status update
        /// notification refers to.
        [JsonProperty("update_timestamp")]
        [Preserve]
        public string UpdateTimestamp { get; set; }
        /// The alias of the @internal_link(horizon.platform.users.models.User) whose
        /// party status has changed. This is an alias that is set by the user.
        [JsonProperty("user_alias")]
        [Preserve]
        public string UserAlias { get; set; }
        /// The ID of the user, @internal_link(horizon.platform.users.models.User#id),
        /// whose party status has changed. This is a unique value for every
        /// @internal_link(horizon.platform.users.models.User).
        [JsonProperty("user_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 UserId { get; set; }
        /// The displayable name of the
        /// @internal_link(horizon.platform.users.models.User) whose party status has
        /// changed. This is equivalent to
        /// @internal_link(horizon.platform.users.models.User#display_name) for this
        /// user.
        [JsonProperty("user_name")]
        [Preserve]
        public string UserName { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
