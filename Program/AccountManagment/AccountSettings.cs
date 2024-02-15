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

        /// <summary>
        /// <para>The property represents an object of settings that must be set before calling the settings method.</para>
        /// <para>If you do not assign a value, you must specify it in the method</para>
        /// </summary>
        public SettingsModel? Settings { get => _settings; set => _settings = value; }

        public AccountSettings() { }

        /// <summary>
        /// Method sets new settings
        /// </summary>
        /// <param name="settings">parameter represents a settings data model object</param>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// new AccountSettings().SetSettings(new SettingsModel()
        /// {
        ///     para1 = value;
        ///     para2 = value;
        ///     ...
        /// });
        /// </code>
        /// 
        ///     OR
        /// 
        /// <code>
        /// var settings = new AccountSettings();
        /// settings.Settings = new SettingsModel()
        /// {
        ///     para1 = value;
        ///     para2 = value;
        ///     ...
        /// };
        /// settings.SetSettings();
        /// </code>
        /// </example>
        public void SetSettings(SettingsModel? settings = null) 
        {
            if (settings == null && _settings == null)
                return;

            if (_settings == null) 
                _settings = settings;
        }
        /// <summary>
        /// Method reset setting. Sets the default values in the property, after which you need to call the SetSettings()
        /// </summary>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var settings = new AccountSettings();
        /// settings.ResetSettings();
        /// settings.SetSettings();
        /// </code>
        /// </example>
        public void ResetSettings()
        {
            
        }
    }
}
