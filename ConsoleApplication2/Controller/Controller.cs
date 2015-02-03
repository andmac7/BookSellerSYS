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

namespace BookSeller
{
    class Controller
    {
        //BookAdDb
        public List<BookAd> getAllBookAds()
        {
            string cmd = "SELECT * FROM BookAd";
            List<BookAd> newList = new List<BookAd>(BookAdDb.Read(cmd));
            return newList;
        }

        //CourseDb



        //InstDb



        //SellerDb
        public List<Seller> getSeller(String username)
        {
            if (username == "")
            {
                List<Seller> empty = new List<Seller>();
                return empty;
            }
            else
            {
                string cmd = "SELECT * FROM Seller WHERE mail = '" + username + "'";
                List<Seller> newList = new List<Seller>(SellerDb.Read(cmd));
                return newList;
            }

                  
        }



        public void addBookAd()
        {

        }
    }
}
