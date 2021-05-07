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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
         SqlSingleton sS = SqlSingleton.GetInstance();
         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3625S7R;
            Initial Catalog=nyymDb;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

            //this.kitapTableAdapter.Fill(this.nyymDbDataSet.Kitap);

            GetRecordBook();
            
            SqlCommand cmd = new SqlCommand("Select * from Yayinevi", con);
            

            SqlDataAdapter dA = new SqlDataAdapter(cmd);

            DataTable dT = new DataTable();
            dA.Fill(dT);

            comboBoxYayinevi.DataSource = dT;

            comboBoxYayinevi.DisplayMember = "isim";
            comboBoxYayinevi.ValueMember = "id";

            SqlCommand cmd2 = new SqlCommand("Select * from Yazar", con);

            SqlDataAdapter dA2 = new SqlDataAdapter(cmd2);

            DataTable dT2 = new DataTable();
            dA2.Fill(dT2);

            comboBoxYazar.DataSource = dT2;

            comboBoxYazar.DisplayMember = "isim";
            comboBoxYazar.ValueMember = "id";


        }
        private void GetRecordBook()
        {


            SqlCommand cmd = new SqlCommand("Select * from Kitap", con);
            DataTable dT = new DataTable();

            try
            {

                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("veritabanı bağlantisi aktif ");


            }
            SqlDataReader sDR = cmd.ExecuteReader();
            dT.Load(sDR);
            con.Close();

            dataGridView1.DataSource = dT;
        }
        private void buttonListele_Click(object sender, EventArgs e)
        {

            Facade facade = new Facade();
            dataGridView1.DataSource = facade.FacadeKategori(textBox1.Text.ToString().Trim());

            TestListing testKategori = new TestListing();
            testKategori.TestListKategori(dataGridView1.DataSource as DataTable, textBox1.Text.ToString().Trim());

        }

        private void buttonListeleYazar_Click(object sender, EventArgs e)
        {

            Facade facade = new Facade();
            dataGridView1.DataSource = facade.FacadeYazar(comboBoxYazar.SelectedIndex+1);

            TestListing testYazar = new TestListing();
            testYazar.TestListYazar(dataGridView1.DataSource as DataTable,comboBoxYazar.SelectedIndex+1);

        }

        private void buttonListeleYayinevi_Click(object sender, EventArgs e)
        {

            Facade facade = new Facade();
            dataGridView1.DataSource = facade.FacadeYayinevi(comboBoxYayinevi.SelectedIndex+1);

            TestListing testYayinevi = new TestListing();
            testYayinevi.TestListYayinevi(dataGridView1.DataSource as DataTable,comboBoxYayinevi.SelectedIndex+1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int fKulI = LoginProcess.favoriKulI;
            int fKitI = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //SqlSingleton sqlSingleton = SqlSingleton.GetInstance();
            //DataTable tmp = sqlSingleton.GetData("select * from Favori where (@favorikitap_id,@favorikullanici_id) values ('"+fKitI+"','"+fKulI+"'))");

            string sql = "Select * from Favori where favorikitap_id='"+ fKitI + "' And favorikullanici_id='"+ fKulI + "'";


            SqlCommand komut = new SqlCommand(sql, con);


            DataTable tmp = new DataTable();

            SqlDataAdapter dA = new SqlDataAdapter(komut);

            dA.Fill(tmp);

           // MessageBox.Show(""+tmp.Rows.Count);

            if (tmp.Rows.Count>0)
            {
                MessageBox.Show("Seçilen kitap zaten favori listenizde eklidir.");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Favori VALUES (@favorikitap_id,@favorikullanici_id)", con);
                cmd.Parameters.AddWithValue("@favorikitap_id", fKitI);
                cmd.Parameters.AddWithValue("@favorikullanici_id", fKulI);

                try
                {
                    con.Open();
                }
                catch (Exception)
                {

                    //MessageBox.Show("veritabani bağlantisi açik");
                }

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Seçilen kitap favorilerinize eklenmiştir");
            }



        }

        private void buttonFavList_Click(object sender, EventArgs e)
        {

            int fKulI = LoginProcess.favoriKulI;

            string sql = "Select * from Favori where favorikullanici_id='" + fKulI + "'";


            SqlCommand komut = new SqlCommand(sql, con);


            DataTable tmp = new DataTable();

            SqlDataAdapter dA = new SqlDataAdapter(komut);
            dA.Fill(tmp);

            //MessageBox.Show(" "+tmp.Rows.Count);
            
            for (int i=0;i<tmp.Rows.Count;i++)
            {
                try
                {

                    con.Open();
                }
                catch (Exception)
                {

                    //MessageBox.Show("veritabanı bağlantisi aktif ");
                }
              
            }

        }
    }
}
