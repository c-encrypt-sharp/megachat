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
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// try {
        ///     new QueryManager(string.Empty).CheckQuery();
        /// }
        /// catch (QuerySyntaxException e) {
        ///     MessageBox.Show(e.Message);
        /// } 
        /// </code>
        /// </example>
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
        /// <returns>true if successfull, otherwise false</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new QueryManager(string.Empty).FixRequest();
        /// </code>
        /// </example>
        public bool FixRequest()
        {
            throw new NotImplementedException();
        }
    }
}
