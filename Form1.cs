using static System.Windows.Forms.LinkLabel;
using System;
using Ut3CustomCrosshairs.CustomCrosshair;
using Ut3CustomCrosshairs.Properties;
using System.Drawing;

#nullable enable
namespace Ut3CustomCrosshairs
{
    public partial class Form1 : Form
    {
        private CustomCrosshairHandler crosshairHandler;
        private WeaponStore weaponStore;
        private CustomCrosshairSettings selectedWeaponSettings;     
        private string selectedWeaponName;

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
                weaponStore = new WeaponStore();
                crosshairHandler = new CustomCrosshairHandler(weaponIni, weaponStore);
                Load_Weapon_Settings(
                    WeaponIndex.General.ToString(),                    
                    "General Settings"
                );
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

        private void Load_Weapon_Settings(string weaponSection, string weaponName)
        {
            var temp = crosshairHandler.GetStoreWeapon(weaponSection);
            this.selectedWeaponSettings = new CustomCrosshairSettings()
            {
                WeaponSection = temp.WeaponSection,
                CrosshairColor = temp.CrosshairColor,
                CustomCrosshairCoordinates = temp.CustomCrosshairCoordinates,
                Color = temp.Color,
                UseGeneralColor = temp.UseGeneralColor,
                UseGeneralCoordinates = temp.UseGeneralCoordinates,
            };
            this.selectedWeaponName = weaponName;
            update_weapon_image(weaponSection);
            if (this.selectedWeaponSettings.Color is not null)
            {
                update_color();
                this.opacityBar.Value = this.selectedWeaponSettings.Color.Value.A;
            }
            else
                reset_color();
            this.opacityBar.Value = 255;
            this.weaponLabel.Text = weaponName;
            this.weaponCoordinates.Text = this.selectedWeaponSettings.CustomCrosshairCoordinates;
            this.coordsCheckBox.Checked = this.selectedWeaponSettings.UseGeneralCoordinates;
            this.colorCheckBox.Checked = this.selectedWeaponSettings.UseGeneralColor;
            this.colorBox.Enabled = !this.selectedWeaponSettings.UseGeneralColor;
            this.coordinateBox.Enabled = !this.selectedWeaponSettings.UseGeneralCoordinates;
        }

        //Weapon links handlers
        #region Link handlers
        private void general_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.General.ToString(), "General Settings");
        }

        private void impact_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.ImpactHammer.ToString(), "Impact Hammer");
        }

        private void enforcer_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.Enforcer.ToString(), "Enforcer");
        }

        private void bio_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.BioRifle.ToString(), "Bio Rifle");
        }

        private void shock_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.ShockRifle.ToString(), "Shock Rifle");
        }

        private void linkGun_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.LinkGun.ToString(), "Link Gun");
        }

        private void stinger_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.Stinger.ToString(), "Stinger");
        }

        private void flak_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.FlakCannon.ToString(), "Flak Cannon");
        }

        private void rocket_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.RocketLauncher.ToString(), "Rocket Launcher");
        }

        private void sniper_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.SniperRifle.ToString(), "Sniper Rifle");
        }

        private void translocator_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.Translocator.ToString(), "Translocator");
        }

        private void avril_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.Avril.ToString(), "Avril");
        }

        private void redeemer_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.Redeemer.ToString(), "Redeemer");
        }

        private void instagib_link_click(object sender, EventArgs e)
        {
            Load_Weapon_Settings(WeaponIndex.InstagibRifle.ToString(), "Instagib Rifle");
        }

        #endregion
        private void update_weapon_image(string weaponSection)
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            switch (weaponSection)
            {
                case WeaponIndex.General:
                    this.weaponImgBox.Image = (
                        (System.Drawing.Image)(resources.GetObject("weaponImgBox.Image"))
                    );
                    break;
                case WeaponIndex.ImpactHammer:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .ImpactHammer;
                    break;
                case WeaponIndex.Enforcer:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .Enforcer;
                    break;
                case WeaponIndex.BioRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .BioRifle;
                    break;
                case WeaponIndex.ShockRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .ShockRifle;
                    break;
                case WeaponIndex.LinkGun:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .LinkGun;
                    break;
                case WeaponIndex.Stinger:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .Stinger;
                    break;
                case WeaponIndex.FlakCannon:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .FlakCannon;
                    break;
                case WeaponIndex.RocketLauncher:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .RocketLauncher;
                    break;
                case WeaponIndex.SniperRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .SniperRifle;
                    break;
                case WeaponIndex.Translocator:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .Translocator;
                    break;
                case WeaponIndex.Redeemer:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .Redeemer;
                    break;
                case WeaponIndex.InstagibRifle:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .ShockRifle;
                    break;
                case WeaponIndex.Avril:
                    this.weaponImgBox.Image = global::Ut3CustomCrosshairs
                        .Properties
                        .Resources
                        .Avril;
                    break;
                default:
                    this.weaponImgBox.Image = null;
                    break;
            }
        }

        private void update_color()
        {
            Color c = (Color)this.selectedWeaponSettings.Color;
            this.ColorLabel.BackColor = c;
            this.selectedWeaponSettings.CrosshairColor = $"(R={c.R},G={c.G},B={c.B},A={c.A})";
            this.ColorValueLabel.Text = this.selectedWeaponSettings.CrosshairColor;
            this.ColorLabel.Text = "";
        }

        private void reset_color()
        {
            this.ColorLabel.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.ColorLabel.Text = "Color value not set";
        }

        private void color_button_click(object sender, EventArgs e)
        {
            this.colorDialog.ShowDialog();
            Color c = this.colorDialog.Color;
            this.selectedWeaponSettings.Color = Color.FromArgb(
                this.opacityBar.Value,
                c.R,
                c.G,
                c.B
            );
            update_color();
        }

        private void opacityBar_Scroll(object sender, EventArgs e)
        {
            if (this.selectedWeaponSettings.Color is not null)
            {
                Color c = (Color)this.selectedWeaponSettings.Color;
                this.selectedWeaponSettings.Color = Color.FromArgb(
                    this.opacityBar.Value,
                    c.R,
                    c.G,
                    c.B
                );
                update_color();
            }
        }

        private void saveButton_click(object sender, EventArgs e) {
            crosshairHandler.EditStoreWeapon(this.selectedWeaponSettings);
            MessageBox.Show("Values saved for: " + this.selectedWeaponName, "Save Confirmation");
        }

        private void coordsCheckBox_changed(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.UseGeneralCoordinates = this.coordsCheckBox.Checked;
            this.coordinateBox.Enabled = !this.coordsCheckBox.Checked;
        }

        private void colorCheckBox_changed(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.UseGeneralColor = this.colorCheckBox.Checked;
            this.colorBox.Enabled = !this.colorCheckBox.Checked;
        }
    }
}
