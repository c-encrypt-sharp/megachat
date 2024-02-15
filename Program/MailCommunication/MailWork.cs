using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class MailWork
    {
        public MailWork() { }

        /// <summary>
        /// Asynchronously waits for messages
        /// </summary>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new MailWork().ReceiveAsync();
        /// </code>
        /// </example>
        public async Task ReceiveAsync() { await Task.Delay(0); }

        /// <summary>
        /// Stops the waiting
        /// </summary>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new MailWork().StopReceive();
        /// </code>
        /// </example>
        public void StopReceive() { }

        /// <summary>
        /// Receives new messages asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new MailWork().GetMessagesAsync();
        /// </code>
        /// </example>
        private async Task GetMessagesAsync() { await Task.Delay(0); }

        /// <summary>
        /// Sends the specified message asynchronously
        /// </summary>
        /// <param name="message">specified message</param>
        /// <returns>message unique ID</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// int id = await new MailWork().SendAsync(string.Empty);
        /// </code>
        /// </example>
        private async Task<int> SendAsync(string message) { await Task.Delay(0); return 0; }

        /// <summary>
        /// Returns a list of all folders in the specified folder
        /// </summary>
        /// <param name="folder">specified folder</param>
        /// <returns>subfolders in specified folder</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var sf = await new MailWork().GetSubFolders(string.Empty);
        /// </code>
        /// </example>
        private async Task<string[]> GetSubFolders(string folder) { await Task.Delay(0); return new string[0]; }
    }
}
