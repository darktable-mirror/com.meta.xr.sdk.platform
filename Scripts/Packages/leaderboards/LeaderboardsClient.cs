// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.
/*
 * This file was @generated with arvr/projects/horizon-platform-sdk/tools/codegen. Do not modify it!
 * To regenerate this file, run: `buck run //arvr/projects/horizon-platform-sdk/tools/codegen:cli - - -all -g "Unity, CSharp"`
 * @generated SignedSource<<1e4295f44b6c606ee2f83e113e82144c>>
 */

using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Models;
using System;
using System.Collections.Generic;

namespace Oculus.Platform
{
    public static partial class Leaderboards
    {
        /// Retrieves detailed information for a single leaderboard with a specified
        /// name, returning an array of
        /// @internal_link(horizon.platform.leaderboards.models.Leaderboard).
        public static Request<LeaderboardList> Get(string leaderboardName)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "leaderboard_name", leaderboardName }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get", 1, jsonRequest, 0);
                return new Request<LeaderboardList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Retrieves a list of leaderboard entries for a specified leaderboardName,
        /// with options to filter and limit the number of results returned.
        public static Request<LeaderboardEntryList> GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "leaderboard_name", leaderboardName },
                    { "limit", limit },
                    { "filter", filter.GetDescription() },
                    { "start_at", startAt.GetDescription() }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_entries", 1, jsonRequest, 0);
                return new Request<LeaderboardEntryList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Retrieves a block of leaderboard entries starting from a specific rank.
        public static Request<LeaderboardEntryList> GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "leaderboard_name", leaderboardName },
                    { "limit", limit },
                    { "after_rank", afterRank }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_entries_after_rank", 1, jsonRequest, 0);
                return new Request<LeaderboardEntryList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Retrieves a block of leaderboard entries that match the specified user IDs.
        /// Only entries corresponding to the provided user IDs will be returned.
        public static Request<LeaderboardEntryList> GetEntriesByIds(string leaderboardName, int limit, LeaderboardStartAt startAt, UInt64[] userIDs)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "leaderboard_name", leaderboardName },
                    { "limit", limit },
                    { "start_at", startAt.GetDescription() },
                    { "user_ids", Array.ConvertAll(userIDs, id => id.ToString()) }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_entries_by_ids", 1, jsonRequest, 0);
                return new Request<LeaderboardEntryList>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Writes a single entry to the leaderboard, returning @internal_link(horizon.
        /// platform.leaderboards.models.LeaderboardUpdateStatus) indicating whether
        /// the update was successful and providing the updated challenge IDs.
        public static Request<bool> WriteEntry(string leaderboardName, long score, byte[] extraData = null, bool? forceUpdate = null)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "leaderboard_name", leaderboardName },
                    { "score", score },
                    { "extra_data", extraData },
                    { "force_update", forceUpdate }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "write_entry", 1, jsonRequest, 0);
                return new Request<bool>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        /// Writes a single entry to a leaderboard which can include supplementary
        /// metrics, returning @internal_link(horizon.platform.leaderboards.models.Lead
        /// erboardUpdateStatus) indicating whether the update was successful and
        /// providing the updated challenge IDs.
        public static Request<bool> WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, byte[] extraData = null, bool? forceUpdate = null)
        {
            if (Core.IsInitialized())
            {
                  var request = new Dictionary<string, object>
                {
                    { "leaderboard_name", leaderboardName },
                    { "score", score },
                    { "supplementary_metric", supplementaryMetric },
                    { "extra_data", extraData },
                    { "force_update", forceUpdate }
                };

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                string jsonRequest = JsonConvert.SerializeObject(request, settings);

                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "write_entry_with_supplementary_metric", 1, jsonRequest, 0);
                return new Request<bool>(requestHandle);
            }

            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        

        public static Request<LeaderboardList> GetNextLeaderboardListPage(LeaderboardList list) {
            if (!list.HasNextPage)
            {
                Debug.LogWarning("Oculus.Platform.GetNextLeaderboardListPage: List has no next page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.NextUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_leaderboard_page_by_url", 1, jsonRequest, 0);
                return new Request<LeaderboardList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        public static Request<LeaderboardEntryList> GetNextEntries(LeaderboardEntryList list) {
            if (!list.HasNextPage)
            {
                Debug.LogWarning("Oculus.Platform.GetNextEntries: List has no next page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.NextUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_leaderboard_entry_page_by_url", 1, jsonRequest, 0);
                return new Request<LeaderboardEntryList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        public static Request<LeaderboardList> GetPreviousLeaderboardListPage(LeaderboardList list) {
            if (!list.HasPreviousPage)
            {
                Debug.LogWarning("Oculus.Platform.GetPreviousLeaderboardListPage: List has no previous page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.PreviousUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_leaderboard_page_by_url", 1, jsonRequest, 0);
                return new Request<LeaderboardList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }

        public static Request<LeaderboardEntryList> GetPreviousEntries(LeaderboardEntryList list) {
            if (!list.HasPreviousPage)
            {
                Debug.LogWarning("Oculus.Platform.GetPreviousEntries: List has no previous page");
                return null;
            }
            if (Core.IsInitialized())
            {
                string jsonRequest = JsonConvert.SerializeObject(new
                {
                    url = list.PreviousUrl
                });
                ulong requestHandle = PlatformClient.MakeRequest("leaderboards", "get_leaderboard_entry_page_by_url", 1, jsonRequest, 0);
                return new Request<LeaderboardEntryList>(requestHandle);
            }
            Debug.LogError(Core.PlatformUninitializedError);
            return null;
        }
    }
}
