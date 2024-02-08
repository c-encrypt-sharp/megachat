using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class GroupMessagesWork
    {
        public GroupMessagesWork() { }

        /// <summary>
        /// Creates a group chat
        /// </summary>
        /// <param name="chatName">group chat name</param>
        public void CreateGroupChat(string chatName) { }

        /// <summary>
        /// Sets administrator rights to the specified user
        /// </summary>
        /// <param name="user">user who needs to be assigned administrator rights</param>
        public void SetAdmin(UserAccountModel user) { }

        /// <summary>
        /// Adds a user to the chat
        /// </summary>
        /// <param name="user">whose user needs to be added</param>
        public void AddUser(UserAccountModel user) { }

        /// <summary>
        /// Removes a user from a chat
        /// </summary>
        /// <param name="user">the user whose user needs to be deleted</param>
        public void DeleteUser(UserAccountModel user) { }

        /// <summary>
        /// Sends a message asynchronously
        /// </summary>
        /// <param name="messageModel">message for send</param>
        /// <returns>asynchronous task object</returns>
        public async Task SendMessagesAsync(MessageModel messageModel) { await new MessageManager().SendMessageAsync(messageModel); }

        /// <summary>
        /// Deletes a message asynchronously
        /// </summary>
        /// <param name="index">index of message</param>
        /// <returns>asynchronous task object</returns>
        public async Task DeleteMessagesAsync(int index) { await new MessageManager().DeleteMessageAsync(index); }

        /// <summary>
        /// Load messages asynchronously
        /// </summary>
        /// <param name="count">count messages</param>
        /// <returns>asynchronous task object</returns>
        public async Task LoadMessagesAsync(int count) { await new MessageManager().LoadMessagesAsync(count); }
    }
}
