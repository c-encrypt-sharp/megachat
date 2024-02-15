using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class PersonalSettings
    {
        public PersonalSettings() { }

        /// <summary>
        /// Changes the chat topic
        /// </summary>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new PersonalSettings().SetTheme();
        /// </code>
        /// </example>
        public void SetTheme() { }

        /// <summary>
        /// Changes account details, login, password etc. 
        /// </summary>
        /// <param name="accountData">Changeable data</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new PersonalSettings().ChangeAccountData(new AccountDataModel(){...});
        /// </code>
        /// </example>
        public void ChangeAccountData(AccountDataModel accountData) { }
    }
}
