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
            this.ColorLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.CheckBoxLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.weaponCoordinates = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.weaponImgBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
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
            this.groupBox2.Controls.Add(this.ColorLabel);
            this.groupBox2.Controls.Add(this.colorButton);
            this.groupBox2.Controls.Add(this.CheckBoxLabel);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.weaponCoordinates);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.weaponLabel);
            this.groupBox2.Controls.Add(this.weaponImgBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 656);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ColorLabel.Location = new System.Drawing.Point(159, 526);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(117, 25);
            this.ColorLabel.TabIndex = 11;
            this.ColorLabel.Text = "                     ";
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(8, 520);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(132, 36);
            this.colorButton.TabIndex = 10;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.color_button_click);
            // 
            // CheckBoxLabel
            // 
            this.CheckBoxLabel.AutoSize = true;
            this.CheckBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxLabel.Location = new System.Drawing.Point(3, 601);
            this.CheckBoxLabel.Name = "CheckBoxLabel";
            this.CheckBoxLabel.Size = new System.Drawing.Size(308, 15);
            this.CheckBoxLabel.TabIndex = 9;
            this.CheckBoxLabel.Text = "If this is unchecked, this weapon will use General Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(7, 621);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 23);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Use this settings";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // weaponCoordinates
            // 
            this.weaponCoordinates.AccessibleName = "WeaponCoordinates";
            this.weaponCoordinates.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weaponCoordinates.Location = new System.Drawing.Point(159, 457);
            this.weaponCoordinates.Name = "weaponCoordinates";
            this.weaponCoordinates.Size = new System.Drawing.Size(312, 27);
            this.weaponCoordinates.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Custom Coordinates:";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AccessibleName = "WeaponLabel";
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weaponLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.weaponLabel.Location = new System.Drawing.Point(5, 420);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(118, 27);
            this.weaponLabel.TabIndex = 5;
            this.weaponLabel.Text = "placeholder";
            // 
            // pictureBox2
            // 
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
            this.groupBox3.Controls.Add(this.pictureBox49);
            this.groupBox3.Controls.Add(this.pictureBox42);
            this.groupBox3.Controls.Add(this.pictureBox35);
            this.groupBox3.Controls.Add(this.pictureBox28);
            this.groupBox3.Controls.Add(this.pictureBox21);
            this.groupBox3.Controls.Add(this.pictureBox14);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.pictureBox48);
            this.groupBox3.Controls.Add(this.pictureBox41);
            this.groupBox3.Controls.Add(this.pictureBox34);
            this.groupBox3.Controls.Add(this.pictureBox27);
            this.groupBox3.Controls.Add(this.pictureBox20);
            this.groupBox3.Controls.Add(this.pictureBox13);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox47);
            this.groupBox3.Controls.Add(this.pictureBox40);
            this.groupBox3.Controls.Add(this.pictureBox33);
            this.groupBox3.Controls.Add(this.pictureBox26);
            this.groupBox3.Controls.Add(this.pictureBox19);
            this.groupBox3.Controls.Add(this.pictureBox12);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox46);
            this.groupBox3.Controls.Add(this.pictureBox39);
            this.groupBox3.Controls.Add(this.pictureBox32);
            this.groupBox3.Controls.Add(this.pictureBox45);
            this.groupBox3.Controls.Add(this.pictureBox38);
            this.groupBox3.Controls.Add(this.pictureBox31);
            this.groupBox3.Controls.Add(this.pictureBox25);
            this.groupBox3.Controls.Add(this.pictureBox24);
            this.groupBox3.Controls.Add(this.pictureBox44);
            this.groupBox3.Controls.Add(this.pictureBox18);
            this.groupBox3.Controls.Add(this.pictureBox37);
            this.groupBox3.Controls.Add(this.pictureBox17);
            this.groupBox3.Controls.Add(this.pictureBox30);
            this.groupBox3.Controls.Add(this.pictureBox11);
            this.groupBox3.Controls.Add(this.pictureBox23);
            this.groupBox3.Controls.Add(this.pictureBox43);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox36);
            this.groupBox3.Controls.Add(this.pictureBox16);
            this.groupBox3.Controls.Add(this.pictureBox29);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox22);
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
            // pictureBox49
            // 
            this.pictureBox49.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox49.Location = new System.Drawing.Point(433, 488);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(65, 68);
            this.pictureBox49.TabIndex = 0;
            this.pictureBox49.TabStop = false;
            this.pictureBox49.UseWaitCursor = true;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox42.Location = new System.Drawing.Point(433, 414);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(65, 68);
            this.pictureBox42.TabIndex = 0;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.UseWaitCursor = true;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox35.Location = new System.Drawing.Point(433, 340);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(65, 68);
            this.pictureBox35.TabIndex = 0;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.UseWaitCursor = true;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox28.Location = new System.Drawing.Point(433, 265);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(65, 68);
            this.pictureBox28.TabIndex = 0;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.UseWaitCursor = true;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox21.Location = new System.Drawing.Point(433, 190);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(65, 68);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.UseWaitCursor = true;
            // 
            // pictureBox14
            // 
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
            this.pictureBox7.Image = global::Ut3CustomCrosshairs.Properties.Resources.A7;
            this.pictureBox7.Location = new System.Drawing.Point(433, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 68);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.UseWaitCursor = true;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox48.Location = new System.Drawing.Point(364, 488);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(65, 68);
            this.pictureBox48.TabIndex = 0;
            this.pictureBox48.TabStop = false;
            this.pictureBox48.UseWaitCursor = true;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox41.Location = new System.Drawing.Point(364, 414);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(65, 68);
            this.pictureBox41.TabIndex = 0;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.UseWaitCursor = true;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox34.Location = new System.Drawing.Point(364, 340);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(65, 68);
            this.pictureBox34.TabIndex = 0;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.UseWaitCursor = true;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox27.Location = new System.Drawing.Point(364, 265);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(65, 68);
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.UseWaitCursor = true;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox20.Location = new System.Drawing.Point(364, 190);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(65, 68);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.UseWaitCursor = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Ut3CustomCrosshairs.Properties.Resources.B4;
            this.pictureBox13.Location = new System.Drawing.Point(364, 111);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(65, 68);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.UseWaitCursor = true;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox47.Location = new System.Drawing.Point(293, 488);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(65, 68);
            this.pictureBox47.TabIndex = 0;
            this.pictureBox47.TabStop = false;
            this.pictureBox47.UseWaitCursor = true;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox40.Location = new System.Drawing.Point(293, 414);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(65, 68);
            this.pictureBox40.TabIndex = 0;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.UseWaitCursor = true;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox33.Location = new System.Drawing.Point(293, 340);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(65, 68);
            this.pictureBox33.TabIndex = 0;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.UseWaitCursor = true;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox26.Location = new System.Drawing.Point(293, 265);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(65, 68);
            this.pictureBox26.TabIndex = 0;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.UseWaitCursor = true;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox19.Location = new System.Drawing.Point(293, 190);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(65, 68);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.UseWaitCursor = true;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Ut3CustomCrosshairs.Properties.Resources.B3;
            this.pictureBox12.Location = new System.Drawing.Point(293, 111);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(65, 68);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.UseWaitCursor = true;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox46.Location = new System.Drawing.Point(222, 488);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(65, 68);
            this.pictureBox46.TabIndex = 0;
            this.pictureBox46.TabStop = false;
            this.pictureBox46.UseWaitCursor = true;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox39.Location = new System.Drawing.Point(222, 414);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(65, 68);
            this.pictureBox39.TabIndex = 0;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.UseWaitCursor = true;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox32.Location = new System.Drawing.Point(222, 340);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(65, 68);
            this.pictureBox32.TabIndex = 0;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.UseWaitCursor = true;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox45.Location = new System.Drawing.Point(151, 488);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(65, 68);
            this.pictureBox45.TabIndex = 0;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.UseWaitCursor = true;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox38.Location = new System.Drawing.Point(151, 414);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(65, 68);
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.UseWaitCursor = true;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox31.Location = new System.Drawing.Point(151, 340);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(65, 68);
            this.pictureBox31.TabIndex = 0;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.UseWaitCursor = true;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox25.Location = new System.Drawing.Point(222, 265);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(65, 68);
            this.pictureBox25.TabIndex = 0;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.UseWaitCursor = true;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox24.Location = new System.Drawing.Point(151, 265);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(65, 68);
            this.pictureBox24.TabIndex = 0;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.UseWaitCursor = true;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox44.Location = new System.Drawing.Point(80, 488);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(65, 68);
            this.pictureBox44.TabIndex = 0;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.UseWaitCursor = true;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox18.Location = new System.Drawing.Point(222, 190);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(65, 68);
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.UseWaitCursor = true;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox37.Location = new System.Drawing.Point(80, 414);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(65, 68);
            this.pictureBox37.TabIndex = 0;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.UseWaitCursor = true;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Ut3CustomCrosshairs.Properties.Resources.B8;
            this.pictureBox17.Location = new System.Drawing.Point(151, 190);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(65, 68);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.UseWaitCursor = true;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox30.Location = new System.Drawing.Point(80, 340);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(65, 68);
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.UseWaitCursor = true;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Ut3CustomCrosshairs.Properties.Resources.B2;
            this.pictureBox11.Location = new System.Drawing.Point(222, 111);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(65, 68);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.UseWaitCursor = true;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox23.Location = new System.Drawing.Point(80, 265);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(65, 68);
            this.pictureBox23.TabIndex = 0;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.UseWaitCursor = true;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox43.Location = new System.Drawing.Point(9, 488);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(65, 68);
            this.pictureBox43.TabIndex = 0;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.UseWaitCursor = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Ut3CustomCrosshairs.Properties.Resources.B1;
            this.pictureBox10.Location = new System.Drawing.Point(151, 111);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(65, 68);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.UseWaitCursor = true;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox36.Location = new System.Drawing.Point(9, 414);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(65, 68);
            this.pictureBox36.TabIndex = 0;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.UseWaitCursor = true;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Ut3CustomCrosshairs.Properties.Resources.B7;
            this.pictureBox16.Location = new System.Drawing.Point(80, 190);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(65, 68);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.UseWaitCursor = true;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox29.Location = new System.Drawing.Point(9, 340);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(65, 68);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.UseWaitCursor = true;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::Ut3CustomCrosshairs.Properties.Resources.A1;
            this.pictureBox22.Location = new System.Drawing.Point(9, 265);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(65, 68);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.UseWaitCursor = true;
            // 
            // pictureBox9
            // 
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
            this.ClientSize = new System.Drawing.Size(1525, 680);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
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
        private PictureBox pictureBox49;
        private PictureBox pictureBox42;
        private PictureBox pictureBox35;
        private PictureBox pictureBox28;
        private PictureBox pictureBox21;
        private PictureBox pictureBox14;
        private PictureBox pictureBox7;
        private PictureBox pictureBox48;
        private PictureBox pictureBox41;
        private PictureBox pictureBox34;
        private PictureBox pictureBox27;
        private PictureBox pictureBox20;
        private PictureBox pictureBox13;
        private PictureBox pictureBox47;
        private PictureBox pictureBox40;
        private PictureBox pictureBox33;
        private PictureBox pictureBox26;
        private PictureBox pictureBox19;
        private PictureBox pictureBox12;
        private PictureBox pictureBox46;
        private PictureBox pictureBox39;
        private PictureBox pictureBox32;
        private PictureBox pictureBox45;
        private PictureBox pictureBox38;
        private PictureBox pictureBox31;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
        private PictureBox pictureBox44;
        private PictureBox pictureBox18;
        private PictureBox pictureBox37;
        private PictureBox pictureBox17;
        private PictureBox pictureBox30;
        private PictureBox pictureBox11;
        private PictureBox pictureBox23;
        private PictureBox pictureBox43;
        private PictureBox pictureBox10;
        private PictureBox pictureBox36;
        private PictureBox pictureBox16;
        private PictureBox pictureBox29;
        private PictureBox pictureBox22;
        private PictureBox pictureBox9;
        private PictureBox pictureBox15;
        private PictureBox pictureBox8;
        private Label label5;
        private Label weaponLabel;
        private TextBox weaponCoordinates;
        private Label ColorLabel;
        private Button colorButton;
        private Label CheckBoxLabel;
        private CheckBox checkBox1;
        private ColorDialog colorDialog;
    }
}