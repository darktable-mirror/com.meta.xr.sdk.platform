// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<6be2fd12344e6617c67789acf5db87fd>>
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

    /// This object represents a permission or capability for the logged in user,
    /// which can be retrieved by
    /// @internal_link(horizon.platform.users.Users#get_logged_in_user()). It's a
    /// type of array and there is a unique name for every user capability.
    [Preserve]
    public class UserCapability
    {
        /// The human readable description of the capability describing what possessing
        /// it entails for a given @internal_link(horizon.platform.users.models.User).
        [JsonProperty("description")]
        [Preserve]
        public string Description { get; set; }
        /// Whether the capability is currently enabled for the user. When false, this
        /// field will gate the @internal_link(horizon.platform.users.models.User) from
        /// the specified services.
        [JsonProperty("is_enabled")]
        [Preserve]
        public bool IsEnabled { get; set; }
        /// The unique identifier for the capability. An example capability could be
        /// "earn_achievements".
        [JsonProperty("name")]
        [Preserve]
        public string Name { get; set; }
        /// This field specifies the reason the capability was enabled or disabled for
        /// the given @internal_link(horizon.platform.users.models.User). List of
        /// Reason Codes: - REASON_UNKOWN - SOCIAL_DISTANCING - VERBAL_ABUSE -
        /// TEXT_ABUSE - PARENTAL_CONTROL - DEVELOPER_ACTION - SALSA_RESTRICTION -
        /// SOCIAL_SUSPENSION - PAYMENT_SUSPENSION - PAYMENT_GIFTING_SUSPENSION
        [JsonProperty("reason_code")]
        [Preserve]
        public string ReasonCode { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
    /// Represents a paginated list of UserCapability elements. It allows you to
    /// easily access and manipulate the elements in the paginated list, such as
    /// the size of the list and if there is a next page of elements available.
    [Preserve]
    public class UserCapabilityList : DeserializableList<UserCapability>
    {
    }
}
