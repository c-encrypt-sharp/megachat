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
        public async Task SendMessagesAsync(MessageModel messageModel) { await new MessageManager().SendMessageAsync(messageModel); }

        /// <summary>
        /// Deletes a message asynchronously
        /// </summary>
        /// <param name="index">index of message</param>
        /// <returns>asynchronous task object</returns>
        public async Task DeleteMessagesAsync(int index) { await new MessageManager().DeleteMessageAsync(index); }
    }
}
