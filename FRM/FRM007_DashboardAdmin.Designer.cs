namespace Brontide_Repo_001.FRM
{
    partial class FRM007_DashboardAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_patientList = new System.Windows.Forms.Panel();
            this.patientProfile1 = new Brontide_Repo_001.User_Controls.PatientProfile();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.pnl_patientList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnl_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_main.Controls.Add(this.label2);
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Controls.Add(this.pnl_patientList);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1075, 473);
            this.pnl_main.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(325, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "BRONTIDE";
            // 
            // pnl_patientList
            // 
            this.pnl_patientList.BackColor = System.Drawing.Color.White;
            this.pnl_patientList.Controls.Add(this.patientProfile1);
            this.pnl_patientList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_patientList.Location = new System.Drawing.Point(835, 0);
            this.pnl_patientList.Name = "pnl_patientList";
            this.pnl_patientList.Size = new System.Drawing.Size(240, 473);
            this.pnl_patientList.TabIndex = 4;
            // 
            // patientProfile1
            // 
            this.patientProfile1.Location = new System.Drawing.Point(0, 0);
            this.patientProfile1.Name = "patientProfile1";
            this.patientProfile1.Size = new System.Drawing.Size(228, 49);
            this.patientProfile1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(364, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Panel";
            // 
            // FRM007_DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 473);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM007_DashboardAdmin";
            this.Text = "FRM007_DashboardAdmin";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_patientList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_patientList;
        private User_Controls.PatientProfile patientProfile1;
        private System.Windows.Forms.Label label2;
    }
}