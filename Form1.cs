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
            this.suggestionCheckBox.Checked = this.selectedWeaponSettings.UseSuggestions;
            this.groupBox3.Enabled = this.suggestionCheckBox.Checked;
            this.selectedSuggestionBox.Image = this.selectedWeaponSettings.SuggestionImage;
        }
               
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

        #region handlers
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
        #endregion

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

        #region Suggetions Handlers
        private void a1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A1;
            this.selectedWeaponSettings.SuggestionImage = Resources.A1;
            this.selectedSuggestionBox.Image = Resources.A1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A1;           
        }
         private void a2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A2;
            this.selectedWeaponSettings.SuggestionImage = Resources.A2;
            this.selectedSuggestionBox.Image = Resources.A2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A2;
        }
         private void a3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A3;
            this.selectedWeaponSettings.SuggestionImage = Resources.A3;
            this.selectedSuggestionBox.Image = Resources.A3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A3;
        }
         private void a4_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A4;
            this.selectedWeaponSettings.SuggestionImage = Resources.A4;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A4;
        }
         private void a5_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A5;
            this.selectedWeaponSettings.SuggestionImage = Resources.A5;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A5;
        }
         private void a6_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A6;
            this.selectedWeaponSettings.SuggestionImage = Resources.A6;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A6;
        }
         private void a7_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A7;
            this.selectedWeaponSettings.SuggestionImage = Resources.A7;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A7;
        }
         private void a8_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A8;
            this.selectedWeaponSettings.SuggestionImage = Resources.A8;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A8;
        }
        private void a9_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.A9;
            this.selectedWeaponSettings.SuggestionImage = Resources.A9;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.A9;
        }
        private void b1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B1;
            this.selectedWeaponSettings.SuggestionImage = Resources.B1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B1;
        }
         private void b2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B2;
            this.selectedWeaponSettings.SuggestionImage = Resources.B2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B2;
        }
         private void b3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B3;
            this.selectedWeaponSettings.SuggestionImage = Resources.B3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B3;
        }
         private void b4_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B4;
            this.selectedWeaponSettings.SuggestionImage = Resources.B4;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B4;
        }
         private void b5_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B5;
            this.selectedWeaponSettings.SuggestionImage = Resources.B5;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B5;
        }
         private void b6_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B6;
            this.selectedWeaponSettings.SuggestionImage = Resources.B6;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B6;
        }
         private void b7_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B7;
            this.selectedWeaponSettings.SuggestionImage = Resources.B7;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B7;
        }
         private void b8_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.B8;
            this.selectedWeaponSettings.SuggestionImage = Resources.B8;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.B8;
        }
        private void c1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C1;
        }
         private void c2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C2;
        }
         private void c3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C3;
        }
         private void c4_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C4;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C4;
        }
         private void c5_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C5;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C5;
        }
         private void c6_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C6;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C6;
        }
         private void c7_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C7;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C7;
        }
         private void c8_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.C8;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.C8;
        }
        private void d1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D1;
        }
         private void d2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D2;
        }
         private void d3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D3;
        }
         private void d4_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D4;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D4;
        }
         private void d5_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D5;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D5;
        }
         private void d6_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D6;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D6;
        }
         private void d7_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.D7;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.D7;
        }
        private void e1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.E1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.E1;
        }
         private void e2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.E2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.E2;
        }
         private void e3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.E3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.E3;
        }
         private void e4_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.E4;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.E4;
        }
         private void e5_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.E5;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.E5;
        }
         private void e6_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.E6;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.E6;
        }
        private void f1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.F1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.F1;
        }
         private void f2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.F2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.F2;
        }
         private void f3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.F3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.F3;
        }
         private void f4_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.F4;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.F4;
        }
         private void f5_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.F5;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.F5;
        }
         private void f6_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.F6;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.F6;
        }
        private void g1_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.G1;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.G1;
        }
         private void g2_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.G2;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.G2;
        }
         private void g3_click(object sender, EventArgs e)
        {
            this.selectedWeaponSettings.CustomCrosshairCoordinates = CrosshairSuggestionsCoordinates.G3;
            this.weaponCoordinates.Text = CrosshairSuggestionsCoordinates.G3;
        }

        #endregion
    }
}
