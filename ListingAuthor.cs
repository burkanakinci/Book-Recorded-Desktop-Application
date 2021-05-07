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
    class ListingAuthor
    {

        SqlSingleton sqlSingleton = SqlSingleton.GetInstance();
        SqlConnection connectionSql = new SqlConnection(@"Data Source=DESKTOP-3625S7R;
            Initial Catalog=nyymDb;Integrated Security=True");
        private int yazar_id1;
        public ListingAuthor(int yazar_id1)
        {

            this.yazar_id1=yazar_id1;
        }

        public DataTable SorguYap1()
        {

            return sqlSingleton.GetData("select * from Kitap where yazar_id = '" +
                yazar_id1 + "' ");
        }
    }
}
