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
        private WeaponStore weaponStore;

        public CustomCrosshairHandler(IniParser iniFile, WeaponStore store)
        {
            weaponIniFile = iniFile;
            weaponStore = store;
            Store_File_Values();
        }

        public CustomCrosshairSettings GetWeaponSettings(string weaponSection)
        {
            string color = weaponIniFile.GetSetting(weaponSection, "CrosshairColor");
            string coordinates = weaponIniFile.GetSetting(
                weaponSection,
                "CustomCrosshairCoordinates"
            );
            return new CustomCrosshairSettings()
            {
                WeaponSection = weaponSection,
                CrosshairColor = color,
                CustomCrosshairCoordinates = coordinates,
                Color = ConvertToColor(color),
                UseGeneralColor = color is null,
                UseGeneralCoordinates = coordinates is null,
                UseSuggestions = false,
            };
        }

        public void SaveWeaponSettings(CustomCrosshairSettings weaponSettings)
        {
            if (
                weaponSettings.CustomCrosshairCoordinates is not null
                && !weaponSettings.UseGeneralCoordinates
            )
                weaponIniFile.AddSetting(
                    weaponSettings.WeaponSection,
                    "CustomCrosshairCoordinates",
                    weaponSettings.CustomCrosshairCoordinates
                );
            else
                weaponIniFile.DeleteSetting(
                    weaponSettings.WeaponSection,
                    "CustomCrosshairCoordinates"
                );

            if (weaponSettings.CrosshairColor is not null && !weaponSettings.UseGeneralColor)
                weaponIniFile.AddSetting(
                    weaponSettings.WeaponSection,
                    "CrosshairColor",
                    weaponSettings.CrosshairColor
                );
            else
                weaponIniFile.DeleteSetting(weaponSettings.WeaponSection, "CrosshairColor");

            EditStoreWeapon(weaponSettings);
        }

        public CustomCrosshairSettings GetStoreWeapon(string weaponSection)
        {
            return weaponStore.AppWeaponSettings.Find(e => e.WeaponSection == weaponSection);
        }

        public void EditStoreWeapon(CustomCrosshairSettings newWeaponSettings)
        {
            var currentSetting = weaponStore.AppWeaponSettings.Find(
                e => e.WeaponSection == newWeaponSettings.WeaponSection
            );
            currentSetting.WeaponSection = newWeaponSettings.WeaponSection;
            currentSetting.CrosshairColor = newWeaponSettings.CrosshairColor;
            currentSetting.CustomCrosshairCoordinates =
            newWeaponSettings.CustomCrosshairCoordinates;
            currentSetting.Color = newWeaponSettings.Color;
            currentSetting.UseGeneralColor = newWeaponSettings.UseGeneralColor;
            currentSetting.UseGeneralCoordinates = newWeaponSettings.UseGeneralCoordinates;
            currentSetting.UseSuggestions = newWeaponSettings.UseSuggestions;
            currentSetting.SuggestionImage = newWeaponSettings.SuggestionImage;
        }

        public void ResetAll()
        {
            this.weaponStore.AppWeaponSettings = new List<CustomCrosshairSettings>();
            this.weaponStore.FileWeaponSettings.ForEach(fileSetting =>{
                var settingCopy = CreateWeaponSettingsCopy(fileSetting);
                this.weaponStore.AppWeaponSettings.Add(settingCopy);
            });
        }

        public void SetGeneralCoordinatesForAll()
        {
            weaponStore.AppWeaponSettings.ForEach(
                (setting) =>
                {
                    if (setting.WeaponSection != WeaponIndex.General)
                    {
                        setting.UseGeneralCoordinates = true;
                    }
                }
            );
            weaponStore.AppWeaponSettings.ForEach(
                (setting) =>
                {
                    if (setting.WeaponSection != WeaponIndex.General)
                    {
                        SaveWeaponSettings(setting);
                    }
                }
            );
        }

        public void SetGeneralColorForAll()
        {
            weaponStore.AppWeaponSettings.ForEach(
                (setting) =>
                {
                    if (setting.WeaponSection != WeaponIndex.General)
                    {
                        setting.UseGeneralColor = true;
                    }
                }
            );
            weaponStore.AppWeaponSettings.ForEach(
                (setting) =>
                {
                    if (setting.WeaponSection != WeaponIndex.General)
                    {
                        SaveWeaponSettings(setting);
                    }
                }
            );
        }

        private void Store_File_Values()
        {
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.General.ToString()));
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.Enforcer.ToString()));
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.BioRifle.ToString()));
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.ShockRifle.ToString())
            );
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.LinkGun.ToString()));
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.Stinger.ToString()));
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.FlakCannon.ToString())
            );
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.RocketLauncher.ToString())
            );
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.SniperRifle.ToString())
            );
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.Translocator.ToString())
            );
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.Redeemer.ToString()));
            weaponStore.FileWeaponSettings.Add(GetWeaponSettings(WeaponIndex.Avril.ToString()));
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.InstagibRifle.ToString())
            );
            weaponStore.FileWeaponSettings.Add(
                GetWeaponSettings(WeaponIndex.ImpactHammer.ToString())
            );

            //Initially will set the app values to be the same as the file values, just so I can load initial data if there is any associated with each weapon
            weaponStore.FileWeaponSettings.ForEach(weaponSetting =>
            {
                var settingCopy = CreateWeaponSettingsCopy(weaponSetting);
                weaponStore.AppWeaponSettings.Add(settingCopy);
            });
        }

        public void SaveFile()
        {
            weaponIniFile.SaveSettings();
        }

        public Color? ConvertToColor(string? color)
        {
            if (color == null)
            {
                return null;
            }
            string numberString = "";
            bool wasAddingNumbers = false;
            foreach (char c in color)
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

            Color convertedColor = Color.FromArgb(Aint, Rint, Gint, Bint);

            return convertedColor;
        }

        public CustomCrosshairSettings CreateWeaponSettingsCopy(
            CustomCrosshairSettings weaponSettings
        )
        {
            var settings = new CustomCrosshairSettings()
            {
                WeaponSection = weaponSettings.WeaponSection,
                CrosshairColor = weaponSettings.CrosshairColor,
                CustomCrosshairCoordinates = weaponSettings.CustomCrosshairCoordinates,
                Color = weaponSettings.Color,
                UseGeneralColor = weaponSettings.UseGeneralColor,
                UseGeneralCoordinates = weaponSettings.UseGeneralCoordinates,
                UseSuggestions = weaponSettings.UseSuggestions,
                SuggestionImage = weaponSettings.SuggestionImage,
            };

            return settings;
        }
    }
}
