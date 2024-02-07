using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class CloudManager
    {
        public CloudManager() { }

        /// <summary>
        /// Saves the specified data to the cloud
        /// </summary>
        /// <param name="data">data stored in the cloud</param>
        public void ToCloud(object data) { }

        /// <summary>
        /// Downloads data from the cloud
        /// </summary>
        /// <param name="data">data to be loaded</param>
        /// <returns>loaded data or null if does not exist</returns>
        public object FromCloud(object data) { throw new NotImplementedException(); }
    }
}
