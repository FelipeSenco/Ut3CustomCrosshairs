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

        public CustomCrosshairSettings GetWeaponSettings(string weaponSection)
        {
            string color = weaponIniFile.GetSetting(weaponSection, "CrosshairColor");
            string coordinates = weaponIniFile.GetSetting(weaponSection, "CustomCrosshairCoordinates");
            return new CustomCrosshairSettings()
            {
                CrosshairColor = color,
                CustomCrosshairCoordinates = coordinates,
                Color = ConvertToColor(color),  
            };            
        }  
        
        public Color ConvertToColor(string color)
        {            
            string numberString = "";
            bool wasAddingNumbers = false;
            foreach(char c in color)
            {
                try
                {
                    int.Parse(c.ToString());
                    numberString += c;
                    wasAddingNumbers = true;
                }
                catch (Exception)
                {
                    if (wasAddingNumbers)
                    {
                        numberString += "+";
                        wasAddingNumbers = false;
                    }
                    continue;
                }
            }
            string[] stringNumbers = numberString.Split("+");
            int Rint = Convert.ToInt32(stringNumbers[0]);
            int Gint = Convert.ToInt32(stringNumbers[1]);
            int Bint = Convert.ToInt32(stringNumbers[2]);
            int Aint = Convert.ToInt32(stringNumbers[3]);       
          
            Color convertedColor = Color.FromArgb(Rint,Gint,Bint,Aint);
            
            return convertedColor;
        }
    }
}
