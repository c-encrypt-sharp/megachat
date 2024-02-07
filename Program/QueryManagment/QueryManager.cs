using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class QueryManager
    {
        public QueryManager() { }
        public QueryManager(string query) { }

        /// <summary>
        /// Checks the request for errors
        /// </summary>
        /// <exception cref="QuerySyntaxException"></exception>
        public void CheckQuery() 
        {
            try
            {

            }
            catch (QuerySyntaxException) 
            { 
                throw;
            }
        }

        /// <summary>
        /// Corrects the request
        /// </summary>
        /// <returns></returns>
        public bool FixRequest()
        {
            throw new NotImplementedException();
        }
    }
}
