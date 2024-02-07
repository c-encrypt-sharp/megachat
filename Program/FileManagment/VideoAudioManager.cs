using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    class VideoAudioManager
    {
        public VideoAudioManager() { }

        /// <summary>
        /// Loads videos asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        public async Task LoadVideo() { await Task.Delay(0); }

        /// <summary>
        /// Loads audio asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        public async Task LoadAudio() { await Task.Delay(0); }

        /// <summary>
        /// Saves video asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        public async Task SaveVideo() { await Task.Delay(0); }

        /// <summary>
        /// Saves audio asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        public async Task SaveAudio() { await Task.Delay(0); }
    }
}
