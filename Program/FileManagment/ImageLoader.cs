using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class ImageLoader
    {
        public ImageLoader() { }

        /// <summary>
        /// Loads an image for processing
        /// </summary>
        /// <param name="path">path to the downloaded file</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string path = string.Empty;
        /// new ImageLoader().LoadImage(path);
        /// </code>
        /// </example>
        public void LoadImage(string path) { }

        /// <summary>
        /// Saves the image
        /// </summary>
        /// <param name="path">save path</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string path = string.Empty;
        /// new ImageLoader().SaveImage(path);
        /// </code>
        /// </example>
        public void SaveImage(string path) { }
    }
}
