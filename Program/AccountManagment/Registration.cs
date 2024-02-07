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
        public void RegisterAccount(AccountDataModel accountData) { }

        /// <summary>
        /// Authorizes the specified user
        /// </summary>
        /// <param name="username">login for authorization</param>
        /// <param name="password">password for authorization as a secure string</param>
        public void Authorization(string username, SecureString password) { }
    }
}

