using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class PrivateMessagesWork
    {
        public PrivateMessagesWork() { }

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
        /// await new PrivateMessagesWork().SendMessagesAsync(new MessageModel(){...});
        /// </code>
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
        /// await new PrivateMessagesWork().DeleteMessagesAsync(0);
        /// </code>
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
        /// await new PrivateMessagesWork().LoadMessagesAsync(0);
        /// </code>
        /// </example>
        public async Task LoadMessagesAsync(int count) { await new MessageManager().LoadMessagesAsync(count); }
    }
}
