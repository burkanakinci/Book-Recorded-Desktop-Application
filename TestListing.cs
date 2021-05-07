using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NyymProject
{
    class TestListing
    {
        
        public bool TestListKategori(DataTable dTKategori,string kategori)
        {
            bool kategoriTest = true;

            if (dTKategori == null)
            {

                MessageBox.Show("DataTable boş");
            }
            else
            {

                for (int i = 0; i < dTKategori.Rows.Count; i++)
                {

                    if (dTKategori.Rows[i][2].ToString().Trim() != kategori)
                    {

                        //MessageBox.Show(dTKategori.Rows[i][2].ToString().Trim());
                        //MessageBox.Show(kategori);
                        MessageBox.Show("Kategori listelenirken hata oluştu");
                        kategoriTest = false;
                        break;
                    }


                }
            }
            
            return kategoriTest;
        }
        public bool TestListYazar(DataTable dTYazar,int yazar)
        {
            bool yazarTest=true;

            if(dTYazar.Rows[0][0]==null)
            {

                MessageBox.Show("DataTable boş");
            }

            for(int i=0;i<dTYazar.Rows.Count;i++)
            {

                if (Int32.Parse(dTYazar.Rows[i][4].ToString()) != yazar)
                {

                    MessageBox.Show("Yazar listelenirken hata oluştu");
                    yazarTest = false;
                    break;
                }

                
            }
            return yazarTest;
        }

        public bool TestListYayinevi(DataTable dTYayinevi, int yayinevi)
        {

            bool yayineviTest = true;

            if (dTYayinevi.Rows[0][0] == null)
            {

                MessageBox.Show("DataTable boş");
            }

            for (int i = 0; i < dTYayinevi.Rows.Count; i++)
            {

                if (Int32.Parse(dTYayinevi.Rows[i][3].ToString()) != yayinevi)
                {

                    MessageBox.Show("Yayinevi listelenirken hata oluştu");
                    yayineviTest = false;
                    break;
                }


            }
            return yayineviTest;
        }
    }
}