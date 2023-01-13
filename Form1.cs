using static System.Windows.Forms.LinkLabel;
using System;
using Ut3CustomCrosshairs.CustomCrosshair;

namespace Ut3CustomCrosshairs
{
    public partial class Form1 : Form
    {
        private CustomCrosshairHandler crosshairHandler;
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
            this.label1.Text = this.openFileDialog.FileName;
            this.selectFileButton.Dispose();
            IniParser weaponIni = new IniParser(this.openFileDialog.FileName);          
            if (weaponIni is not null)
            {
                //REMEMBER THE TARGETaDHESIONMAXDISTANCE IS DUPLICATED ON UTWEAPON.INI SO THAT IS NOT COPIED TWICE ON THE NEW FILE
                weaponIni.SaveSettings("new.ini");
                crosshairHandler = new CustomCrosshairHandler(weaponIni);
                Load_Initial_Crosshair_Values();
                Load_Initial_Crosshair_Values();
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
        private void generalCustomLink_click(object sender, EventArgs e)
        {
            //Show the custom crosshair builder form -- TO IMPLEMENT
            MessageBox.Show("General Custom Crosshair");
        }

        private void Load_Initial_Crosshair_Values()
        {
            this.GeneralCoordinatesValue.Text = this.crosshairHandler.GetGeneralSettings().CustomCrosshairCoordinates;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
    }
}
