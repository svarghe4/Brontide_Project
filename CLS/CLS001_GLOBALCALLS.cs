using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace Brontide_Repo_001.CLS
{
    class GLOBALCALLS
    {
        // Universal function to open a form with generic assignments.
        public static void BRONTIDESHOW(object pr_frm)
        {
            Form OBJ = new Form();
            OBJ = (Form)pr_frm;

            DataTable dt = DBACCESS.GetData("SELECT * from TBL002_ThemeDetails " +
                                            " WHERE UserPreferencesId = " +
                                                "(SELECT id FROM TBL001_UserPreferences WHERE PreferenceValue = '" + BTDCONSTANTS.THEME + "') ");

            
            foreach (DataRow dr in dt.Rows)
            {
             string value = dr["Control"].ToString ();
             switch (value )
                    {
                    case "Button":
                        foreach (Control C in OBJ .Controls)
                        {
                            if (C is Button )
                            {
                                C.ForeColor = (System.Drawing.Color.FromName ((dr["ForeColor"].ToString())));
                                C.BackColor = (System.Drawing.Color.FromName((dr["BackColor"].ToString())));
                            }
                           
                        }
                        break;


                    case "Label":
                        foreach (Control C in OBJ.Controls)
                        {
                            if (C is Label)
                            {
                                C.ForeColor = (System.Drawing.Color.FromName((dr["ForeColor"].ToString())));
                                C.BackColor = (System.Drawing.Color.FromName((dr["BackColor"].ToString())));
                            }

                        }
                        break;

                    case "Panel":
                        foreach (Control C in OBJ.Controls)
                        {
                            if (C is Panel )
                            {
                                C.ForeColor = (System.Drawing.Color.FromName((dr["ForeColor"].ToString())));
                                C.BackColor = (System.Drawing.Color.FromName((dr["BackColor"].ToString())));
                            }

                        }
                        break;

                    case "Form":
                        OBJ.ForeColor = (System.Drawing.Color.FromName((dr["ForeColor"].ToString())));
                        OBJ.BackColor = (System.Drawing.Color.FromName((dr["BackColor"].ToString())));
                        break;

                }
             }
            OBJ.Show();
        }








    }
}
