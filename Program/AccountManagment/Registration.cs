using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class Registration
    {
        public string Username { get; set; }
        public SecureString Password { get; set; }
        public Registration() { }

        /// <summary>
        /// Registers a new account
        /// </summary>
        /// <param name="accountData">registration details</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new Registration(){...}.RegisterAccount(new AccountDataModel(){...});
        /// </code>
        /// </example>
        public void RegisterAccount(AccountDataModel accountData) { }

        /// <summary>
        /// Authorizes the specified user
        /// </summary>
        /// <param name="username">login for authorization</param>
        /// <param name="password">password for authorization as a secure string</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new Registration(){...}.Authorization(string.Empty, new SecureString());
        /// </code>
        /// </example>
        public void Authorization(string username, SecureString password) { }
    }
}

