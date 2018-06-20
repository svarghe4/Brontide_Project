using Brontide_Repo_001.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brontide_Repo_001.FRM
{
    public partial class FRM006_HomeAdmin : Form
    {
        int glb_panelWidth;
        bool glb_hidden;
        string glb_callFrom;
        int glb_runningTop = 0;
        Point glb_mdLoc;

        public FRM006_HomeAdmin()
        {
            InitializeComponent();
            glb_panelWidth = 230;
            glb_hidden = true;
        }

        private void FRM006_HomeAdmin_Load(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            FRM007_DashboardAdmin OBJFRM = new FRM007_DashboardAdmin();
            OBJFRM.TopMost = false;
            OBJFRM.TopLevel = false;
            OBJFRM.Width = pnl_main.Width;
            OBJFRM.Height = pnl_main.Height;
            pnl_main.Controls.Add(OBJFRM);
            OBJFRM.Show();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            if (pnl_menu.Width < glb_panelWidth)
            {
                pnl_menu.Width = pnl_menu.Width + 10;
                if (pnl_menu.Width >= glb_panelWidth)
                {
                    timer1.Stop();
                    glb_hidden = false;
                    switch (glb_callFrom)
                    {
                        case "USERPROFILE":
                            PopulateUserProfileMenu();
                            break;
                    }
                    this.Refresh();
                }
            }
            else
            {
                pnl_menu.Width = pnl_menu.Width - 10;
                if (pnl_menu.Width <= 0)
                {
                    timer1.Stop();
                    glb_hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            glb_callFrom = "USERPROFILE";
            glb_runningTop = 0;
        }

        private void pnl_main_Click(object sender, EventArgs e)
        {
            if (glb_hidden == false)
                timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PopulateUserProfileMenu()
        {
            pnl_menu.Controls.Clear();

            MenuButton btn = new MenuButton();


            btn.Top = glb_runningTop;
            btn.btn_text = "Add New User";
            btn.Name = "btn_addUser";
            btn.btn_formName = "FRM003_AddPatient";
            btn.btn_panelMain = pnl_main;
            btn.btn_panelPatientList = pnl_menu;
            btn.RefreshMe();
            pnl_menu.Controls.Add(btn);
            glb_runningTop = glb_runningTop + btn.Height;

            btn = new MenuButton();
            btn.Top = glb_runningTop;
            btn.btn_text = "Display All";
            btn.btn_formName = "FRM004_SearchPatient";
            btn.btn_panelMain = pnl_main;
            btn.btn_panelPatientList = pnl_menu;
            btn.Name = "btn_displayAll";
            btn.RefreshMe();
            pnl_menu.Controls.Add(btn);
            glb_runningTop = glb_runningTop + btn.Height;

        }

        protected void btn_addUser(object sender, EventArgs e)
        {
            MessageBox.Show("Add user clicked");
        }

        protected void btn_displayAll(object sender, EventArgs e)
        {
            MessageBox.Show("Display all clicked");
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //If (e.Button = MouseButtons.Left Then MDLoc = e.Location
            if (e.Button == MouseButtons.Left)
            {
                glb_mdLoc = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.Location.X - glb_mdLoc.X;
                this.Top += e.Location.Y - glb_mdLoc.Y;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            FRM005_Dashboard OBJFRM = new FRM005_Dashboard();
            OBJFRM.TopMost = false;
            OBJFRM.TopLevel = false;
            OBJFRM.Width = pnl_main.Width;
            OBJFRM.Height = pnl_main.Height;
            pnl_main.Controls.Add(OBJFRM);
            OBJFRM.Show();
        }
    }
}
