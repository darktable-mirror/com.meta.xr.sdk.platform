// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<7d892456e7e3d3baac6e3765d972bd94>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// It represents the possible status of a
    /// @internal_link(horizon.platform.net_sync.models.NetSyncConnection) which
    /// allows multiple clients to connect and communicate with each other in real-
    /// time. The connection provides a way to manage and facilitate real-time
    /// communication and data synchronization between multiple clients in a
    /// networked environment.
    [Preserve]
    public enum NetSyncConnectionStatus : int
    {
        /// Represents that the NetSyncConnectionStatus is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// This member indicates that the connection of the network sync has been
        /// started and the process is ongoing.
        [Description("CONNECTING")]
        [Preserve]
        Connecting,

        /// This member indicates that the current status of the network sync
        /// connection is not connected.
        [Description("DISCONNECTED")]
        [Preserve]
        Disconnected,

        /// This member indicates that the current status of the network sync
        /// connection is connected.
        [Description("CONNECTED")]
        [Preserve]
        Connected,

        
    }

}
