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
            this.generalCustomLink = new System.Windows.Forms.LinkLabel();
            this.GeneralCoordinates = new System.Windows.Forms.Label();
            this.GeneralCoordinatesValue = new System.Windows.Forms.Label();
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
            // generalCustomLink
            // 
            this.generalCustomLink.AutoSize = true;
            this.generalCustomLink.Location = new System.Drawing.Point(12, 118);
            this.generalCustomLink.Name = "generalCustomLink";
            this.generalCustomLink.Size = new System.Drawing.Size(110, 15);
            this.generalCustomLink.TabIndex = 2;
            this.generalCustomLink.TabStop = true;
            this.generalCustomLink.Text = "generalCustomLink";
            this.generalCustomLink.Click += new System.EventHandler(this.generalCustomLink_click);
            // 
            // GeneralCoordinates
            // 
            this.GeneralCoordinates.AutoSize = true;
            this.GeneralCoordinates.Location = new System.Drawing.Point(12, 133);
            this.GeneralCoordinates.Name = "GeneralCoordinates";
            this.GeneralCoordinates.Size = new System.Drawing.Size(114, 15);
            this.GeneralCoordinates.TabIndex = 3;
            this.GeneralCoordinates.Text = "GeneralCoordinates:";        
            // 
            // label3
            // 
            this.GeneralCoordinatesValue.AutoSize = true;
            this.GeneralCoordinatesValue.Location = new System.Drawing.Point(12, 148);
            this.GeneralCoordinatesValue.Name = "GeneralCoordinatesValue";
            this.GeneralCoordinatesValue.Size = new System.Drawing.Size(0, 15);
            this.GeneralCoordinatesValue.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 562);
            this.Controls.Add(this.GeneralCoordinatesValue);
            this.Controls.Add(this.GeneralCoordinates);
            this.Controls.Add(this.generalCustomLink);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
      

        #endregion

        private LinkLabel generalCustomLink;
        private Label GeneralCoordinates;
        private Label GeneralCoordinatesValue;
    }
}