using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NyymProject
{
    class ListingPublisher
    {


        SqlSingleton sqlSingleton = SqlSingleton.GetInstance();
        SqlConnection connectionSql = new SqlConnection(@"Data Source=DESKTOP-3625S7R;
            Initial Catalog=nyymDb;Integrated Security=True");
        private int yayinevi_id1;
        public ListingPublisher(int yayinevi_id1)
        {

            this.yayinevi_id1 = yayinevi_id1;
        }

        public DataTable SorguYap1()
        {

            return sqlSingleton.GetData("select * from Kitap where yayinevi_id = '" +
                yayinevi_id1 + "' ");
        }
    }
}
