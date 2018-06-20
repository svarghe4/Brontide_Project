namespace Brontide_Repo_001.User_Controls
{
    partial class PatientProfile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientProfile));
            this.userImage = new System.Windows.Forms.PictureBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_userSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userImage
            // 
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(3, 2);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(46, 46);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(54, 6);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(78, 16);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "User Name";
            this.lbl_userName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_userName_MouseUp);
            // 
            // lbl_userSubtitle
            // 
            this.lbl_userSubtitle.AutoSize = true;
            this.lbl_userSubtitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userSubtitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_userSubtitle.Location = new System.Drawing.Point(54, 25);
            this.lbl_userSubtitle.Name = "lbl_userSubtitle";
            this.lbl_userSubtitle.Size = new System.Drawing.Size(72, 15);
            this.lbl_userSubtitle.TabIndex = 2;
            this.lbl_userSubtitle.Text = "User Subtitle";
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_userSubtitle);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.userImage);
            this.Name = "PatientProfile";
            this.Size = new System.Drawing.Size(316, 51);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PatientProfile_ControlAdded);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_userSubtitle;
    }
}
