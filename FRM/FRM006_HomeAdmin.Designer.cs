namespace Brontide_Repo_001.FRM
{
    partial class FRM006_HomeAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM006_HomeAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_toolButtons = new System.Windows.Forms.Panel();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_toolButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.pnl_toolButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 29);
            this.panel1.TabIndex = 2;
            // 
            // pnl_toolButtons
            // 
            this.pnl_toolButtons.Controls.Add(this.btn_maximize);
            this.pnl_toolButtons.Controls.Add(this.btn_close);
            this.pnl_toolButtons.Controls.Add(this.btn_minimize);
            this.pnl_toolButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_toolButtons.Location = new System.Drawing.Point(1026, 0);
            this.pnl_toolButtons.Name = "pnl_toolButtons";
            this.pnl_toolButtons.Size = new System.Drawing.Size(106, 29);
            this.pnl_toolButtons.TabIndex = 8;
            // 
            // btn_maximize
            // 
            this.btn_maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.BackgroundImage")));
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Location = new System.Drawing.Point(35, 2);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(24, 20);
            this.btn_maximize.TabIndex = 7;
            this.btn_maximize.UseVisualStyleBackColor = true;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(70, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 20);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(2, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(24, 20);
            this.btn_minimize.TabIndex = 6;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 512);
            this.panel2.TabIndex = 8;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(5, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(34, 33);
            this.btn_home.TabIndex = 7;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_menu.Location = new System.Drawing.Point(66, 55);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(47, 263);
            this.pnl_menu.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_main.Location = new System.Drawing.Point(159, 75);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(782, 333);
            this.pnl_main.TabIndex = 9;
            this.pnl_main.Click += new System.EventHandler(this.pnl_main_Click);
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            // 
            // FRM006_HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM006_HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM006_HomeAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM006_HomeAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_toolButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_toolButtons;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_main;
    }
}