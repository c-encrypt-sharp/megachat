using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class Archivator
    {
        public enum ArchiveType { }
        public Archivator() { }
        /// <summary>
        /// Archives and unarchives data
        /// </summary>
        /// <param name="data">file in byte representation</param>
        /// <param name="type">archiving type: zip, rar, 7z etc.</param>
        /// <param name="isForward">indicates that archiving or unarchiving of data is required; if true, the file will be compressed</param>      
        /// <returns>compressed or unarchived data</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// byte[] data = new byte[10];
        /// ArchiveType type = ArchiveType.RAR;
        /// new Archivator().Archive(data, type, true)
        /// </code>
        /// </example>
        public byte[] Archive(byte[] data, ArchiveType type, bool isForward = true) 
        {
            throw new NotImplementedException();
        }
    }
}





