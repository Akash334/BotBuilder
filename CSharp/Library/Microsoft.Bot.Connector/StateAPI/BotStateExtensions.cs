// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;


    public static partial class BotStateExtensions
    {
        /// <summary>
        /// GetUserData
        /// </summary>
        /// Get a BotData record for the user
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        public static BotData GetUserData(this IBotState operations, string botId, string channelId, string userId)
        {
            return Task.Factory.StartNew(s => ((IBotState)s).GetUserDataAsync(botId, channelId, userId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetUserData
        /// </summary>
        /// Get a BotData record for the user
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BotData> GetUserDataAsync(this IBotState operations, string botId, string channelId, string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            // END TEmP
            var _result = await operations.GetUserDataWithHttpMessagesAsync(botId, channelId, userId, headers, cancellationToken).ConfigureAwait(false);
            return _result.HandleError<BotData>();
        }

        /// <summary>
        /// SetUserData
        /// </summary>
        /// Update the bot user data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        public static BotData SetUserData(this IBotState operations, string botId, string channelId, string userId, BotData botData)
        {
            return Task.Factory.StartNew(s => ((IBotState)s).SetUserDataAsync(botId, channelId, userId, botData), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// SetUserData
        /// </summary>
        /// Update the bot user data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BotData> SetUserDataAsync(this IBotState operations, string botId, string channelId, string userId, BotData botData, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            // END TEmP

            var _result = await operations.SetUserDataWithHttpMessagesAsync(botId, channelId, userId, botData, headers, cancellationToken).ConfigureAwait(false);
            return _result.HandleError<BotData>();
        }

        /// <summary>
        /// GetConversationData
        /// </summary>
        /// get the bot data for a conversation
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// The conversationId
        /// </param>
        public static BotData GetConversationData(this IBotState operations, string botId, string channelId, string conversationId)
        {
            return Task.Factory.StartNew(s => ((IBotState)s).GetConversationDataAsync(botId, channelId, conversationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetConversationData
        /// </summary>
        /// get the bot data for a conversation
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// The conversationId
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BotData> GetConversationDataAsync(this IBotState operations, string botId, string channelId, string conversationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            // END TEmP

            var _result = await operations.GetConversationDataWithHttpMessagesAsync(botId, channelId, conversationId, headers, cancellationToken).ConfigureAwait(false);
            return _result.HandleError<BotData>();
        }

        /// <summary>
        /// SetConversationData
        /// </summary>
        /// Update the bot conversation data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// conversation id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        public static BotData SetConversationData(this IBotState operations, string botId, string channelId, string conversationId, BotData botData)
        {
            return Task.Factory.StartNew(s => ((IBotState)s).SetConversationDataAsync(botId, channelId, conversationId, botData), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// SetConversationData
        /// </summary>
        /// Update the bot conversation data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// conversation id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BotData> SetConversationDataAsync(this IBotState operations, string botId, string channelId, string conversationId, BotData botData, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            // END TEmP

            var _result = await operations.SetConversationDataWithHttpMessagesAsync(botId, channelId, conversationId, botData, headers, cancellationToken).ConfigureAwait(false);
            return _result.HandleError<BotData>();
        }

        /// <summary>
        /// GetPerUserConversationData
        /// </summary>
        /// get the bot data for a user in a conversation
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// The conversationId
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        public static BotData GetPerUserConversationData(this IBotState operations, string botId, string channelId, string conversationId, string userId)
        {
            return Task.Factory.StartNew(s => ((IBotState)s).GetPerUserConversationDataAsync(botId, channelId, conversationId, userId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetPerUserConversationData
        /// </summary>
        /// get the bot data for a user in a conversation
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// The conversationId
        /// </param>
        /// <param name='userId'>
        /// The user Id
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BotData> GetPerUserConversationDataAsync(this IBotState operations, string botId, string channelId, string conversationId, string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            // END TEmP

            var _result = await operations.GetPerUserConversationDataWithHttpMessagesAsync(botId, channelId, conversationId, userId, headers, cancellationToken).ConfigureAwait(false);
            return _result.HandleError<BotData>();
        }

        /// <summary>
        /// SetPerUserInConversationData
        /// </summary>
        /// Update the bot user in a conversation data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// conversation id
        /// </param>
        /// <param name='userId'>
        /// user id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        public static BotData SetPerUserInConversationData(this IBotState operations, string botId, string channelId, string conversationId, string userId, BotData botData)
        {
            return Task.Factory.StartNew(s => ((IBotState)s).SetPerUserInConversationDataAsync(botId, channelId, conversationId, userId, botData), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// SetPerUserInConversationData
        /// </summary>
        /// Update the bot user in a conversation data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='botId'>
        /// The BotId
        /// </param>
        /// <param name='channelId'>
        /// the channelId for the user
        /// </param>
        /// <param name='conversationId'>
        /// conversation id
        /// </param>
        /// <param name='userId'>
        /// user id
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<BotData> SetPerUserInConversationDataAsync(this IBotState operations, string botId, string channelId, string conversationId, string userId, BotData botData, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            // END TEmP

            var _result = await operations.SetPerUserInConversationDataWithHttpMessagesAsync(botId, channelId, conversationId, userId, botData, headers, cancellationToken).ConfigureAwait(false);
            return _result.HandleError<BotData>();
        }

    }
}
