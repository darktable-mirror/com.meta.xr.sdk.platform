// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<715366c5d2611b61d73dbe21ca1955e4>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class Media
    {
        /// Launch the Share to Facebook modal, allowing users to share local media
        /// files to Facebook. Accepts a postTextSuggestion string for the default text
        /// of the Facebook post. Requires a filePath string as the path to the image
        /// to be shared to Facebook. This image should be located in your app's
        /// internal storage directory. Requires a contentType indicating the type of
        /// media to be shared (only 'photo' is currently supported). The payload for
        /// the result is defined as
        /// @internal_link(horizon.platform.media.models.ShareMediaResult).
        public static Request<ShareMediaResult> ShareToFacebook(string postTextSuggestion, string filePath, MediaContentType contentType)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "post_text_suggestion", postTextSuggestion },
                    { "file_path", filePath },
                    { "content_type", contentType.GetDescription() }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("media", "share_to_facebook", 1, jsonRequest, 0);
                return new Request<ShareMediaResult>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        
    }
}
