using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ut3CustomCrosshairs.CustomCrosshair
{
    internal class WeaponStore
    {
        private CustomCrosshairHandler crosshairHandler;
        //Settings property that will be populated from the ini file, this is stored so it can be reset using the 'Restore File Settings' button
        public CustomCrosshairSettings? generalFileSettings;
        public CustomCrosshairSettings? enforcerFileSettings;
        public CustomCrosshairSettings? bioFileSettings;
        public CustomCrosshairSettings? shockFileSettings;
        public CustomCrosshairSettings? linkFileSettings;
        public CustomCrosshairSettings? stingerFileSettings;
        public CustomCrosshairSettings? flakFileSettings;
        public CustomCrosshairSettings? rocketFileSettings;
        public CustomCrosshairSettings? sniperFileSettings;
        public CustomCrosshairSettings? translocatorFileSettings;
        public CustomCrosshairSettings? avrilFileSettings;
        public CustomCrosshairSettings? redeemerFileSettings;
        public CustomCrosshairSettings? instaFileSettings;
        public CustomCrosshairSettings? impactFileSettings;

        //Settings property that will be populated from the customizer
        public CustomCrosshairSettings? generalSettings;
        public CustomCrosshairSettings? enforcerSettings;
        public CustomCrosshairSettings? bioSettings;
        public CustomCrosshairSettings? shockSettings;
        public CustomCrosshairSettings? linkSettings;
        public CustomCrosshairSettings? stingerSettings;
        public CustomCrosshairSettings? flakSettings;
        public CustomCrosshairSettings? rocketSettings;
        public CustomCrosshairSettings? sniperSettings;
        public CustomCrosshairSettings? translocatorSettings;
        public CustomCrosshairSettings? avrilSettings;
        public CustomCrosshairSettings? redeemerSettings;
        public CustomCrosshairSettings? instaSettings;
        public CustomCrosshairSettings? impactSettings;      
        public WeaponStore(CustomCrosshairHandler handler)
        {
            crosshairHandler = handler;
            Store_File_Values();
        }
        
        private void Store_File_Values()
        {
            this.generalFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.General.ToString());   
            this.enforcerFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.Enforcer.ToString());
            this.bioFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.BioRifle.ToString());
            this.shockFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.ShockRifle.ToString());
            this.linkFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.LinkGun.ToString());
            this.stingerFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.Stinger.ToString());
            this.flakFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.FlakCannon.ToString());
            this.rocketFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.RocketLauncher.ToString());
            this.sniperFileSettings = crosshairHandler.GetWeaponSettings(WeaponIndex.SniperRifle.ToString());
            this.translocatorFileSettings= crosshairHandler.GetWeaponSettings(WeaponIndex.Translocator.ToString());
            this.avrilFileSettings= crosshairHandler.GetWeaponSettings(WeaponIndex.Avril.ToString());
            this.redeemerFileSettings= crosshairHandler.GetWeaponSettings(WeaponIndex.Redeemer.ToString());
            this.instaFileSettings= crosshairHandler.GetWeaponSettings(WeaponIndex.InstagibRifle.ToString());
            this.impactFileSettings= crosshairHandler.GetWeaponSettings(WeaponIndex.ImpactHammer.ToString());

            //Initially will set the app values to be the same as the file values, just so I can load initial data if there is any associated with each weapon
            this.generalSettings = this.generalFileSettings;
            this.enforcerSettings= this.enforcerFileSettings;
            this.bioSettings = this.bioFileSettings;
            this.shockSettings = this.shockFileSettings;
            this.linkSettings= this.linkFileSettings;
            this.stingerSettings= this.stingerFileSettings;
            this.flakSettings= this.flakFileSettings;
            this.rocketSettings= this.rocketFileSettings;
            this.sniperSettings= this.sniperFileSettings;
            this.translocatorSettings= this.translocatorFileSettings;
            this.avrilSettings= this.avrilFileSettings;
            this.redeemerSettings= this.redeemerFileSettings;
            this.instaSettings= this.instaFileSettings;
            this.impactSettings= this.impactFileSettings;
        }
    }
}
