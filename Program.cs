using Brontide_Repo_001.CLS;
using Brontide_Repo_001.FRM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brontide_Repo_001
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Intialize DBACCESS for connection string
            DBACCESS.ConnStr  = ConfigurationManager.ConnectionStrings["BrontideConnection"].ConnectionString.ToString();

            // Fill up constants
            BTDCONSTANTS.THEME = "BLUE";
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM001_LOGIN());
        }
    }
}
