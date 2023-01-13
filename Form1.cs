using static System.Windows.Forms.LinkLabel;
using System;
using Ut3CustomCrosshairs.CustomCrosshair;

namespace Ut3CustomCrosshairs
{
    public partial class Form1 : Form
    {
        private CustomCrosshairHandler crosshairHandler;
        private bool showWeaponElements = false;
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
            showWeaponElements = true;
            this.label1.Dispose();
            this.selectFileButton.Dispose();
            IniParser weaponIni = new IniParser(this.openFileDialog.FileName);          
            if (weaponIni is not null)
            {
                //REMEMBER THE TARGETaDHESIONMAXDISTANCE IS DUPLICATED ON UTWEAPON.INI SO THAT IS NOT COPIED TWICE ON THE NEW FILE               
                crosshairHandler = new CustomCrosshairHandler(weaponIni);                                                      
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

       

        //Weapon links handlers
        private void general_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.General.ToString());
        }
        private void impact_link_click(object sender, EventArgs e)    
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.ImpactHammer.ToString());
        }

        private void enforcer_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.Enforcer.ToString());
        }

        private void bio_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.BioRifle.ToString());
        }

        private void shock_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.ShockRifle.ToString());
        }

        private void linkGun_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.LinkGun.ToString());
        }

        private void stinger_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.Stinger.ToString());
        }

        private void flak_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.FlakCannon.ToString());
        }

        private void rocket_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.RocketLauncher.ToString());
        }

        private void sniper_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.SniperRifle.ToString());
        }

        private void translocator_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.Translocator.ToString());
        }

        private void avril_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.Avril.ToString());
        }

        private void redeemer_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.Redeemer.ToString());
        }

        private void instagib_link_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show(WeaponIndex.InstagibRifle.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
