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
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new VideoAudioManager().LoadVideo();
        /// </code>
        /// </example>
        public async Task LoadVideo() { await Task.Delay(0); }

        /// <summary>
        /// Loads audio asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new VideoAudioManager().LoadAudio();
        /// </code>
        /// </example>
        public async Task LoadAudio() { await Task.Delay(0); }

        /// <summary>
        /// Saves video asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new VideoAudioManager().SaveVideo();
        /// </code>
        /// </example>
        public async Task SaveVideo() { await Task.Delay(0); }

        /// <summary>
        /// Saves audio asynchronously
        /// </summary>
        /// <returns>asynchronous task object</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// await new VideoAudioManager().SaveAudio();
        /// </code>
        /// </example>
        public async Task SaveAudio() { await Task.Delay(0); }
    }
}
