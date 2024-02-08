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
        public async Task ReceiveAsync() { await Task.Delay(0); }

        /// <summary>
        /// Stops the waiting
        /// </summary>
        public void StopReceive() { }

        /// <summary>
        /// Receives new messages asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        private async Task GetMessagesAsync() { await Task.Delay(0); }

        /// <summary>
        /// Sends the specified message asynchronously
        /// </summary>
        /// <param name="message">specified message</param>
        /// <returns>message unique ID</returns>
        private async Task<int> SendAsync(string message) { await Task.Delay(0); return 0; }

        /// <summary>
        /// Returns a list of all folders in the specified folder
        /// </summary>
        /// <param name="folder">specified folder</param>
        /// <returns>subfolder in specified folder</returns>
        private async Task GetSubFolders(string folder) { await Task.Delay(0); }
    }
}
