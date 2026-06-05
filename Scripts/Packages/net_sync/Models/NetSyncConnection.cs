// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<652a7aaf7155632d601b96af20bd740e>>
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

    /// It represents the connection of a network synchronization system that
    /// allows multiple clients to connect and communicate with each other in real-
    /// time. It provides a way to manage and facilitate real-time communication
    /// and data synchronization between multiple clients in a networked
    /// environment.
    [Preserve]
    public class NetSyncConnection
    {
        /// A 'long' integer ID which can be used to uniquely identify the network
        /// synchronization connection.
        [JsonProperty("connection_id")]
        [Preserve]
        public long ConnectionId { get; set; }
        /// If the status is @internal_link(horizon.platform.net_sync.enums.NetSyncConn
        /// ectionStatus#disconnected),
        /// @internal_link(horizon.platform.net_sync.enums.NetSyncDisconnectReason)
        /// specifies the reason. @internal_link(horizon.platform.net_sync.enums.NetSyn
        /// cDisconnectReason#unknown) - The disconnect reason was unknown. @internal_l
        /// ink(horizon.platform.net_sync.enums.NetSyncDisconnectReason#local_terminate
        /// d) - The disconnect was requested by an user. @internal_link(horizon.platfo
        /// rm.net_sync.enums.NetSyncDisconnectReason#server_terminated) - The server
        /// closed the connection. @internal_link(horizon.platform.net_sync.enums.NetSy
        /// ncDisconnectReason#failed) - The initial connection never succeeded. @inter
        /// nal_link(horizon.platform.net_sync.enums.NetSyncDisconnectReason#lost) -
        /// The disconnect was caused by network timeout.
        [JsonProperty("disconnect_reason")]
        [Preserve]
        public NetSyncDisconnectReason DisconnectReason { get; set; }
        /// The ID of the local session. Will be null if the connection is not active.
        [JsonProperty("session_id")]
        [JsonConverter(typeof(UInt64EmptyStringConverter))]
        [Preserve]
        public UInt64 SessionId { get; set; }
        /// A @internal_link(horizon.platform.net_sync.enums.NetSyncConnectionStatus)
        /// that defines the different status of the network synchronization
        /// connection. @internal_link(horizon.platform.net_sync.enums.NetSyncConnectio
        /// nStatus#unknown) - The current connection status is unknown. @internal_link
        /// (horizon.platform.net_sync.enums.NetSyncConnectionStatus#connecting) - The
        /// connection has been started and the process is ongoing. @internal_link(hori
        /// zon.platform.net_sync.enums.NetSyncConnectionStatus#disconnected) - The
        /// current connection status is disconnected. @internal_link(horizon.platform.
        /// net_sync.enums.NetSyncConnectionStatus#connected) - The connection has been
        /// established.
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumDescriptionConverter<NetSyncConnectionStatus>))]
        [Preserve]
        public NetSyncConnectionStatus Status { get; set; }
        /// A `string` represents the unique identifier within the current application
        /// grouping.
        [JsonProperty("zone_id")]
        [Preserve]
        public string ZoneId { get; set; }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
    
}
