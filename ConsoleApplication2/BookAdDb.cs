﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsoleApplication2;

namespace ConsoleApplication2
{
    class BookAdDb
    {
        public static BookAd MapBook(DataRow r)
        {
            BookAd b = new BookAd();
            b.title = r["Title"].ToString();
            b.author = r["Author"].ToString();
            b.price = r["Price"].ToString();
            b.isbn = r["Isbn"].ToString();
            b.date = r["Date"].ToString();
            b.addText = r["AddText"].ToString();
            
            return b;
        }
        public static List<BookAd> MapBooks(DataRowCollection rows)
        {
            List<BookAd> books = new List<BookAd>();
            foreach (DataRow r in rows)
            {
                books.Add(MapBook(r));
            }
            return books;
        }

        public static List<BookAd> Read()
        {
            List<BookAd> bookAds = null;
            using (DataTable table = DataBaseConnect.ExecuteSelectCommand("SELECT * FROM BookAd", CommandType.Text))
            {
                if (table.Rows.Count > 0)
                {
                    bookAds = MapBooks(table.Rows);
                }
            }
            return bookAds;
        }
    }
}
