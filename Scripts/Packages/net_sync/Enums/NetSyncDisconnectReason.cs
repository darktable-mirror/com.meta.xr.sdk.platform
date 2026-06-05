// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<d0c7d1e7d3b7c51c0df4c7e3adcdacb3>>
 */

namespace Oculus.Platform
{

    using Description = System.ComponentModel.DescriptionAttribute;
    using UnityEngine.Scripting;

    /// It represents the possible reasons why the status of a
    /// @internal_link(horizon.platform.net_sync.models.NetSyncConnection), which
    /// allows multiple clients to connect and communicate with each other in real-
    /// time, is disconnected. The connection provides a way to manage and
    /// facilitate real-time communication and data synchronization between
    /// multiple clients in a networked environment.
    [Preserve]
    public enum NetSyncDisconnectReason : int
    {
        /// Represents that the NetSyncDisconnectReason is unknown.
        [Description("UNKNOWN")]
        [Preserve]
        Unknown,

        /// This member indicates that the disconnect of the
        /// @internal_link(horizon.platform.net_sync.models.NetSyncConnection) was
        /// initialized from the a user request.
        [Description("LOCAL_TERMINATED")]
        [Preserve]
        LocalTerminated,

        /// This member indicates that the connection of the
        /// @internal_link(horizon.platform.net_sync.models.NetSyncConnection) was
        /// shutdown by the server intentionally.
        [Description("SERVER_TERMINATED")]
        [Preserve]
        ServerTerminated,

        /// This member indicates that the initial connection request never succeeded.
        [Description("FAILED")]
        [Preserve]
        Failed,

        /// This member indicates that the
        /// @internal_link(horizon.platform.net_sync.models.NetSyncConnection) was
        /// shutdown because of the network timeout.
        [Description("LOST")]
        [Preserve]
        Lost,

        
    }

}
