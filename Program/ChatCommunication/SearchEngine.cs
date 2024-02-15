using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{   
    public class SearchEngine
    {
        [Flags, Serializable]
        public enum Filters { }

        public SearchEngine() { }

        /// <summary>
        /// Searches for specified data
        /// </summary>
        /// <param name="data">search data</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new SearchEngine().FindData(string.Empty);
        /// </code>
        /// </example>
        public void FindData(string data) { }

        /// <summary>
        /// Sets search filters
        /// </summary>
        /// <param name="filters">search filters</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new SearchEngine().SetFilters(filter1 | filter2);
        /// </code>
        /// </example>
        public void SetFilters(Filters filters) { }
    }
}
