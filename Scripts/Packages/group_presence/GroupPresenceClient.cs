// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<66793cf0f76bf83d9ec104cf936291e3>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class GroupPresence
    {
        /// Clears the current group presence settings for your app. Use this when a
        /// user's group presence setting in your app needs to be changed when moving
        /// to new destinations in your app.
        public static Request Clear()
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "clear", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Returns a list of users that can be invited to your current lobby. These
        /// are pulled from your bidirectional followers and recently met lists.
        public static Request<UserList> GetInvitableUsers(InviteOptions options)
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_invitable_users", 1, jsonRequest, 0);
                return new Request<UserList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Get the application invites which have been sent by the user.
        public static Request<ApplicationInviteList> GetSentInvites()
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_sent_invites", 1, jsonRequest, 0);
                return new Request<ApplicationInviteList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Launches the system invite dialog with a roster of eligible users for the
        /// current user to invite to the app. It is recommended that you surface a
        /// button in your UI that triggers this dialog when a user is joinable.
        public static Request<InvitePanelResultInfo> LaunchInvitePanel(InviteOptions options)
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "launch_invite_panel", 1, jsonRequest, 0);
                return new Request<InvitePanelResultInfo>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Launch an error dialog window with predefined messages for commonly
        /// occurring multiplayer errors. Check the Invokable Error Dialogs
        /// documentation for more information about these error messages and their
        /// values.
        public static Request LaunchMultiplayerErrorDialog(MultiplayerErrorOptions options)
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "launch_multiplayer_error_dialog", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Launch the dialog allowing users to rejoin a previous lobby or match.
        /// Either the user's @internal_link(horizon.platform.group_presence.options.Gr
        /// oupPresenceOptions#lobby_session_id), their @internal_link(horizon.platform
        /// .group_presence.options.GroupPresenceOptions#match_session_id), or both
        /// must be populated as valid rejoinable destinations. Check the Rejoin
        /// documentation for use cases and information on this feature.
        public static Request<RejoinDialogResult> LaunchRejoinDialog(string lobby_session_id, string match_session_id, string destination_api_name)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "lobby_session_id", lobby_session_id },
                    { "match_session_id", match_session_id },
                    { "destination_api_name", destination_api_name }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "launch_rejoin_dialog", 1, jsonRequest, 0);
                return new Request<RejoinDialogResult>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Launch the panel displaying the current users in the roster. We do not
        /// recommend using this API because the list current users is surfaced in the
        /// Destination UI when the Meta Quest button is pressed.
        public static Request LaunchRosterPanel(RosterOptions options)
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "launch_roster_panel", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Sends invites to the current application to the list of userIDs passed in.
        /// You can fetch a list of users to pass in via the @internal_link(horizon.pla
        /// tform.group_presence.GroupPresence#get_invitable_users(InviteOptions)).
        /// This API works as an alternative to @internal_link(horizon.platform.group_p
        /// resence.GroupPresence#launch_invite_panel(InviteOptions)) which delegates
        /// the invite flow to the system invite module. @internal_link(horizon.platfor
        /// m.group_presence.GroupPresence#launch_invite_panel(InviteOptions)) is the
        /// recommended approach.
        public static Request<SendInvitesResult> SendInvites(UInt64[] userIds)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "user_ids", Array.ConvertAll(userIds, id => id.ToString()) }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "send_invites", 1, jsonRequest, 0);
                return new Request<SendInvitesResult>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Sets group presence information for your current app. It is recommended
        /// that you use this parameter and its methods to set group presence
        /// information for your app. An example of using this parameter can be found
        /// on the Group Presence overview page where the methods to set @internal_link
        /// (horizon.platform.group_presence.options.GroupPresenceOptions#destination_a
        /// pi_name), @internal_link(horizon.platform.group_presence.options.GroupPrese
        /// nceOptions#match_session_id), and @internal_link(horizon.platform.group_pre
        /// sence.options.GroupPresenceOptions#lobby_session_id) are used.
        public static Request Set(GroupPresenceOptions groupPresenceOptions)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "group_presence_options", groupPresenceOptions }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "set", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Sets the user's @internal_link(horizon.platform.group_presence.options.Grou
        /// pPresenceOptions#deeplink_message_override) while keeping the other group
        /// presence parameters the same. If the destination of the user is not set,
        /// the deeplink message cannot be set as there's no deeplink message to
        /// override. This method does not power travel from the Meta Quest platform to
        /// your app. You must set a user's @internal_link(horizon.platform.group_prese
        /// nce.options.GroupPresenceOptions#destination_api_name), @internal_link(hori
        /// zon.platform.group_presence.options.GroupPresenceOptions#is_joinable)
        /// status, and @internal_link(horizon.platform.group_presence.options.GroupPre
        /// senceOptions#lobby_session_id) to enable travel to your app. Check Group
        /// Presence overview for more information about these values. Note: Instead of
        /// using this standalone API, we recommend setting all GroupPresence
        /// parameters in one call to @internal_link(horizon.platform.group_presence.Gr
        /// oupPresence#set(GroupPresenceOptions)).
        public static Request SetDeeplinkMessageOverride(string deeplinkMessage)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "deeplink_message", deeplinkMessage }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "set_deeplink_message_override", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Replaces the user's current @internal_link(horizon.platform.group_presence.
        /// options.GroupPresenceOptions#destination_api_name) with the provided one.
        /// Use this to set a user's current destination while keeping all the other
        /// Group Presence parameters the same. Setting a user's destination is
        /// required to enable travel from the Meta Quest Platform to your app. NOTE
        /// instead of using the standalone API, we recommend setting all GroupPresence
        /// parameters in one call to @internal_link(horizon.platform.group_presence.Gr
        /// oupPresence#set(GroupPresenceOptions)). This helps ensure that all relevant
        /// presence information is singularly updated and helps reduce presence
        /// errors.
        public static Request SetDestination(string api_name)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "api_name", api_name }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "set_destination", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Sets a user's current presence as joinable. Use this method to update a
        /// user's joinability as it changes. For example, when the game starts, the
        /// lobby becomes full, the user moves to a private, non joinable instance
        /// while keeping all other GroupPresence parameters (i.e  @internal_link(horiz
        /// on.platform.group_presence.options.GroupPresenceOptions#destination_api_nam
        /// e), @internal_link(horizon.platform.group_presence.options.GroupPresenceOpt
        /// ions#lobby_session_id), @internal_link(horizon.platform.group_presence.opti
        /// ons.GroupPresenceOptions#match_session_id)) the same. Setting a user's
        /// destination is required to enable travel from the Meta Quest Platform to
        /// your app. Note: Instead of using this individual API, we recommend setting
        /// all GroupPresence information with the @internal_link(horizon.platform.grou
        /// p_presence.GroupPresence#set(GroupPresenceOptions)) method and its
        /// associated parameters to simply managing all presence information. This
        /// helps ensure that all relevant presence information is singularly updated
        /// and helps reduce presence errors.
        public static Request SetIsJoinable(bool is_joinable)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "is_joinable", is_joinable }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "set_is_joinable", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Replaces the user's current @internal_link(horizon.platform.group_presence.
        /// options.GroupPresenceOptions#lobby_session_id) for the provided string. Use
        /// this to set a user's current lobby session id while keeping all other
        /// GroupPresence parameters the same. Setting a user's lobby session id is
        /// required to enable travel from the Meta Quest Platform to your app. Check
        /// Group presence overview for more information. NOTE instead of using the
        /// standalone API, we recommend setting all GroupPresence parameters in one
        /// call to @internal_link(horizon.platform.group_presence.GroupPresence#set(Gr
        /// oupPresenceOptions)). This helps ensure that all relevant presence
        /// information is singularly updated and helps reduce presence errors.
        public static Request SetLobbySession(string id)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "id", id }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "set_lobby_session", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Replaces the user's current @internal_link(horizon.platform.group_presence.
        /// options.GroupPresenceOptions#match_session_id) for the provided one. Use
        /// this to update the user's current match session id while keeping all other
        /// GroupPresence parameters the same. @internal_link(horizon.platform.group_pr
        /// esence.options.GroupPresenceOptions#match_session_id) works in conjuction
        /// with @internal_link(horizon.platform.group_presence.options.GroupPresenceOp
        /// tions#lobby_session_id) to determine if users are playing together. If a
        /// user's match and lobby session ids are the same, they should be in the same
        /// multiplayer instance together. Users with the same lobby session id but
        /// different match session ids may be in the same lobby for things like voice
        /// chat while in different instances in your app. WARNING match session id is
        /// often treated the same as lobby session id, but this is in fact a distinct
        /// parameter and is not used for travel from the Meta Quest Platform. NOTE
        /// instead of using the standalone API, we recommend setting all GroupPresence
        /// parameters in one call to @internal_link(horizon.platform.group_presence.Gr
        /// oupPresence#set(GroupPresenceOptions)).
        public static Request SetMatchSession(string id)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "id", id }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "set_match_session", 1, jsonRequest, 0);
                return new Request(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Sent when the user is finished using the invite panel to send out
        /// invitations. Contains a list of invitees. Parameter: Callback is a function
        /// that will be called when the invitation sent status changes. @internal_link
        /// (horizon.platform.group_presence.models.LaunchInvitePanelFlowResult) has 1
        /// member: UserList @internal_link(horizon.platform.group_presence.models.Laun
        /// chInvitePanelFlowResult#invited_users) - A list of users that were sent an
        /// invitation to the session.
        
        public static void SetInvitationsSentNotificationCallback(Message<LaunchInvitePanelFlowResult>.Callback callback)
        {
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new { });
                ulong sessionId = PlatformClient.MakeSession("group_presence", "invitations_sent", 1, jsonRequest, 0);
                Callback.SetNotificationCallback<LaunchInvitePanelFlowResult>(sessionId, callback);
            }
            else
            {
                Debug.LogError(Core.PlatformUninitializedError);
            }
        }

        /// Sent when a user has chosen to join the destination/lobby/match. Read all
        /// the fields to figure out where the user wants to go and take the
        /// appropriate actions to bring them there. If the user is unable to go there,
        /// provide adequate messaging to the user on why they cannot go there. These
        /// notifications should be responded to immediately. Parameter: Callback is a
        /// function that will be called when a user has chosen to join the
        /// destination/lobby/match. @internal_link(horizon.platform.group_presence.mod
        /// els.GroupPresenceJoinIntent) has 4 members: string @internal_link(horizon.p
        /// latform.group_presence.models.GroupPresenceJoinIntent#deeplink_message) -
        /// An opaque string provided by the developer to help them deeplink to
        /// content. string @internal_link(horizon.platform.group_presence.models.Group
        /// PresenceJoinIntent#destination_api_name) - The destination the current user
        /// wants to go to. string @internal_link(horizon.platform.group_presence.model
        /// s.GroupPresenceJoinIntent#lobby_session_id) - The lobby session the current
        /// user wants to go to. string @internal_link(horizon.platform.group_presence.
        /// models.GroupPresenceJoinIntent#match_session_id) - The match session the
        /// current user wants to go to.
        
        public static void SetJoinIntentReceivedNotificationCallback(Message<GroupPresenceJoinIntent>.Callback callback)
        {
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new { });
                ulong sessionId = PlatformClient.MakeSession("group_presence", "join_intent_received", 1, jsonRequest, 0);
                Callback.SetNotificationCallback<GroupPresenceJoinIntent>(sessionId, callback);
            }
            else
            {
                Debug.LogError(Core.PlatformUninitializedError);
            }
        }

        /// Sent when the user has chosen to leave the destination/lobby/match from the
        /// Oculus menu. Read the specific fields to check the user is currently from
        /// the destination/lobby/match and take the appropriate actions to remove
        /// them. Update the user's presence clearing the appropriate fields to
        /// indicate the user has left. Parameter: Callback is a function that will be
        /// called when the user has chosen to leave the destination/lobby/match. @inte
        /// rnal_link(horizon.platform.group_presence.models.GroupPresenceLeaveIntent)
        /// has 3 members: string @internal_link(horizon.platform.group_presence.models
        /// .GroupPresenceLeaveIntent#destination_api_name) - The destination the
        /// current user wants to leave. string @internal_link(horizon.platform.group_p
        /// resence.models.GroupPresenceLeaveIntent#lobby_session_id) - The lobby
        /// session the current user wants to leave. string @internal_link(horizon.plat
        /// form.group_presence.models.GroupPresenceLeaveIntent#match_session_id) - The
        /// match session the current user wants to leave.
        
        public static void SetLeaveIntentReceivedNotificationCallback(Message<GroupPresenceLeaveIntent>.Callback callback)
        {
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new { });
                ulong sessionId = PlatformClient.MakeSession("group_presence", "leave_intent_received", 1, jsonRequest, 0);
                Callback.SetNotificationCallback<GroupPresenceLeaveIntent>(sessionId, callback);
            }
            else
            {
                Debug.LogError(Core.PlatformUninitializedError);
            }
        }

        /// Gets all the
        /// @internal_link(horizon.platform.group_presence.models.Destination) that the
        /// presence can be set to
        public static Request<DestinationList> GetDestinations()
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

                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_destinations", 1, jsonRequest, 0);
                return new Request<DestinationList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        

        public static Request<ApplicationInviteList> GetNextApplicationInviteListPage(ApplicationInviteList list) {
            if (!list.HasNextPage)
            {
                Debug.LogWarning("Oculus.Platform.GetNextApplicationInviteListPage: List has no next page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.NextUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_application_invite_page_by_url", 1, jsonRequest, 0);
                return new Request<ApplicationInviteList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        public static Request<DestinationList> GetNextDestinationListPage(DestinationList list) {
            if (!list.HasNextPage)
            {
                Debug.LogWarning("Oculus.Platform.GetNextDestinationListPage: List has no next page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.NextUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_destination_page_by_url", 1, jsonRequest, 0);
                return new Request<DestinationList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        public static Request<ApplicationInviteList> GetPreviousApplicationInviteListPage(ApplicationInviteList list) {
            if (!list.HasPreviousPage)
            {
                Debug.LogWarning("Oculus.Platform.GetPreviousApplicationInviteListPage: List has no previous page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.PreviousUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_application_invite_page_by_url", 1, jsonRequest, 0);
                return new Request<ApplicationInviteList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        public static Request<DestinationList> GetPreviousDestinationListPage(DestinationList list) {
            if (!list.HasPreviousPage)
            {
                Debug.LogWarning("Oculus.Platform.GetPreviousDestinationListPage: List has no previous page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.PreviousUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("group_presence", "get_destination_page_by_url", 1, jsonRequest, 0);
                return new Request<DestinationList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }
    }
}
