using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ut3CustomCrosshairs.CustomCrosshair
{
    public class CustomCrosshairHandler
    {
        private IniParser weaponIniFile;
        public CustomCrosshairHandler(IniParser iniFile)
        {
            weaponIniFile = iniFile;
        }

        public CustomCrosshairSettings GetGeneralSettings()
        {
            string color = weaponIniFile.GetSetting(WeaponIndex.General, "CrosshairColor");
            string coordinates = weaponIniFile.GetSetting(WeaponIndex.General, "CustomCrosshairCoordinates");
            return new CustomCrosshairSettings()
            {
                CrosshairColor = color,
                CustomCrosshairCoordinates = coordinates
            };
        }
    }
}
