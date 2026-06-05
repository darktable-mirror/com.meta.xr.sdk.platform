// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<d27f75faea9fe7fdc772a8f3907997d9>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class ApplicationLifecycle
    {
        /// This event is triggered when a launch intent is received, whether it's a
        /// cold or warm start. The payload contains the type of intent that was
        /// received. To obtain additional details, you should call the @internal_link(
        /// horizon.platform.application_lifecycle.ApplicationLifecycle#get_launch_deta
        /// ils()) function.
        
        public static void SetLaunchIntentChangedNotificationCallback(Message<String>.Callback callback)
        {
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new { });
                ulong sessionId = PlatformClient.MakeSession("application_lifecycle", "launch_intent_changed", 1, jsonRequest, 0);
                Callback.SetNotificationCallback<String>(sessionId, callback);
            }
            else
            {
                Debug.LogError(Core.PlatformUninitializedError);
            }
        }

        /// Returns information about how the application was started. This function
        /// provides details about the launch intent, such as the type of intent @inter
        /// nal_link(horizon.platform.application_lifecycle.models.LaunchDetails#launch
        /// _type) and any additional data that was passed along with it. By calling
        /// this function, you can gain insight into how your application was launched
        /// and take appropriate action based on that information.
        public static Request<LaunchDetails> GetLaunchDetailsRequest()
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

                ulong requestHandle = PlatformClient.MakeRequest("application_lifecycle", "get_launch_details", 1, jsonRequest, 0);
                return new Request<LaunchDetails>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Logs if the user successfully deeplinked to a destination. This function
        /// takes two parameters: a string tracking ID and a launch result. The
        /// tracking ID is used to identify the specific deeplink attempt, while the
        /// launch result indicates whether the deeplink was @internal_link(horizon.pla
        /// tform.application_lifecycle.enums.LaunchResult#success) or not. By logging
        /// this information, you can track the effectiveness of your deeplinking
        /// efforts and make adjustments as needed.
        public static Request LogDeeplinkResultRequest(string trackingId, LaunchResult result)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "tracking_id", trackingId },
                    { "result", result.GetDescription() }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("application_lifecycle", "log_deeplink_result", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        
    }
}
