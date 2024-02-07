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
        /// <returns>asynchronous task object</returns>
        public async Task SendMessagesAsync() { await new MessageManager().SendMessageAsync(new MessageModel()); }
    }
}
