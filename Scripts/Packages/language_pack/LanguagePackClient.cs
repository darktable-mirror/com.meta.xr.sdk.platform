// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<3e7a4d35dcf936af3390b21533cc527c>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class LanguagePack
    {
        /// Returns currently installed and selected language pack for an app in the
        /// view of the
        /// @internal_link(horizon.platform.asset_file.models.AssetDetails). Use
        /// @internal_link(horizon.platform.asset_file.models.AssetDetails#language)
        /// field to extract needed language info. A particular language can be
        /// download and installed by a user from the Oculus app on the application
        /// page.
        public static Request<AssetDetails> GetCurrent()
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("language_pack", "get_current", 1, jsonRequest, 0);
                return new Request<AssetDetails>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Sets the current language to specified. The parameter is the BCP47 language
        /// tag. If a language pack is not downloaded yet, spawns automatically the @in
        /// ternal_link(horizon.platform.asset_file.AssetFile#download_by_name(String))
        /// request, and sends periodic
        /// @internal_link(horizon.platform.asset_file.AssetFile#download_update()) to
        /// track the downloads. Once the language asset file is downloaded, call
        /// @internal_link(horizon.platform.language_pack.LanguagePack#get_current())
        /// to retrieve the data, and use the language at runtime.
        public static Request<AssetFileDownloadResult> SetCurrent(string tag)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "tag", tag }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("language_pack", "set_current", 1, jsonRequest, 0);
                return new Request<AssetFileDownloadResult>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        
    }
}
