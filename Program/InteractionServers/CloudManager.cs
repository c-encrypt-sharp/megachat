using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace PPPI_LR2_MODULES
{
    public class CloudManager
    {
        public CloudManager() { }

        /// <summary>
        /// Saves the specified data to the cloud
        /// </summary>
        /// <param name="data">data stored in the cloud</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// serializableObject = new object();
        /// new CloudManager().ToCloud(serializableObject);
        /// </code>
        /// </example>
        public void ToCloud(object data) { JsonSerializer.Serialize(data); }

        /// <summary>
        /// Downloads data from the cloud
        /// </summary>
        /// <param name="data">data to be loaded</param>
        /// <returns>loaded data or null if does not exist</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// serializableObject = new object();
        /// new CloudManager().FromCloud(serializableObject);
        /// </code>
        /// </example>
        public object? FromCloud<T>(object data) 
        {
            T? result;

            using (var fs = new FileStream(string.Empty, FileMode.Create))
                result = JsonSerializer.Deserialize<T>(fs);

            return result;
        }
    }
}
