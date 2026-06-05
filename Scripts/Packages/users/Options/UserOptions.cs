// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<1b14ba9a486bb7074d57723fe19fe2be>>
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
    /// The user_options configuration is used to specify additional settings for
    /// the @internal_link(horizon.platform.users.models.User). It allows you to
    /// customize the response by specifying the time window, maximum number of
    /// users, and service providers for which linked accounts should be retrieved.
    [Serializable]
    [Preserve]
    public class UserOptions {
        /// This field specifies the maximum number of
        /// @internal_link(horizon.platform.users.models.User) that should be returned
        /// in the response.
        [JsonProperty("max_users")]
        [Preserve]
        public uint MaxUsers;
        /// It's an array of
        /// @internal_link(horizon.platform.users.enums.ServiceProvider) objects that
        /// specifies the service providers for which linked accounts should be
        /// retrieved.
        [JsonProperty("service_providers")]
        [JsonConverter(typeof(EnumArrayDescriptionConverter<ServiceProvider>))]
        [Preserve]
        public ServiceProvider[] ServiceProviders;
        /// This field specifies the time window in seconds for which the linked
        /// accounts should be retrieved.
        [JsonProperty("time_window")]
        [JsonConverter(typeof(EnumDescriptionConverter<TimeWindow>))]
        [Preserve]
        public TimeWindow TimeWindow = TimeWindow.Unknown;
        
        public string Json => JsonUtility.ToJson(this);

        [Preserve]
        public UserOptions()
        {
        }
        
        [Preserve]
        public void SetMaxUsers(uint value)
        {
            MaxUsers = value;
        }
        
        [Preserve]
        public void SetServiceProviders(ServiceProvider[] value)
        {
            ServiceProviders = value;
        }
        /// Adds a single item to the ServiceProviders list. This method is provided for backward compatibility.
        [Preserve]
        public void AddServiceProvider(ServiceProvider value)
        {
            var list = ServiceProviders != null
                ? new List<ServiceProvider>(ServiceProviders)
                : new List<ServiceProvider>();
            list.Add(value);
            ServiceProviders = list.ToArray();
        }

        /// Clears the ServiceProviders list. This method is provided for backward compatibility.
        [Preserve]
        public void ClearServiceProviders()
        {
            ServiceProviders = null;
        }
        
        
        [Preserve]
        public void SetTimeWindow(TimeWindow value)
        {
            TimeWindow = value;
        }
        
        ~UserOptions()
        {
        }
    }
}
