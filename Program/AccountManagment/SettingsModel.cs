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
        public void SetConfidential(ConfidentialInformation confidential) { }

        /// <summary>
        /// The method makes the selected chat hidden
        /// </summary>
        /// <param name="name">chat name</param>
        public void HideChat(string name) { }

        /// <summary>
        /// Changes the topic of the selected chat
        /// </summary>
        /// <param name="name">chat name</param>
        /// <param name="theme">theme name</param>
        public void ChangeVisualChat(string name, string theme) { }

        /// <summary>
        /// Hides the account page
        /// </summary>
        /// <param name="visible">visibility, if true (default), then hides, otherwise makes visible</param>
        public void SetPrivateAccount(bool visible = true) { }       
    }
}
