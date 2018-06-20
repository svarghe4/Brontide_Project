using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Brontide_Repo_001.CLS
{
    public class DBACCESS
    {
        public static string ConnStr;
        private static SqlCommand SQLCMD = new SqlCommand();
        private static SqlConnection SQLCONN = new SqlConnection();
        private static SqlDataAdapter SQLDA = new SqlDataAdapter();

        public static int ExecuteNonQuery(string pc_sql)
        {
            int result;

            SQLCONN.ConnectionString = ConnStr;
            SQLCMD.Connection = SQLCONN;
            SQLCMD.CommandText = pc_sql;
            result = SQLCMD.ExecuteNonQuery();
            return result;
        }

        public static DataTable GetData(string pc_sql)
        {
            DataTable DT = new DataTable();

            SQLCONN.ConnectionString = ConnStr;
            SQLCMD.Connection = SQLCONN;
            SQLCMD.CommandText = pc_sql;
            SQLDA.SelectCommand = SQLCMD;
            SQLDA.Fill(DT);
            return DT;
        }
    }
}
