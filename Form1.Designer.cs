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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weaponImgBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.ColorValueLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.coordinateBox = new System.Windows.Forms.GroupBox();
            this.CoordinatesExampleLabel = new System.Windows.Forms.Label();
            this.weaponCoordinates = new System.Windows.Forms.TextBox();
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
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.weaponImgBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.colorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.coordinateBox.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            this.impactHammerLink.Location = new System.Drawing.Point(1, 87);
            this.impactHammerLink.Name = "impactHammerLink";
            this.impactHammerLink.Size = new System.Drawing.Size(94, 15);
            this.impactHammerLink.TabIndex = 2;
            this.impactHammerLink.TabStop = true;
            this.impactHammerLink.Text = "Impact Hammer";
            this.impactHammerLink.Click += new System.EventHandler(this.impact_link_click);
            // 
            // enforcerLink
            // 
            this.enforcerLink.AutoSize = true;
            this.enforcerLink.Location = new System.Drawing.Point(2, 102);
            this.enforcerLink.Name = "enforcerLink";
            this.enforcerLink.Size = new System.Drawing.Size(51, 15);
            this.enforcerLink.TabIndex = 2;
            this.enforcerLink.TabStop = true;
            this.enforcerLink.Text = "Enforcer";
            this.enforcerLink.Click += new System.EventHandler(this.enforcer_link_click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 117);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(50, 15);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Bio Rifle";
            this.linkLabel2.Click += new System.EventHandler(this.bio_link_click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 132);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(65, 15);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Shock Rifle";
            this.linkLabel3.Click += new System.EventHandler(this.shock_link_click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(3, 147);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(54, 15);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Link Gun";
            this.linkLabel4.Click += new System.EventHandler(this.linkGun_link_click);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(1, 162);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(44, 15);
            this.linkLabel5.TabIndex = 2;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Stinger";
            this.linkLabel5.Click += new System.EventHandler(this.stinger_link_click);
            // 
            // enforcerLink6
            // 
            this.enforcerLink6.AutoSize = true;
            this.enforcerLink6.Location = new System.Drawing.Point(1, 72);
            this.enforcerLink6.Name = "enforcerLink6";
            this.enforcerLink6.Size = new System.Drawing.Size(92, 15);
            this.enforcerLink6.TabIndex = 2;
            this.enforcerLink6.TabStop = true;
            this.enforcerLink6.Text = "General Settings";
            this.enforcerLink6.Click += new System.EventHandler(this.general_link_click);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(2, 177);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(73, 15);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Flak Cannon";
            this.linkLabel6.Click += new System.EventHandler(this.flak_link_click);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(3, 192);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(95, 15);
            this.linkLabel7.TabIndex = 2;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Rocket Launcher";
            this.linkLabel7.Click += new System.EventHandler(this.rocket_link_click);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(1, 207);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(66, 15);
            this.linkLabel8.TabIndex = 2;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Sniper Rifle";
            this.linkLabel8.Click += new System.EventHandler(this.sniper_link_click);
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(1, 222);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(71, 15);
            this.linkLabel9.TabIndex = 2;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Translocator";
            this.linkLabel9.Click += new System.EventHandler(this.translocator_link_click);
            // 
            // enforcerLink0
            // 
            this.enforcerLink0.AutoSize = true;
            this.enforcerLink0.Location = new System.Drawing.Point(3, 237);
            this.enforcerLink0.Name = "enforcerLink0";
            this.enforcerLink0.Size = new System.Drawing.Size(31, 15);
            this.enforcerLink0.TabIndex = 2;
            this.enforcerLink0.TabStop = true;
            this.enforcerLink0.Text = "Avril";
            this.enforcerLink0.Click += new System.EventHandler(this.avril_link_click);
            // 
            // enforcerLink1
            // 
            this.enforcerLink1.AutoSize = true;
            this.enforcerLink1.Location = new System.Drawing.Point(2, 252);
            this.enforcerLink1.Name = "enforcerLink1";
            this.enforcerLink1.Size = new System.Drawing.Size(60, 15);
            this.enforcerLink1.TabIndex = 2;
            this.enforcerLink1.TabStop = true;
            this.enforcerLink1.Text = "Redeemer";
            this.enforcerLink1.Click += new System.EventHandler(this.redeemer_link_click);
            // 
            // enforcerLink2
            // 
            this.enforcerLink2.AutoSize = true;
            this.enforcerLink2.Location = new System.Drawing.Point(2, 267);
            this.enforcerLink2.Name = "enforcerLink2";
            this.enforcerLink2.Size = new System.Drawing.Size(75, 15);
            this.enforcerLink2.TabIndex = 2;
            this.enforcerLink2.TabStop = true;
            this.enforcerLink2.Text = "Instagib Rifle";
            this.enforcerLink2.Click += new System.EventHandler(this.instagib_link_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "If there is no custom value associated with a weapon,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "The general settings will be used for that weapon.";
            // 
            // weaponImgBox
            // 
            this.weaponImgBox.Image = ((System.Drawing.Image)(resources.GetObject("weaponImgBox.Image")));
            this.weaponImgBox.Location = new System.Drawing.Point(7, 19);
            this.weaponImgBox.Name = "weaponImgBox";
            this.weaponImgBox.Size = new System.Drawing.Size(608, 389);
            this.weaponImgBox.TabIndex = 4;
            this.weaponImgBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.impactHammerLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.linkLabel6);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 298);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleName = "WeaponLabel";
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.colorBox);
            this.groupBox2.Controls.Add(this.coordinateBox);
            this.groupBox2.Controls.Add(this.colorCheckBox);
            this.groupBox2.Controls.Add(this.coordsCheckBox);
            this.groupBox2.Controls.Add(this.weaponLabel);
            this.groupBox2.Controls.Add(this.weaponImgBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 746);
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
            this.saveButton.Location = new System.Drawing.Point(418, 421);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 63);
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
            this.ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorLabel.Location = new System.Drawing.Point(27, 45);
            this.ColorLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(100, 22);
            this.ColorLabel.TabIndex = 11;
            this.ColorLabel.Click += new System.EventHandler(this.color_button_click);
            // 
            // coordinateBox
            // 
            this.coordinateBox.Controls.Add(this.CoordinatesExampleLabel);
            this.coordinateBox.Controls.Add(this.weaponCoordinates);
            this.coordinateBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coordinateBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coordinateBox.Location = new System.Drawing.Point(7, 490);
            this.coordinateBox.Name = "coordinateBox";
            this.coordinateBox.Size = new System.Drawing.Size(349, 80);
            this.coordinateBox.TabIndex = 16;
            this.coordinateBox.TabStop = false;
            this.coordinateBox.Text = "Coordinates";
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
            this.weaponLabel.Location = new System.Drawing.Point(5, 420);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox14);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.pictureBox13);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox12);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox17);
            this.groupBox3.Controls.Add(this.pictureBox11);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox16);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.pictureBox15);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox8);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(1012, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 590);
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
            this.pictureBox14.Location = new System.Drawing.Point(433, 111);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(65, 68);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.UseWaitCursor = true;
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
            // 
            // pictureBox13
            // 
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Image = global::Ut3CustomCrosshairs.Properties.Resources.B4;
            this.pictureBox13.Location = new System.Drawing.Point(364, 111);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(65, 68);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.UseWaitCursor = true;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::Ut3CustomCrosshairs.Properties.Resources.B3;
            this.pictureBox12.Location = new System.Drawing.Point(293, 111);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(65, 68);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.UseWaitCursor = true;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Image = global::Ut3CustomCrosshairs.Properties.Resources.B8;
            this.pictureBox17.Location = new System.Drawing.Point(151, 190);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(65, 68);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.UseWaitCursor = true;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::Ut3CustomCrosshairs.Properties.Resources.B2;
            this.pictureBox11.Location = new System.Drawing.Point(222, 111);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(65, 68);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.UseWaitCursor = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::Ut3CustomCrosshairs.Properties.Resources.B1;
            this.pictureBox10.Location = new System.Drawing.Point(151, 111);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(65, 68);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.UseWaitCursor = true;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox16.Image = global::Ut3CustomCrosshairs.Properties.Resources.B7;
            this.pictureBox16.Location = new System.Drawing.Point(80, 190);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(65, 68);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.UseWaitCursor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::Ut3CustomCrosshairs.Properties.Resources.A9;
            this.pictureBox9.Location = new System.Drawing.Point(100, 126);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 20);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.UseWaitCursor = true;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = global::Ut3CustomCrosshairs.Properties.Resources.B6;
            this.pictureBox15.Location = new System.Drawing.Point(9, 190);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(65, 68);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.UseWaitCursor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Ut3CustomCrosshairs.Properties.Resources.A8;
            this.pictureBox8.Location = new System.Drawing.Point(9, 111);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(65, 68);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 759);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
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
        private Label label2;
        private Label label3;
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
    }
}