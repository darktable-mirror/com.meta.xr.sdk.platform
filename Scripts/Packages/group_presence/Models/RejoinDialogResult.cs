// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<49311343f6045c4ce8002c1472aee53e>>
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

    /// A boolean that indicates the result of @internal_link(horizon.platform.grou
    /// p_presence.GroupPresence#launch_rejoin_dialog(String, String, String)).
    /// 'True' indicates that the application will rejoin the dialog, otherwise the
    /// application will not rejoin the dialog. Read more about the [rejoin dialog]
    /// (https://developer.oculus.com/documentation/{{platform_doc_path}}/ps-
    /// rejoin/#rejoin-apis).
    [Preserve]
    public class RejoinDialogResult
    {
        /// A boolean for if the user has decided to rejoin. This is used in @internal_
        /// link(horizon.platform.group_presence.GroupPresence#launch_rejoin_dialog(Str
        /// ing, String, String)).
        [JsonProperty("rejoin_selected")]
        [Preserve]
        public bool RejoinSelected { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
