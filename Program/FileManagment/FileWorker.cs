using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class FileWorker
    {
        public FileWorker() { }

        /// <summary>
        /// Open Word file 
        /// </summary>
        /// <param name="path">the path to the file</param>
        public void OpenWord(string path) { }

        /// <summary>
        /// Close Word file
        /// </summary>
        public void CloseWord() { }

        /// <summary>
        /// Open PowerPoint file
        /// </summary>
        /// <param name="path">the path to the file</param>
        public void OpenPowerPoint(string path) { }

        /// <summary>
        /// Close PowerPoint file
        /// </summary>
        public void ClosePowerPoint() { }

        /// <summary>
        /// Open Excel file
        /// </summary>
        /// <param name="path">the path to the file</param>
        public void OpenExcel(string path) { }

        /// <summary>
        /// Close Excel file
        /// </summary>
        public void CloseExcel() { }

        /// <summary>
        /// Save file
        /// </summary>
        /// <param name="path">the path where the file will be saved</param>
        public void Save(string path) { }
    }
}
