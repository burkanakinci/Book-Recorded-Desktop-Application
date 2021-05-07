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
using System.Runtime.CompilerServices;

namespace NyymProject
{
    class Facade
    {
        private ListingCategory listingCategory;
        private ListingAuthor listingAuthor;
        private ListingPublisher listingPublisher;  

        public DataTable FacadeYayinevi(int yayinevi_id)
        {

            listingPublisher = new ListingPublisher(yayinevi_id);
            return listingPublisher.SorguYap1();
        }
        public DataTable FacadeKategori(string kategori)
        {

            listingCategory = new ListingCategory(kategori);
            return listingCategory.SorguYap1();
        }
        public DataTable FacadeYazar(int yazar_id)
        {

            listingAuthor = new ListingAuthor(yazar_id);
            return listingAuthor.SorguYap1();
        }
    }
}
