using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class SettingsModel
    {
        public SettingsModel() { }
        public bool EnabledNotify { get; set; } = true;

        /// <summary>
        /// Sets the specified privacy data
        /// </summary>
        /// <param name="confidential">privacy dataset</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new SettingsModel().SetConfidential(new ConfidentialInformation(){...});
        /// </code>
        /// </example>
        public void SetConfidential(ConfidentialInformation confidential) { }

        /// <summary>
        /// The method makes the selected chat hidden
        /// </summary>
        /// <param name="name">chat name</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new SettingsModel().HideChat(string.Empty);
        /// </code>
        /// </example>
        public void HideChat(string name) { }

        /// <summary>
        /// Changes the topic of the selected chat
        /// </summary>
        /// <param name="name">chat name</param>
        /// <param name="theme">theme name</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new SettingsModel().ChangeVisualChat(string.Empty, string.Empty);
        /// </code>
        /// </example>
        public void ChangeVisualChat(string name, string theme) { }

        /// <summary>
        /// Hides the account page
        /// </summary>
        /// <param name="visible">visibility, if true (default), then hides, otherwise makes visible</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new SettingsModel().SetPrivateAccount();
        /// </code>
        /// </example>
        public void SetPrivateAccount(bool visible = true) { }       
    }
}
