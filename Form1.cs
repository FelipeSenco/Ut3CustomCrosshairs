using static System.Windows.Forms.LinkLabel;
using System;
using Ut3CustomCrosshairs.CustomCrosshair;
using Ut3CustomCrosshairs.Properties;

#nullable enable
namespace Ut3CustomCrosshairs
{    
    public partial class Form1 : Form
    {
        private CustomCrosshairHandler crosshairHandler;
        private WeaponStore weaponStore;
        private CustomCrosshairSettings selectedWeaponSettings;
        public Form1()
        {            
            InitializeComponent();        
            MessageBox.Show(
                firstLineInfo + secondLineInfo + thirdLineInfo + fourthLineInfo,
                "UT3 Custom Crosshairs"
            );
            this.openFileDialog.ShowDialog();
        }

        private void Open_File_Dialog1_FileOk(object sender, EventArgs e)
        {
            string chosenFilePath = this.openFileDialog.FileName;
            if (File_Path_isCorrect(chosenFilePath))
            {
                Custom_Crosshairs_Initial_Setup();
            }
            else
            {
                File_Incorrect_Setup();
            }
        }

        private void selectFileButton_click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void Custom_Crosshairs_Initial_Setup()
        {         
            this.label1.Dispose();
            this.selectFileButton.Dispose();
            IniParser weaponIni = new IniParser(this.openFileDialog.FileName);          
            if (weaponIni is not null)
            {
                Show_App_Boxes();
                //REMEMBER THE TARGETaDHESIONMAXDISTANCE IS DUPLICATED ON UTWEAPON.INI SO THAT IS NOT COPIED TWICE ON THE NEW FILE               
                crosshairHandler = new CustomCrosshairHandler(weaponIni);   
                weaponStore = new WeaponStore(crosshairHandler);
                Load_Weapon_Settings(WeaponIndex.General.ToString(), this.weaponStore.generalSettings, "General Settings");
            }
        }

        private void File_Incorrect_Setup()
        {
            this.label1.Text =
                "The UTWeapon.ini file path is not working. Please use the button to try again:";
        }

        private bool File_Path_isCorrect(string filePath)
        {
            return filePath.Contains("UTWeapon.ini");
        }    

        private void Show_App_Boxes()
        {
            this.groupBox1.Visible = true;
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = true;
        }

        private void Load_Weapon_Settings(string weaponSection, CustomCrosshairSettings weaponSettings, string weaponName)
        {
            this.selectedWeaponSettings = weaponSettings;
            update_weapon_image(weaponSection);
            if (this.selectedWeaponSettings.Color is not null)
                update_color((Color)this.selectedWeaponSettings.Color);
            else
                reset_color();
            this.weaponLabel.Text = weaponName;
            this.weaponCoordinates.Text = this.selectedWeaponSettings.CustomCrosshairCoordinates;  
            
        }

        //Weapon links handlers
        #region Link handlers
        private void general_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.General.ToString(), this.weaponStore.generalSettings, "General Settings");
        }
        private void impact_link_click(object sender, EventArgs e)    
        {
            
            Load_Weapon_Settings(WeaponIndex.ImpactHammer.ToString(), this.weaponStore.impactSettings, "Impact Hammer");
        }

        private void enforcer_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.Enforcer.ToString(), this.weaponStore.enforcerSettings, "Enforcer");
        }

        private void bio_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.BioRifle.ToString(), this.weaponStore.bioSettings, "Bio Rifle");
        }

        private void shock_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.ShockRifle.ToString(), this.weaponStore.shockSettings, "Shock Rifle");
        }

        private void linkGun_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.LinkGun.ToString(), this.weaponStore.linkSettings, "Link Gun");
        }

        private void stinger_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.Stinger.ToString(), this.weaponStore.stingerSettings, "Stinger");
        }

        private void flak_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.FlakCannon.ToString(), this.weaponStore.flakSettings, "Flak Cannon");
        }

        private void rocket_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.RocketLauncher.ToString(), this.weaponStore.rocketSettings, "Rocket Launcher");
        }

        private void sniper_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.SniperRifle.ToString(), this.weaponStore.sniperSettings, "Sniper Rifle");
        }

        private void translocator_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.Translocator.ToString(), this.weaponStore.translocatorSettings, "Translocator");
        }

        private void avril_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.Avril.ToString(), this.weaponStore.avrilSettings, "Avril");
        }

        private void redeemer_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.Redeemer.ToString(), this.weaponStore.redeemerSettings, "Redeemer");
        }

        private void instagib_link_click(object sender, EventArgs e)
        {
            
            Load_Weapon_Settings(WeaponIndex.InstagibRifle.ToString(), this.weaponStore.instaSettings, "Instagib Rifle");
        }

        #endregion
        private void update_weapon_image(string weaponSection)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            switch (weaponSection)
            {
                case WeaponIndex.General:
                    this.weaponImgBox.Image = ((System.Drawing.Image)(resources.GetObject("weaponImgBox.Image")));
                    break;
                case WeaponIndex.ImpactHammer:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.ImpactHammer;
                    break;
                case WeaponIndex.Enforcer:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.Enforcer;
                    break;
                case WeaponIndex.BioRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.BioRifle;
                    break;
                case WeaponIndex.ShockRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.ShockRifle;
                    break;
                case WeaponIndex.LinkGun:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.LinkGun;
                    break;
                case WeaponIndex.Stinger:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.Stinger;
                    break;
                case WeaponIndex.FlakCannon:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.FlakCannon;
                    break;
                case WeaponIndex.RocketLauncher:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.RocketLauncher;
                    break;
                case WeaponIndex.SniperRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.SniperRifle;
                    break;
                case WeaponIndex.Translocator:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.Translocator;
                    break;
                case WeaponIndex.Redeemer:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.Redeemer;
                    break;
                case WeaponIndex.InstagibRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.ShockRifle;
                    break;
                case WeaponIndex.Avril:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.Avril;
                    break;
                default:
                    this.weaponImgBox.Image = null;
                    break;
            }
        }

        private void update_color(Color color)
        {                                    
                this.ColorLabel.BackColor = (Color)color;
                this.selectedWeaponSettings.CrosshairColor = $"(R={color.R},G={color.G},B={color.B},A={color.A})";            
        }
        private void reset_color()
        {
            this.ColorLabel.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.selectedWeaponSettings.CrosshairColor = null;
        }

        private void color_button_click(object sender, EventArgs e)
        {
            this.colorDialog.ShowDialog();
            Color color = this.colorDialog.Color;
            update_color(color);
        }      
    }
}
