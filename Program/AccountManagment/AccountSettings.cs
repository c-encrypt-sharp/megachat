using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class AccountSettings
    {
        SettingsModel? _settings;

        public SettingsModel? Settings { get => _settings; set => _settings = value; }

        public AccountSettings() { }
        /// <summary>
        /// Method sets new settings
        /// </summary>
        /// <param name="settings">parameter represents a settings data model object</param>
        public void SetSettings(SettingsModel settings) 
        {

        }
        /// <summary>
        /// Method reset setting
        /// </summary>
        public void ResetSettings()
        {

        }
    }
}
