// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<cfaf01582b5d5213cdb6c288e3f5affe>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class Avatar
    {
        /// Launches the Avatar Editor. Meta Avatars Editor is a feature that allows
        /// users to edit their Meta Avatars appearances within the VR application that
        /// they are currently using. This experience is often used by users to switch
        /// their outfit and accessories to better suit the VR experience they are
        /// experiencing. The result can be retrieved by @internal_link(horizon.platfor
        /// m.avatar.models.AvatarEditorResult#request_sent).
        public static Request<AvatarEditorResult> LaunchAvatarEditor(AvatarEditorOptions options = null)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "options", options }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("avatar", "launch_avatar_editor", 1, jsonRequest, 0);
                return new Request<AvatarEditorResult>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        
    }
}
