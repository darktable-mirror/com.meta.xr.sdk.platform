// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<0e048fe834605de9023c5ac8e6f4c9b1>>
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
    /// The multiplayer error option is a feature that allows developers to display
    /// general error messages to
    /// @internal_link(horizon.platform.users.models.User) in invokable error
    /// dialogs. This option is particularly useful in multiplayer games or
    /// applications where errors can occur due to various reasons such as network
    /// connectivity issues, server downtime, or other technical problems. Read
    /// more about error dialogues in our
    /// [docs](https://developer.oculus.com/documentation/{{platform_doc_path}}/ps-
    /// error-dialogs/).
    [Serializable]
    [Preserve]
    public class MultiplayerErrorOptions {
        /// Key associated with the predefined error message to be shown to users. Key
        /// List: - @internal_link(horizon.platform.group_presence.enums.MultiplayerErr
        /// orErrorKey#destination_unavailable) - @internal_link(horizon.platform.group
        /// _presence.enums.MultiplayerErrorErrorKey#dlc_required) - @internal_link(hor
        /// izon.platform.group_presence.enums.MultiplayerErrorErrorKey#general) - @int
        /// ernal_link(horizon.platform.group_presence.enums.MultiplayerErrorErrorKey#g
        /// roup_full) - @internal_link(horizon.platform.group_presence.enums.Multiplay
        /// erErrorErrorKey#inviter_not_joinable) - @internal_link(horizon.platform.gro
        /// up_presence.enums.MultiplayerErrorErrorKey#level_not_high_enough) - @intern
        /// al_link(horizon.platform.group_presence.enums.MultiplayerErrorErrorKey#leve
        /// l_not_unlocked) - @internal_link(horizon.platform.group_presence.enums.Mult
        /// iplayerErrorErrorKey#network_timeout) - @internal_link(horizon.platform.gro
        /// up_presence.enums.MultiplayerErrorErrorKey#no_longer_available) - @internal
        /// _link(horizon.platform.group_presence.enums.MultiplayerErrorErrorKey#update
        /// _required) - @internal_link(horizon.platform.group_presence.enums.Multiplay
        /// erErrorErrorKey#tutorial_required)
        [JsonProperty("error_key")]
        [JsonConverter(typeof(EnumDescriptionConverter<MultiplayerErrorErrorKey>))]
        [Preserve]
        public MultiplayerErrorErrorKey ErrorKey = MultiplayerErrorErrorKey.Unknown;
        
        public string Json => JsonUtility.ToJson(this);

        [Preserve]
        public MultiplayerErrorOptions()
        {
        }
        
        [Preserve]
        public void SetErrorKey(MultiplayerErrorErrorKey value)
        {
            ErrorKey = value;
        }
        
        ~MultiplayerErrorOptions()
        {
        }
    }
}
