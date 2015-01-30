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
        public List<BookAd> getAllBookAds()
        {
            string cmd = "SELECT * FROM BookAd";
            List<BookAd> newList = new List<BookAd>(BookAdDb.Read(cmd));
            return newList;
        }

        public void addBookAd()
        {

        }
    }
}
