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
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new GroupMessagesWork().SetAdmin(
        ///     new UserAccountModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// </code>
        /// 
        ///     OR
        ///     
        /// <code>
        /// var uam = new UserAccountModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// var gmw = new GroupMessagesWork();
        /// gmw.SetAdmin(uam);
        /// </code>
        /// </example>
        public void SetAdmin(UserAccountModel user) { }

        /// <summary>
        /// Adds a user to the chat
        /// </summary>
        /// <param name="user">whose user needs to be added</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new GroupMessagesWork().AddUser(
        ///     new UserAccountModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// </code>
        /// 
        ///     OR
        ///     
        /// <code>
        /// var uam = new UserAccountModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// var gmw = new GroupMessagesWork();
        /// gmw.AddUser(uam);
        /// </code>
        /// </example>
        public void AddUser(UserAccountModel user) { }

        /// <summary>
        /// Removes a user from a chat
        /// </summary>
        /// <param name="user">the user whose user needs to be deleted</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new GroupMessagesWork().DeleteUser(
        ///     new UserAccountModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// </code>
        /// 
        ///     OR
        ///     
        /// <code>
        /// var uam = new UserAccountModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// var gmw = new GroupMessagesWork();
        /// gmw.DeleteUser(uam);
        /// </code>
        /// </example>
        public void DeleteUser(UserAccountModel user) { }

        /// <summary>
        /// Sends a message asynchronously
        /// </summary>
        /// <param name="messageModel">message for send</param>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new GroupMessagesWork().SendMessagesAsync(
        ///     new MessageModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// </code>
        /// 
        ///     OR
        ///     
        /// <code>
        /// var uam = new MessageModel()
        ///     {
        ///         prop1 = value;
        ///         prop2 = value;
        ///         ...
        ///     });
        /// var gmw = new GroupMessagesWork();
        /// var task = gmw.SendMessagesAsync(uam);
        /// </code>
        /// 
        /// And use a task to track a function
        /// 
        /// </example>
        public async Task SendMessagesAsync(MessageModel messageModel) { await new MessageManager().SendMessageAsync(messageModel); }

        /// <summary>
        /// Deletes a message asynchronously
        /// </summary>
        /// <param name="index">index of message</param> 
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new GroupMessagesWork().DeleteMessagesAsync(10); //only System.Int32
        /// </code>
        /// 
        ///     OR
        ///     
        /// <code>
        /// int index = 10;
        /// var gmw = new GroupMessagesWork();
        /// var task = gmw.DeleteMessagesAsync(index);
        /// </code>
        /// 
        /// And use a task to track a function
        /// 
        /// </example>
        public async Task DeleteMessagesAsync(int index) { await new MessageManager().DeleteMessageAsync(index); }

        /// <summary>
        /// Load messages asynchronously
        /// </summary>
        /// <param name="count">count messages</param>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new GroupMessagesWork().SendMessagesAsync(10); //only System.Int32;
        /// </code>
        /// 
        ///     OR
        ///     
        /// <code>
        /// int count = 10;
        /// var gmw = new GroupMessagesWork();
        /// var task = gmw.SendMessagesAsync(uam);
        /// </code>
        /// 
        /// And use a task to track a function
        /// 
        /// </example>
        public async Task LoadMessagesAsync(int count) { await new MessageManager().LoadMessagesAsync(count); }
    }
}
