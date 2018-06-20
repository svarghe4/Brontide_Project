using Brontide_Repo_001.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brontide_Repo_001.User_Controls;
namespace Brontide_Repo_001.FRM
{
    public partial class FRM001_LOGIN : Form
    {
        public FRM001_LOGIN()
        {
            InitializeComponent();
        }
        MenuButton .

         private void btn_login_Click(object sender, EventArgs e)
        {
            if (chk_isAdmin.Checked == true)
            {
                FRM006_HomeAdmin OBJFRM = new FRM006_HomeAdmin();
                //GLOBALCALLS.BRONTIDESHOW(OBJFRM);
                //GLOBALCALLS.BRONTIDESHOW(OBJFRM);
                OBJFRM.Show();
            }
            else
            {
                FRM002_Home OBJFRM = new FRM002_Home();
                //GLOBALCALLS.BRONTIDESHOW(OBJFRM);
                //GLOBALCALLS.BRONTIDESHOW(OBJFRM);
                OBJFRM.Show();
            }
            
            this.Hide();
        }

        private  void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM001_LOGIN_Load(object sender, EventArgs e)
        {
            Button b1 = new Button();

            panel4.Controls.Add(b1);


        }

        private  void xyz (object sender, EventArgs e)
        {

        }
    }
}
