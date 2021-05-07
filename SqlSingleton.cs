using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NyymProject
{
    class SqlSingleton
    {
        private static SqlSingleton _instance;
        private SqlSingleton()
        {
        }

        public static SqlSingleton GetInstance()
        {

            if(_instance==null)
            {

                _instance = new SqlSingleton();
            }
            return _instance;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3625S7R;
            Initial Catalog=nyymDb;Integrated Security=True");
        public int Insert(string sqlCmd)
        {

            
            SqlCommand cmd = new SqlCommand(sqlCmd,con);
            if(con.State==System.Data.ConnectionState.Closed)
            {

                con.Open();
            }

            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            return sonuc;

        }

        public DataTable GetData(string sqlCmd)
        {
            

            SqlDataAdapter dap = new SqlDataAdapter(sqlCmd, con);
            DataTable dT = new DataTable();
            dap.Fill(dT);
            return dT;
        }
    }
}
