// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<c71358c1d492b55be9feb2bf1de31d2a>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class Analytics
    {
        /// Send the analytics metric event with details fill into
        /// AnalyticsMetricEvent. See details on
        /// @internal_link(horizon.platform.analytics.options.AnalyticsMetricEvent).
        public static Request SendMetricEvent(AnalyticsMetricEvent analyticsMetricEvent)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "analytics_metric_event", analyticsMetricEvent }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("analytics", "send_metric_event", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Send the analytics segment event with details fill into
        /// AnalyticsSegmentEvent. See details on
        /// @internal_link(horizon.platform.analytics.options.AnalyticsSegmentEvent).
        public static Request SendSegmentEvent(AnalyticsSegmentEvent analyticsSegmentEvent)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "analytics_segment_event", analyticsSegmentEvent }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("analytics", "send_segment_event", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        
    }
}
