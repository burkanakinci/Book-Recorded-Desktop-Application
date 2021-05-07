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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string imageUrl=null;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3625S7R;Initial Catalog=nyymDb;Integrated Security=True");

        public int KitapId;
        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxYazar.SelectedIndex.ToString());

            if (IsValid())
            {

                Image img = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img,typeof(byte[]));

                SqlCommand cmd = new SqlCommand("INSERT INTO Kitap " +
                    "VALUES (@isim,@kategori,@yayinevi_id,@yazar_id,@resim,@konu)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@isim", textBoxKitapIsim.Text);
                cmd.Parameters.AddWithValue("@kategori", textBoxKitapKategori.Text);
                cmd.Parameters.AddWithValue("@yayinevi_id", comboBoxYayinevi.SelectedIndex+1);
                cmd.Parameters.AddWithValue("@yazar_id", comboBoxYazar.SelectedIndex+1);
                cmd.Parameters.AddWithValue("@resim",arr);
                cmd.Parameters.AddWithValue("@konu", textBoxKonu.Text);

                try
                {
                    con.Open();
                }
                catch (Exception)
                {

                    MessageBox.Show("veritabani bağlantisi açik");
                }

                cmd.ExecuteNonQuery();
                con.Close();



              GetRecordBook();
            }
        }

        private bool IsValid()
        {

            if(textBoxKitapIsim.Text==string.Empty)
            {

                MessageBox.Show("Alanların tamamıyla doldurulması zorunludur");
                return false;
            }
            return true;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
            this.kitapTableAdapter.Fill(this.nyymDbDataSet1.Kitap);
            
            this.kitapTableAdapter.Fill(this.nyymDbDataSet1.Kitap);
            
            this.kitapTableAdapter.Fill(this.nyymDbDataSet.Kitap);
            GetRecordBook();

            ComboBoxDoldurma();

        }
        private void GetRecordBook()
        {

            
            SqlCommand cmd = new SqlCommand("Select * from Kitap",con);
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

            dataGridKitap.DataSource = dT;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxYayinevi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridKitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            

        }

        private void dataGridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KitapId = Convert.ToInt32(dataGridKitap.SelectedRows[0].Cells[0].Value);
            textBoxKitapKategori.Text = dataGridKitap.SelectedRows[0].Cells[2].Value.ToString();
            textBoxKitapIsim.Text = dataGridKitap.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxYazar.SelectedIndex=Int32.Parse(dataGridKitap.SelectedRows[0].Cells[4].Value.ToString())-1;
            comboBoxYayinevi.SelectedIndex = Int32.Parse(dataGridKitap.SelectedRows[0].Cells[3].Value.ToString()) - 1;
            textBoxKonu.Text = dataGridKitap.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void buttonKitapGüncelle_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UPDATE Kitap SET isim=@isim,kategori=@kategori," +
                "yayinevi_id=@yayinevi_id,yazar_id=@yazar_id WHERE id=@id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@isim", textBoxKitapIsim.Text);
            cmd.Parameters.AddWithValue("@kategori", textBoxKitapKategori.Text);
            cmd.Parameters.AddWithValue("@yayinevi_id", comboBoxYayinevi.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@yazar_id", comboBoxYazar.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@id", this.KitapId);

            try
            {
                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("veritabani bağlantisi açik");
            }

            cmd.ExecuteNonQuery();
            con.Close();

            GetRecordBook();
        }

        private void buttonKitapCikar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("DELETE FROM Kitap WHERE id=@id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", this.KitapId);

            try
            {
                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("veritabani bağlantisi açik");
            }

            cmd.ExecuteNonQuery();
            con.Close();

            GetRecordBook();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {

            using(OpenFileDialog oFD=new OpenFileDialog())
            {

                if(oFD.ShowDialog()==DialogResult.OK)
                {

                    imageUrl = oFD.FileName;
                    pictureBox1.Image = Image.FromFile(oFD.FileName);
                }
            }
        }

        private void textBoxKonu_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonYazarEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Yazar " +
                 "VALUES (@isim)", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@isim", textBoxYazarEkle.Text);

            try
            {
                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("veritabani bağlantisi açik");
            }

            cmd.ExecuteNonQuery();
            con.Close();
            ComboBoxDoldurma();
        }

        private void buttonYayineviEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Yayinevi " +
     "VALUES (@isim)", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@isim", textBoxYayineviEkle.Text);

            try
            {
                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("veritabani bağlantisi açik");
            }

            cmd.ExecuteNonQuery();
            con.Close();
            ComboBoxDoldurma();
        }
        private void ComboBoxDoldurma()
        {

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
    }

    
    
}


