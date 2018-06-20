using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brontide_Repo_001.FRM;
using Brontide_Repo_001.CLS;

namespace Brontide_Repo_001.User_Controls
{
    public partial class MenuButton : UserControl
    {
        public string btn_text { get; set; }
        public string btn_formName { get; set; }
        public Panel btn_panelMain { get; set; }
        public Panel btn_panelPatientList { get; set; }

        public MenuButton()
        {
            InitializeComponent();
           
        }

        public void RefreshMe()
        {
            button1.Text = btn_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_panelMain.Controls.Clear();
            btn_panelPatientList.Width = 0;
            switch (btn_formName)
            {
                case "FRM003_AddPatient":
                    FRM003_AddPatient OBJFRM = new FRM003_AddPatient();
                    OBJFRM.TopMost = false;
                    OBJFRM.TopLevel = false;
                    OBJFRM.Width = btn_panelMain.Width;
                    OBJFRM.Height = btn_panelMain.Height;
                    btn_panelMain.Controls.Add(OBJFRM);
                    OBJFRM.Show();
                    //GLOBALCALLS.BRONTIDESHOW(OBJFRM);
                    break;

                case "FRM004_SearchPatient":
                    FRM004_SearchPatient OBJFRM2 = new FRM004_SearchPatient();
                    OBJFRM2.TopMost = false;
                    OBJFRM2.TopLevel = false;
                    OBJFRM2.Width = btn_panelMain.Width;
                    OBJFRM2.Height = btn_panelMain.Height;
                    btn_panelMain.Controls.Add(OBJFRM2);
                    OBJFRM2.Show();
                    break;
            }
        }
    }
}
