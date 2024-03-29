﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class NotificationWorker
    {
        /// <summary>
        /// Waiting for notification
        /// </summary>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// while (true) {
        ///     await new NotificationWorker().ReceiveNotifyAsync();
        /// }
        /// </code>
        /// </example>
        public async Task ReceiveNotifyAsync() { await Task.Delay(0); }

        /// <summary>
        /// Creates a newsletter
        /// </summary>
        /// <param name="notification"></param>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new NotificationWorker().SendNotifyAsync(new NotificationModel(){...});
        /// </code>
        /// </example>
        public async Task SendNotifyAsync(NotificationModel notification) { await Task.Delay(0); }
    }
}
