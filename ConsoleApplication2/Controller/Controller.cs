using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;
using BookSeller;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace BookSeller
{
    class Controller
    {
        public List<BookAd> getAllBookAds()
        {
            string cmd = "SELECT * FROM BookAd";
            List<BookAd> newList = new List<BookAd>(BookAdDb.Read(cmd));
            //newList.Find(item => item.title == "Title");
            return newList;
        }

        public BookAd getBookAd(string cmd)
        {
            BookAd book = BookAdDb.getBookAd(cmd);
            return book;
        }

        public DataTable getDataTableBookAds()
        {
            string cmd = "SELECT * FROM BookAd";
            DataTable dt = new DataTable();
            dt = BookAdDb.ReadDt(cmd);
            return dt;
        }

        public void addBookAd(string title, string author, string isbn, string date, int price, string adtext, string course, string mail)
        {
            BookAdDb.Insert(title, author, isbn, date, price, adtext, course, mail);
        }

        public void addSeller()
        {
        
        }

        public Seller getSeller(string Mail)
        {
            Seller tmpSeller = new Seller();
            tmpSeller = SellerDb.getSeller(Mail);
            return tmpSeller;
        }
    }
}
