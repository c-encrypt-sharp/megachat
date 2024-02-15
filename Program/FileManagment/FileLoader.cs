using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class FileLoader
    {
        public FileLoader() { }

        /// <summary>
        /// Downloads the specified file
        /// </summary>
        /// <param name="path">name of the file to be downloaded</param>
        /// <returns>returns file data</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string path = string.Empty;
        /// byte[] data = new FileLoader().DownloadFile(path);
        /// </code>
        /// </example>
        public byte[] DownloadFile(string path) { throw new NotImplementedException(); }

        /// <summary>
        /// Uploads a file to send
        /// </summary>
        /// <param name="path">name of the file to be loaded</param>
        /// <returns>returns file data</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string path = string.Empty;
        /// byte[] data = new FileLoader().LoadFile(path);
        /// </code>
        /// </example>
        public byte[] LoadFile(string path) { throw new NotImplementedException(); }

        /// <summary>
        /// Saves the file
        /// </summary>
        /// <param name="path">name of the file to be saved</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string path = string.Empty;
        /// new FileLoader().SaveFile(path);
        /// </code>
        /// </example>
        public void SaveFile(string path) { }

        /// <summary>
        /// Searches for a file, if file not found, returns false
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>true if the file is found otherwise false</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string filename = string.Empty;
        /// bool result = new FileLoader().FindFile(path);
        /// </code>
        /// </example>
        public bool FindFile(string filename) { throw new NotImplementedException(); }
    }
}

