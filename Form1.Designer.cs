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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.impactHammerLink.Location = new System.Drawing.Point(1, 160);
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
            this.enforcerLink.Location = new System.Drawing.Point(2, 175);
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
            this.linkLabel2.Location = new System.Drawing.Point(3, 190);
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
            this.linkLabel3.Location = new System.Drawing.Point(3, 205);
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
            this.linkLabel4.Location = new System.Drawing.Point(3, 220);
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
            this.linkLabel5.Location = new System.Drawing.Point(1, 235);
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
            this.enforcerLink6.Location = new System.Drawing.Point(1, 145);
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
            this.linkLabel6.Location = new System.Drawing.Point(2, 250);
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
            this.linkLabel7.Location = new System.Drawing.Point(3, 265);
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
            this.linkLabel8.Location = new System.Drawing.Point(1, 280);
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
            this.linkLabel9.Location = new System.Drawing.Point(1, 295);
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
            this.enforcerLink0.Location = new System.Drawing.Point(3, 310);
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
            this.enforcerLink1.Location = new System.Drawing.Point(2, 325);
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
            this.enforcerLink2.Location = new System.Drawing.Point(2, 340);
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
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "If there is no custom value associated with a weapon,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "The general settings will be used for that weapon.";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::Ut3CustomCrosshairs.Properties.Resources.G1;
            this.pictureBox1.Location = new System.Drawing.Point(737, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enforcerLink1);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.enforcerLink0);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel9);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.enforcerLink6);
            this.Controls.Add(this.enforcerLink2);
            this.Controls.Add(this.enforcerLink);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.impactHammerLink);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
    }
}