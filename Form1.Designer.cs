using Ut3CustomCrosshairs.CustomCrosshair;

namespace Ut3CustomCrosshairs
{
    partial class Form1
    {        
        private readonly string firstLineInfo = "Welcome to the UT3CustomCrosshairs app!\n";
        private readonly string secondLineInfo = "\nTo start the app we need to find your UTWeapon.ini file.\n";
        private readonly string thirdLineInfo = "\nUsusally it is located under:\n";
        private readonly string fourthLineInfo = "C:/ Users /{ your_user}/ Documents / My Games / Unreal Tournament 3 / UTGame / Config";
        private OpenFileDialog openFileDialog;
        private Label label1;
        private Button selectFileButton;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.impactHammerLink = new System.Windows.Forms.LinkLabel();
            this.enforcerLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.enforcerLink6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.enforcerLink0 = new System.Windows.Forms.LinkLabel();
            this.enforcerLink1 = new System.Windows.Forms.LinkLabel();
            this.enforcerLink2 = new System.Windows.Forms.LinkLabel();
            this.weaponImgBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.SetGeneralColorForAllButton = new System.Windows.Forms.Button();
            this.SetGeneralCoordsForAllButton = new System.Windows.Forms.Button();
            this.ResetAllButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.ColorValueLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.coordinateBox = new System.Windows.Forms.GroupBox();
            this.suggestionCheckBox = new System.Windows.Forms.CheckBox();
            this.CoordinatesExampleLabel = new System.Windows.Forms.Label();
            this.weaponCoordinates = new System.Windows.Forms.TextBox();
            this.selectedSuggestionBox = new System.Windows.Forms.PictureBox();
            this.colorCheckBox = new System.Windows.Forms.CheckBox();
            this.coordsCheckBox = new System.Windows.Forms.CheckBox();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ut3DesignWebLink = new System.Windows.Forms.LinkLabel();
            this.crosshairDesignLabel = new System.Windows.Forms.Label();
            this.crosshairDesignSuggestion = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.weaponImgBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.colorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.coordinateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedSuggestionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_File_Dialog1_FileOk);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 42);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(154, 44);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Find UTWeapon.ini";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_click);
            // 
            // impactHammerLink
            // 
            this.impactHammerLink.AutoSize = true;
            this.impactHammerLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.impactHammerLink.Location = new System.Drawing.Point(11, 55);
            this.impactHammerLink.Name = "impactHammerLink";
            this.impactHammerLink.Size = new System.Drawing.Size(122, 21);
            this.impactHammerLink.TabIndex = 2;
            this.impactHammerLink.TabStop = true;
            this.impactHammerLink.Text = "Impact Hammer";
            this.impactHammerLink.Click += new System.EventHandler(this.impact_link_click);
            // 
            // enforcerLink
            // 
            this.enforcerLink.AutoSize = true;
            this.enforcerLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enforcerLink.Location = new System.Drawing.Point(13, 76);
            this.enforcerLink.Name = "enforcerLink";
            this.enforcerLink.Size = new System.Drawing.Size(68, 21);
            this.enforcerLink.TabIndex = 2;
            this.enforcerLink.TabStop = true;
            this.enforcerLink.Text = "Enforcer";
            this.enforcerLink.Click += new System.EventHandler(this.enforcer_link_click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Location = new System.Drawing.Point(13, 97);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 21);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Bio Rifle";
            this.linkLabel2.Click += new System.EventHandler(this.bio_link_click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel3.Location = new System.Drawing.Point(13, 118);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(87, 21);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Shock Rifle";
            this.linkLabel3.Click += new System.EventHandler(this.shock_link_click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel4.Location = new System.Drawing.Point(13, 139);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(72, 21);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Link Gun";
            this.linkLabel4.Click += new System.EventHandler(this.linkGun_link_click);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel5.Location = new System.Drawing.Point(13, 160);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(59, 21);
            this.linkLabel5.TabIndex = 2;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Stinger";
            this.linkLabel5.Click += new System.EventHandler(this.stinger_link_click);
            // 
            // enforcerLink6
            // 
            this.enforcerLink6.AutoSize = true;
            this.enforcerLink6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enforcerLink6.Location = new System.Drawing.Point(11, 19);
            this.enforcerLink6.Name = "enforcerLink6";
            this.enforcerLink6.Size = new System.Drawing.Size(135, 21);
            this.enforcerLink6.TabIndex = 2;
            this.enforcerLink6.TabStop = true;
            this.enforcerLink6.Text = "General Settings";
            this.enforcerLink6.Click += new System.EventHandler(this.general_link_click);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel6.Location = new System.Drawing.Point(11, 181);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(96, 21);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Flak Cannon";
            this.linkLabel6.Click += new System.EventHandler(this.flak_link_click);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel7.Location = new System.Drawing.Point(12, 202);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(125, 21);
            this.linkLabel7.TabIndex = 2;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Rocket Launcher";
            this.linkLabel7.Click += new System.EventHandler(this.rocket_link_click);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel8.Location = new System.Drawing.Point(12, 223);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(90, 21);
            this.linkLabel8.TabIndex = 2;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Sniper Rifle";
            this.linkLabel8.Click += new System.EventHandler(this.sniper_link_click);
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel9.Location = new System.Drawing.Point(12, 244);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(95, 21);
            this.linkLabel9.TabIndex = 2;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Translocator";
            this.linkLabel9.Click += new System.EventHandler(this.translocator_link_click);
            // 
            // enforcerLink0
            // 
            this.enforcerLink0.AutoSize = true;
            this.enforcerLink0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enforcerLink0.Location = new System.Drawing.Point(12, 265);
            this.enforcerLink0.Name = "enforcerLink0";
            this.enforcerLink0.Size = new System.Drawing.Size(42, 21);
            this.enforcerLink0.TabIndex = 2;
            this.enforcerLink0.TabStop = true;
            this.enforcerLink0.Text = "Avril";
            this.enforcerLink0.Click += new System.EventHandler(this.avril_link_click);
            // 
            // enforcerLink1
            // 
            this.enforcerLink1.AutoSize = true;
            this.enforcerLink1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enforcerLink1.Location = new System.Drawing.Point(12, 286);
            this.enforcerLink1.Name = "enforcerLink1";
            this.enforcerLink1.Size = new System.Drawing.Size(81, 21);
            this.enforcerLink1.TabIndex = 2;
            this.enforcerLink1.TabStop = true;
            this.enforcerLink1.Text = "Redeemer";
            this.enforcerLink1.Click += new System.EventHandler(this.redeemer_link_click);
            // 
            // enforcerLink2
            // 
            this.enforcerLink2.AutoSize = true;
            this.enforcerLink2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enforcerLink2.Location = new System.Drawing.Point(11, 308);
            this.enforcerLink2.Name = "enforcerLink2";
            this.enforcerLink2.Size = new System.Drawing.Size(100, 21);
            this.enforcerLink2.TabIndex = 2;
            this.enforcerLink2.TabStop = true;
            this.enforcerLink2.Text = "Instagib Rifle";
            this.enforcerLink2.Click += new System.EventHandler(this.instagib_link_click);
            // 
            // weaponImgBox
            // 
            this.weaponImgBox.Image = ((System.Drawing.Image)(resources.GetObject("weaponImgBox.Image")));
            this.weaponImgBox.Location = new System.Drawing.Point(6, 19);
            this.weaponImgBox.Name = "weaponImgBox";
            this.weaponImgBox.Size = new System.Drawing.Size(608, 389);
            this.weaponImgBox.TabIndex = 4;
            this.weaponImgBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.impactHammerLink);
            this.groupBox1.Controls.Add(this.SaveAndCloseButton);
            this.groupBox1.Controls.Add(this.SetGeneralColorForAllButton);
            this.groupBox1.Controls.Add(this.linkLabel6);
            this.groupBox1.Controls.Add(this.SetGeneralCoordsForAllButton);
            this.groupBox1.Controls.Add(this.ResetAllButton);
            this.groupBox1.Controls.Add(this.enforcerLink);
            this.groupBox1.Controls.Add(this.enforcerLink1);
            this.groupBox1.Controls.Add(this.enforcerLink2);
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.enforcerLink6);
            this.groupBox1.Controls.Add(this.enforcerLink0);
            this.groupBox1.Controls.Add(this.linkLabel7);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel9);
            this.groupBox1.Controls.Add(this.linkLabel8);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 741);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(7, 699);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(288, 33);
            this.SaveAndCloseButton.TabIndex = 8;
            this.SaveAndCloseButton.Text = "Save Changes && Finish";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.saveAll_click);
            // 
            // SetGeneralColorForAllButton
            // 
            this.SetGeneralColorForAllButton.Location = new System.Drawing.Point(9, 602);
            this.SetGeneralColorForAllButton.Name = "SetGeneralColorForAllButton";
            this.SetGeneralColorForAllButton.Size = new System.Drawing.Size(288, 33);
            this.SetGeneralColorForAllButton.TabIndex = 8;
            this.SetGeneralColorForAllButton.Text = "Use General Settings Color for All";
            this.SetGeneralColorForAllButton.UseVisualStyleBackColor = true;
            this.SetGeneralColorForAllButton.Click += new System.EventHandler(this.SetGeneralColorForAllButton_click);
            // 
            // SetGeneralCoordsForAllButton
            // 
            this.SetGeneralCoordsForAllButton.Location = new System.Drawing.Point(7, 554);
            this.SetGeneralCoordsForAllButton.Name = "SetGeneralCoordsForAllButton";
            this.SetGeneralCoordsForAllButton.Size = new System.Drawing.Size(288, 33);
            this.SetGeneralCoordsForAllButton.TabIndex = 8;
            this.SetGeneralCoordsForAllButton.Text = "Use General Settings Coordinates for All";
            this.SetGeneralCoordsForAllButton.UseVisualStyleBackColor = true;
            this.SetGeneralCoordsForAllButton.Click += new System.EventHandler(this.SetGeneralCoordsForAllButton_click);
            // 
            // ResetAllButton
            // 
            this.ResetAllButton.Location = new System.Drawing.Point(7, 652);
            this.ResetAllButton.Name = "ResetAllButton";
            this.ResetAllButton.Size = new System.Drawing.Size(288, 33);
            this.ResetAllButton.TabIndex = 8;
            this.ResetAllButton.Text = "Reset All";
            this.ResetAllButton.UseVisualStyleBackColor = true;
            this.ResetAllButton.Click += new System.EventHandler(this.resetAllButton_click);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleName = "WeaponLabel";
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.colorBox);
            this.groupBox2.Controls.Add(this.coordinateBox);
            this.groupBox2.Controls.Add(this.selectedSuggestionBox);
            this.groupBox2.Controls.Add(this.colorCheckBox);
            this.groupBox2.Controls.Add(this.coordsCheckBox);
            this.groupBox2.Controls.Add(this.weaponLabel);
            this.groupBox2.Controls.Add(this.weaponImgBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(345, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 749);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.Turquoise;
            this.saveButton.Location = new System.Drawing.Point(356, 414);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(258, 36);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save settings for this weapon";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_click);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.label4);
            this.colorBox.Controls.Add(this.opacityLabel);
            this.colorBox.Controls.Add(this.opacityBar);
            this.colorBox.Controls.Add(this.ColorValueLabel);
            this.colorBox.Controls.Add(this.ColorLabel);
            this.colorBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorBox.Location = new System.Drawing.Point(7, 608);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(401, 127);
            this.colorBox.TabIndex = 17;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Click to choose:";
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opacityLabel.Location = new System.Drawing.Point(208, 15);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(122, 15);
            this.opacityLabel.TabIndex = 14;
            this.opacityLabel.Text = "Color Alpha (Opacity)";
            // 
            // opacityBar
            // 
            this.opacityBar.Location = new System.Drawing.Point(174, 33);
            this.opacityBar.Maximum = 255;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(195, 45);
            this.opacityBar.TabIndex = 13;
            this.opacityBar.Scroll += new System.EventHandler(this.opacityBar_Scroll);
            // 
            // ColorValueLabel
            // 
            this.ColorValueLabel.AutoSize = true;
            this.ColorValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorValueLabel.Location = new System.Drawing.Point(103, 84);
            this.ColorValueLabel.Name = "ColorValueLabel";
            this.ColorValueLabel.Size = new System.Drawing.Size(0, 21);
            this.ColorValueLabel.TabIndex = 15;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorLabel.Location = new System.Drawing.Point(27, 45);
            this.ColorLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(100, 20);
            this.ColorLabel.TabIndex = 11;
            this.ColorLabel.Click += new System.EventHandler(this.color_button_click);
            // 
            // coordinateBox
            // 
            this.coordinateBox.Controls.Add(this.suggestionCheckBox);
            this.coordinateBox.Controls.Add(this.CoordinatesExampleLabel);
            this.coordinateBox.Controls.Add(this.weaponCoordinates);
            this.coordinateBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coordinateBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coordinateBox.Location = new System.Drawing.Point(7, 490);
            this.coordinateBox.Name = "coordinateBox";
            this.coordinateBox.Size = new System.Drawing.Size(513, 83);
            this.coordinateBox.TabIndex = 16;
            this.coordinateBox.TabStop = false;
            this.coordinateBox.Text = "Coordinates";
            // 
            // suggestionCheckBox
            // 
            this.suggestionCheckBox.AutoSize = true;
            this.suggestionCheckBox.Location = new System.Drawing.Point(378, 17);
            this.suggestionCheckBox.Name = "suggestionCheckBox";
            this.suggestionCheckBox.Size = new System.Drawing.Size(134, 24);
            this.suggestionCheckBox.TabIndex = 13;
            this.suggestionCheckBox.Text = "Use suggestions";
            this.suggestionCheckBox.UseVisualStyleBackColor = true;
            this.suggestionCheckBox.CheckedChanged += new System.EventHandler(this.suggestionCheckBox_changed);
            // 
            // CoordinatesExampleLabel
            // 
            this.CoordinatesExampleLabel.AutoSize = true;
            this.CoordinatesExampleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoordinatesExampleLabel.Location = new System.Drawing.Point(111, 20);
            this.CoordinatesExampleLabel.Name = "CoordinatesExampleLabel";
            this.CoordinatesExampleLabel.Size = new System.Drawing.Size(210, 19);
            this.CoordinatesExampleLabel.TabIndex = 12;
            this.CoordinatesExampleLabel.Text = "Ex: (U=64,V=101,UL=64,VL=65)";
            // 
            // weaponCoordinates
            // 
            this.weaponCoordinates.AccessibleName = "WeaponCoordinates";
            this.weaponCoordinates.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weaponCoordinates.Location = new System.Drawing.Point(31, 42);
            this.weaponCoordinates.Name = "weaponCoordinates";
            this.weaponCoordinates.Size = new System.Drawing.Size(312, 27);
            this.weaponCoordinates.TabIndex = 7;
            this.weaponCoordinates.TextChanged += new System.EventHandler(this.coordinateText_updated);
            // 
            // selectedSuggestionBox
            // 
            this.selectedSuggestionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectedSuggestionBox.Image = global::Ut3CustomCrosshairs.Properties.Resources.B8;
            this.selectedSuggestionBox.Location = new System.Drawing.Point(523, 497);
            this.selectedSuggestionBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectedSuggestionBox.Name = "selectedSuggestionBox";
            this.selectedSuggestionBox.Size = new System.Drawing.Size(91, 93);
            this.selectedSuggestionBox.TabIndex = 0;
            this.selectedSuggestionBox.TabStop = false;
            this.selectedSuggestionBox.UseWaitCursor = true;
            this.selectedSuggestionBox.Click += new System.EventHandler(this.b8_click);
            // 
            // colorCheckBox
            // 
            this.colorCheckBox.AutoSize = true;
            this.colorCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorCheckBox.Location = new System.Drawing.Point(7, 579);
            this.colorCheckBox.Name = "colorCheckBox";
            this.colorCheckBox.Size = new System.Drawing.Size(288, 23);
            this.colorCheckBox.TabIndex = 8;
            this.colorCheckBox.Text = "Use General Settings color for this weapon";
            this.colorCheckBox.UseVisualStyleBackColor = true;
            this.colorCheckBox.CheckStateChanged += new System.EventHandler(this.colorCheckBox_changed);
            // 
            // coordsCheckBox
            // 
            this.coordsCheckBox.AutoSize = true;
            this.coordsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coordsCheckBox.Location = new System.Drawing.Point(12, 461);
            this.coordsCheckBox.Name = "coordsCheckBox";
            this.coordsCheckBox.Size = new System.Drawing.Size(279, 23);
            this.coordsCheckBox.TabIndex = 8;
            this.coordsCheckBox.Text = "Use General Coordinates for this weapon";
            this.coordsCheckBox.UseVisualStyleBackColor = true;
            this.coordsCheckBox.CheckStateChanged += new System.EventHandler(this.coordsCheckBox_changed);
            // 
            // weaponLabel
            // 
            this.weaponLabel.AccessibleName = "WeaponLabel";
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weaponLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weaponLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.weaponLabel.Location = new System.Drawing.Point(6, 411);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(118, 27);
            this.weaponLabel.TabIndex = 5;
            this.weaponLabel.Text = "placeholder";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox2.Location = new System.Drawing.Point(9, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 68);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            this.pictureBox2.Click += new System.EventHandler(this.a1_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ut3CustomCrosshairs.Properties.Resources.A2;
            this.pictureBox1.Location = new System.Drawing.Point(80, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.a2_click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Ut3CustomCrosshairs.Properties.Resources.A3;
            this.pictureBox3.Location = new System.Drawing.Point(151, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 68);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            this.pictureBox3.Click += new System.EventHandler(this.a3_click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Ut3CustomCrosshairs.Properties.Resources.A4;
            this.pictureBox4.Location = new System.Drawing.Point(222, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 68);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            this.pictureBox4.Click += new System.EventHandler(this.a4_click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Ut3CustomCrosshairs.Properties.Resources.A5;
            this.pictureBox5.Location = new System.Drawing.Point(293, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 68);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.UseWaitCursor = true;
            this.pictureBox5.Click += new System.EventHandler(this.a5_click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Ut3CustomCrosshairs.Properties.Resources.A6;
            this.pictureBox6.Location = new System.Drawing.Point(364, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 68);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.UseWaitCursor = true;
            this.pictureBox6.Click += new System.EventHandler(this.a6_click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox14);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.pictureBox13);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox12);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox42);
            this.groupBox3.Controls.Add(this.pictureBox28);
            this.groupBox3.Controls.Add(this.pictureBox41);
            this.groupBox3.Controls.Add(this.pictureBox21);
            this.groupBox3.Controls.Add(this.pictureBox40);
            this.groupBox3.Controls.Add(this.pictureBox27);
            this.groupBox3.Controls.Add(this.pictureBox39);
            this.groupBox3.Controls.Add(this.pictureBox20);
            this.groupBox3.Controls.Add(this.pictureBox47);
            this.groupBox3.Controls.Add(this.pictureBox38);
            this.groupBox3.Controls.Add(this.pictureBox26);
            this.groupBox3.Controls.Add(this.pictureBox37);
            this.groupBox3.Controls.Add(this.pictureBox17);
            this.groupBox3.Controls.Add(this.pictureBox11);
            this.groupBox3.Controls.Add(this.pictureBox46);
            this.groupBox3.Controls.Add(this.pictureBox36);
            this.groupBox3.Controls.Add(this.pictureBox25);
            this.groupBox3.Controls.Add(this.pictureBox35);
            this.groupBox3.Controls.Add(this.pictureBox19);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox45);
            this.groupBox3.Controls.Add(this.pictureBox34);
            this.groupBox3.Controls.Add(this.pictureBox24);
            this.groupBox3.Controls.Add(this.pictureBox33);
            this.groupBox3.Controls.Add(this.pictureBox16);
            this.groupBox3.Controls.Add(this.pictureBox44);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox32);
            this.groupBox3.Controls.Add(this.pictureBox23);
            this.groupBox3.Controls.Add(this.pictureBox31);
            this.groupBox3.Controls.Add(this.pictureBox18);
            this.groupBox3.Controls.Add(this.pictureBox43);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.pictureBox30);
            this.groupBox3.Controls.Add(this.pictureBox29);
            this.groupBox3.Controls.Add(this.pictureBox22);
            this.groupBox3.Controls.Add(this.pictureBox15);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox8);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(990, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 744);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crosshair Suggetions";
            this.groupBox3.UseWaitCursor = true;
            this.groupBox3.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox14.Image = global::Ut3CustomCrosshairs.Properties.Resources.B5;
            this.pictureBox14.Location = new System.Drawing.Point(433, 107);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(65, 68);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.UseWaitCursor = true;
            this.pictureBox14.Click += new System.EventHandler(this.b5_click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Ut3CustomCrosshairs.Properties.Resources.A7;
            this.pictureBox7.Location = new System.Drawing.Point(433, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 68);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.UseWaitCursor = true;
            this.pictureBox7.Click += new System.EventHandler(this.a7_click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Image = global::Ut3CustomCrosshairs.Properties.Resources.B4;
            this.pictureBox13.Location = new System.Drawing.Point(364, 107);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(65, 68);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.UseWaitCursor = true;
            this.pictureBox13.Click += new System.EventHandler(this.b4_click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::Ut3CustomCrosshairs.Properties.Resources.B3;
            this.pictureBox12.Location = new System.Drawing.Point(293, 107);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(65, 68);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.UseWaitCursor = true;
            this.pictureBox12.Click += new System.EventHandler(this.b3_click);
            // 
            // pictureBox42
            // 
            this.pictureBox42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox42.Image = global::Ut3CustomCrosshairs.Properties.Resources.F4;
            this.pictureBox42.Location = new System.Drawing.Point(151, 413);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(68, 68);
            this.pictureBox42.TabIndex = 0;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.UseWaitCursor = true;
            this.pictureBox42.Click += new System.EventHandler(this.f4_click);
            // 
            // pictureBox28
            // 
            this.pictureBox28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox28.Image = global::Ut3CustomCrosshairs.Properties.Resources.D3;
            this.pictureBox28.Location = new System.Drawing.Point(430, 260);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(68, 73);
            this.pictureBox28.TabIndex = 0;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.UseWaitCursor = true;
            this.pictureBox28.Click += new System.EventHandler(this.d3_click);
            // 
            // pictureBox41
            // 
            this.pictureBox41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox41.Image = global::Ut3CustomCrosshairs.Properties.Resources.E3;
            this.pictureBox41.Location = new System.Drawing.Point(119, 507);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(26, 21);
            this.pictureBox41.TabIndex = 0;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.UseWaitCursor = true;
            this.pictureBox41.Click += new System.EventHandler(this.e3_click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox21.Image = global::Ut3CustomCrosshairs.Properties.Resources.C4;
            this.pictureBox21.Location = new System.Drawing.Point(430, 182);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(65, 68);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.UseWaitCursor = true;
            this.pictureBox21.Click += new System.EventHandler(this.c4_click);
            // 
            // pictureBox40
            // 
            this.pictureBox40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox40.Image = global::Ut3CustomCrosshairs.Properties.Resources.F3;
            this.pictureBox40.Location = new System.Drawing.Point(225, 413);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(65, 68);
            this.pictureBox40.TabIndex = 0;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.UseWaitCursor = true;
            this.pictureBox40.Click += new System.EventHandler(this.f3_click);
            // 
            // pictureBox27
            // 
            this.pictureBox27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox27.Image = global::Ut3CustomCrosshairs.Properties.Resources.D2;
            this.pictureBox27.Location = new System.Drawing.Point(361, 260);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(65, 68);
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.UseWaitCursor = true;
            this.pictureBox27.Click += new System.EventHandler(this.d2_click);
            // 
            // pictureBox39
            // 
            this.pictureBox39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox39.Image = global::Ut3CustomCrosshairs.Properties.Resources.E2;
            this.pictureBox39.Location = new System.Drawing.Point(85, 507);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(27, 24);
            this.pictureBox39.TabIndex = 0;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.UseWaitCursor = true;
            this.pictureBox39.Click += new System.EventHandler(this.e2_click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox20.Image = global::Ut3CustomCrosshairs.Properties.Resources.C3;
            this.pictureBox20.Location = new System.Drawing.Point(361, 182);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(65, 68);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.UseWaitCursor = true;
            this.pictureBox20.Click += new System.EventHandler(this.c3_click);
            // 
            // pictureBox47
            // 
            this.pictureBox47.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox47.Image = global::Ut3CustomCrosshairs.Properties.Resources.G1;
            this.pictureBox47.Location = new System.Drawing.Point(435, 339);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(65, 68);
            this.pictureBox47.TabIndex = 0;
            this.pictureBox47.TabStop = false;
            this.pictureBox47.UseWaitCursor = true;
            this.pictureBox47.Click += new System.EventHandler(this.g1_click);
            // 
            // pictureBox38
            // 
            this.pictureBox38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox38.Image = global::Ut3CustomCrosshairs.Properties.Resources.E6;
            this.pictureBox38.Location = new System.Drawing.Point(80, 413);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(65, 68);
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.UseWaitCursor = true;
            this.pictureBox38.Click += new System.EventHandler(this.e6_click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox26.Image = global::Ut3CustomCrosshairs.Properties.Resources.C7;
            this.pictureBox26.Location = new System.Drawing.Point(148, 260);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(65, 68);
            this.pictureBox26.TabIndex = 0;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.UseWaitCursor = true;
            this.pictureBox26.Click += new System.EventHandler(this.c7_click);
            // 
            // pictureBox37
            // 
            this.pictureBox37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox37.Image = global::Ut3CustomCrosshairs.Properties.Resources.D6;
            this.pictureBox37.Location = new System.Drawing.Point(148, 339);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(65, 68);
            this.pictureBox37.TabIndex = 0;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.UseWaitCursor = true;
            this.pictureBox37.Click += new System.EventHandler(this.d6_click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Image = global::Ut3CustomCrosshairs.Properties.Resources.B8;
            this.pictureBox17.Location = new System.Drawing.Point(148, 182);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(65, 68);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.UseWaitCursor = true;
            this.pictureBox17.Click += new System.EventHandler(this.b8_click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::Ut3CustomCrosshairs.Properties.Resources.B2;
            this.pictureBox11.Location = new System.Drawing.Point(222, 107);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(65, 68);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.UseWaitCursor = true;
            this.pictureBox11.Click += new System.EventHandler(this.b2_click);
            // 
            // pictureBox46
            // 
            this.pictureBox46.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox46.Image = global::Ut3CustomCrosshairs.Properties.Resources.G3;
            this.pictureBox46.Location = new System.Drawing.Point(293, 339);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(65, 68);
            this.pictureBox46.TabIndex = 0;
            this.pictureBox46.TabStop = false;
            this.pictureBox46.UseWaitCursor = true;
            this.pictureBox46.Click += new System.EventHandler(this.g3_click);
            // 
            // pictureBox36
            // 
            this.pictureBox36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox36.Image = global::Ut3CustomCrosshairs.Properties.Resources.F2;
            this.pictureBox36.Location = new System.Drawing.Point(187, 504);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(29, 24);
            this.pictureBox36.TabIndex = 0;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.UseWaitCursor = true;
            this.pictureBox36.Click += new System.EventHandler(this.f2_click);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox25.Image = global::Ut3CustomCrosshairs.Properties.Resources.D1;
            this.pictureBox25.Location = new System.Drawing.Point(290, 260);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(65, 68);
            this.pictureBox25.TabIndex = 0;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.UseWaitCursor = true;
            this.pictureBox25.Click += new System.EventHandler(this.d1_click);
            // 
            // pictureBox35
            // 
            this.pictureBox35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox35.Image = global::Ut3CustomCrosshairs.Properties.Resources.E1;
            this.pictureBox35.Location = new System.Drawing.Point(39, 507);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(40, 33);
            this.pictureBox35.TabIndex = 0;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.UseWaitCursor = true;
            this.pictureBox35.Click += new System.EventHandler(this.e1_click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox19.Image = global::Ut3CustomCrosshairs.Properties.Resources.C2;
            this.pictureBox19.Location = new System.Drawing.Point(290, 182);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(65, 68);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.UseWaitCursor = true;
            this.pictureBox19.Click += new System.EventHandler(this.c2_click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::Ut3CustomCrosshairs.Properties.Resources.B1;
            this.pictureBox10.Location = new System.Drawing.Point(151, 107);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(65, 68);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.UseWaitCursor = true;
            this.pictureBox10.Click += new System.EventHandler(this.b1_click);
            // 
            // pictureBox45
            // 
            this.pictureBox45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox45.Image = global::Ut3CustomCrosshairs.Properties.Resources.F6;
            this.pictureBox45.Location = new System.Drawing.Point(296, 413);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(78, 85);
            this.pictureBox45.TabIndex = 0;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.UseWaitCursor = true;
            this.pictureBox45.Click += new System.EventHandler(this.f6_click);
            // 
            // pictureBox34
            // 
            this.pictureBox34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox34.Image = global::Ut3CustomCrosshairs.Properties.Resources.E5;
            this.pictureBox34.Location = new System.Drawing.Point(6, 413);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(65, 68);
            this.pictureBox34.TabIndex = 0;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.UseWaitCursor = true;
            this.pictureBox34.Click += new System.EventHandler(this.e5_click);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox24.Image = global::Ut3CustomCrosshairs.Properties.Resources.C6;
            this.pictureBox24.Location = new System.Drawing.Point(77, 260);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(65, 68);
            this.pictureBox24.TabIndex = 0;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.UseWaitCursor = true;
            this.pictureBox24.Click += new System.EventHandler(this.c6_click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox33.Image = global::Ut3CustomCrosshairs.Properties.Resources.D5;
            this.pictureBox33.Location = new System.Drawing.Point(77, 339);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(65, 68);
            this.pictureBox33.TabIndex = 0;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.UseWaitCursor = true;
            this.pictureBox33.Click += new System.EventHandler(this.d5_click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox16.Image = global::Ut3CustomCrosshairs.Properties.Resources.B7;
            this.pictureBox16.Location = new System.Drawing.Point(77, 182);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(65, 68);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.UseWaitCursor = true;
            this.pictureBox16.Click += new System.EventHandler(this.b7_click);
            // 
            // pictureBox44
            // 
            this.pictureBox44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox44.Image = global::Ut3CustomCrosshairs.Properties.Resources.G2;
            this.pictureBox44.Location = new System.Drawing.Point(364, 339);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(65, 68);
            this.pictureBox44.TabIndex = 0;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.UseWaitCursor = true;
            this.pictureBox44.Click += new System.EventHandler(this.g2_click);
            // 
            // pictureBox32
            // 
            this.pictureBox32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox32.Image = global::Ut3CustomCrosshairs.Properties.Resources.F1;
            this.pictureBox32.Location = new System.Drawing.Point(380, 413);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(65, 68);
            this.pictureBox32.TabIndex = 0;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.UseWaitCursor = true;
            this.pictureBox32.Click += new System.EventHandler(this.f1_click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox23.Image = global::Ut3CustomCrosshairs.Properties.Resources.C8;
            this.pictureBox23.Location = new System.Drawing.Point(219, 260);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(65, 68);
            this.pictureBox23.TabIndex = 0;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.UseWaitCursor = true;
            this.pictureBox23.Click += new System.EventHandler(this.c8_click);
            // 
            // pictureBox31
            // 
            this.pictureBox31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox31.Image = global::Ut3CustomCrosshairs.Properties.Resources.D7;
            this.pictureBox31.Location = new System.Drawing.Point(219, 339);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(65, 68);
            this.pictureBox31.TabIndex = 0;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.UseWaitCursor = true;
            this.pictureBox31.Click += new System.EventHandler(this.d7_click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox18.Image = global::Ut3CustomCrosshairs.Properties.Resources.C1;
            this.pictureBox18.Location = new System.Drawing.Point(219, 182);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(65, 68);
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.UseWaitCursor = true;
            this.pictureBox18.Click += new System.EventHandler(this.c1_click);
            // 
            // pictureBox43
            // 
            this.pictureBox43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox43.Image = global::Ut3CustomCrosshairs.Properties.Resources.F5;
            this.pictureBox43.Location = new System.Drawing.Point(0, 505);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(33, 32);
            this.pictureBox43.TabIndex = 0;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.UseWaitCursor = true;
            this.pictureBox43.Click += new System.EventHandler(this.f5_click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::Ut3CustomCrosshairs.Properties.Resources.A9;
            this.pictureBox9.Location = new System.Drawing.Point(100, 122);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 20);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.UseWaitCursor = true;
            this.pictureBox9.Click += new System.EventHandler(this.a9_click);
            // 
            // pictureBox30
            // 
            this.pictureBox30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox30.Image = global::Ut3CustomCrosshairs.Properties.Resources.E4;
            this.pictureBox30.Location = new System.Drawing.Point(151, 504);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(30, 27);
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.UseWaitCursor = true;
            this.pictureBox30.Click += new System.EventHandler(this.e4_click);
            // 
            // pictureBox29
            // 
            this.pictureBox29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox29.Image = global::Ut3CustomCrosshairs.Properties.Resources.D4;
            this.pictureBox29.Location = new System.Drawing.Point(6, 339);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(65, 68);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.UseWaitCursor = true;
            this.pictureBox29.Click += new System.EventHandler(this.d4_click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox22.Image = global::Ut3CustomCrosshairs.Properties.Resources.C5;
            this.pictureBox22.Location = new System.Drawing.Point(6, 260);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(65, 68);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.UseWaitCursor = true;
            this.pictureBox22.Click += new System.EventHandler(this.c5_click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = global::Ut3CustomCrosshairs.Properties.Resources.B6;
            this.pictureBox15.Location = new System.Drawing.Point(6, 182);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(65, 68);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.UseWaitCursor = true;
            this.pictureBox15.Click += new System.EventHandler(this.b6_click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Ut3CustomCrosshairs.Properties.Resources.A8;
            this.pictureBox8.Location = new System.Drawing.Point(9, 107);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(65, 68);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.UseWaitCursor = true;
            this.pictureBox8.Click += new System.EventHandler(this.a8_click);
            // 
            // ut3DesignWebLink
            // 
            this.ut3DesignWebLink.AutoSize = true;
            this.ut3DesignWebLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ut3DesignWebLink.Location = new System.Drawing.Point(6, 47);
            this.ut3DesignWebLink.Name = "ut3DesignWebLink";
            this.ut3DesignWebLink.Size = new System.Drawing.Size(281, 19);
            this.ut3DesignWebLink.TabIndex = 9;
            this.ut3DesignWebLink.TabStop = true;
            this.ut3DesignWebLink.Text = "http://ut3.utzone.de/ut3_crosshair_designer/";
            this.ut3DesignWebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ut3DesignWebLink_LinkClicked);
            this.ut3DesignWebLink.Click += new System.EventHandler(this.ut3DesignWebLink_click);
            // 
            // crosshairDesignLabel
            // 
            this.crosshairDesignLabel.AutoSize = true;
            this.crosshairDesignLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crosshairDesignLabel.Location = new System.Drawing.Point(6, 19);
            this.crosshairDesignLabel.Name = "crosshairDesignLabel";
            this.crosshairDesignLabel.Size = new System.Drawing.Size(372, 19);
            this.crosshairDesignLabel.TabIndex = 10;
            this.crosshairDesignLabel.Text = "You can find weapon coordinates at the website link bellow:";
            this.crosshairDesignLabel.Click += new System.EventHandler(this.crosshairDesignLabel_Click);
            // 
            // crosshairDesignSuggestion
            // 
            this.crosshairDesignSuggestion.AutoSize = true;
            this.crosshairDesignSuggestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crosshairDesignSuggestion.Location = new System.Drawing.Point(6, 78);
            this.crosshairDesignSuggestion.Name = "crosshairDesignSuggestion";
            this.crosshairDesignSuggestion.Size = new System.Drawing.Size(520, 38);
            this.crosshairDesignSuggestion.TabIndex = 10;
            this.crosshairDesignSuggestion.Text = "You can input your desired coordinates on the coordinates box.\nOr you can also us" +
    "e premade suggestions by checking the \"Use uggestions\" option.";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(1301, 735);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(212, 15);
            this.creditsLabel.TabIndex = 11;
            this.creditsLabel.Text = "Developed by Felipe \"Drackz\" de Senco";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.crosshairDesignLabel);
            this.groupBox4.Controls.Add(this.ut3DesignWebLink);
            this.groupBox4.Controls.Add(this.crosshairDesignSuggestion);
            this.groupBox4.Location = new System.Drawing.Point(991, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 155);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 759);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ink";
            ((System.ComponentModel.ISupportInitialize)(this.weaponImgBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.coordinateBox.ResumeLayout(false);
            this.coordinateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedSuggestionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion     

        private LinkLabel impactHammerLink;
        private LinkLabel enforcerLink;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel enforcerLink6;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private LinkLabel linkLabel8;
        private LinkLabel linkLabel9;
        private LinkLabel enforcerLink0;
        private LinkLabel enforcerLink1;
        private LinkLabel enforcerLink2;
        private PictureBox weaponImgBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private GroupBox groupBox3;
        private PictureBox pictureBox14;
        private PictureBox pictureBox7;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox17;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox16;
        private PictureBox pictureBox9;
        private PictureBox pictureBox15;
        private PictureBox pictureBox8;
        private Label weaponLabel;
        private TextBox weaponCoordinates;
        private Label ColorLabel;
        private CheckBox coordsCheckBox;
        private ColorDialog colorDialog;
        private Label CoordinatesExampleLabel;
        private Label opacityLabel;
        private TrackBar opacityBar;
        private Label ColorValueLabel;
        private GroupBox colorBox;
        private Label label4;
        private GroupBox coordinateBox;
        private Button saveButton;
        private CheckBox colorCheckBox;
        private PictureBox selectedSuggestionBox;
        private CheckBox suggestionCheckBox;
        private Button ResetAllButton;
        private Button SaveAndCloseButton;
        private ToolTip toolTip1;
        private Button SetGeneralCoordsForAllButton;
        private Button SetGeneralColorForAllButton;
        private PictureBox pictureBox42;
        private PictureBox pictureBox28;
        private PictureBox pictureBox41;
        private PictureBox pictureBox21;
        private PictureBox pictureBox40;
        private PictureBox pictureBox27;
        private PictureBox pictureBox39;
        private PictureBox pictureBox20;
        private PictureBox pictureBox47;
        private PictureBox pictureBox38;
        private PictureBox pictureBox26;
        private PictureBox pictureBox37;
        private PictureBox pictureBox46;
        private PictureBox pictureBox36;
        private PictureBox pictureBox25;
        private PictureBox pictureBox35;
        private PictureBox pictureBox19;
        private PictureBox pictureBox45;
        private PictureBox pictureBox34;
        private PictureBox pictureBox24;
        private PictureBox pictureBox33;
        private PictureBox pictureBox44;
        private PictureBox pictureBox32;
        private PictureBox pictureBox23;
        private PictureBox pictureBox31;
        private PictureBox pictureBox18;
        private PictureBox pictureBox43;
        private PictureBox pictureBox30;
        private PictureBox pictureBox29;
        private PictureBox pictureBox22;
        private LinkLabel ut3DesignWebLink;
        private Label crosshairDesignLabel;
        private Label crosshairDesignSuggestion;
        private Label creditsLabel;
        private GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}