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
        public void SetConfidential(ConfidentialInformation confidential) { }
        public void HideChat(string name) { }
        public void ChangeVisualChat(string name, string theme) { }
        public void SetPrivateAccount(bool visible = true) { }       
    }
}
