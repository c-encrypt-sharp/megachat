using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class MessageManager
    {
        public MessageManager() { }

        /// <summary>
        /// Sends a message asynchronously
        /// </summary>
        /// <param name="message">message to be sent</param>
        /// <returns>asynchronous task object</returns>
        public async Task SendMessageAsync(MessageModel message) { await Task.Delay(0); }

        /// <summary>
        /// Loads messages
        /// </summary>
        /// <param name="count">number of messages to download, by default all messages will be downloaded</param>
        /// <returns>asynchronous task object</returns>
        public async Task LoadMessagesAsync(int count = default(int)) { await Task.Delay(0); }

        /// <summary>
        /// Deletes a message
        /// </summary>
        /// <param name="index">message number</param>
        /// <returns>asynchronous task object</returns>
        public async Task DeleteMessageAsync(int index) { await Task.Delay(0); }
    }
}
