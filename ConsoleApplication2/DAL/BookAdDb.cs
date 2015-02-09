﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookSeller
{
    class BookAdDb
    {
        public static BookAd MapBook(DataRow r)
        {
            BookAd b = new BookAd();
            b.title = r["Title"].ToString();
            b.author = r["Author"].ToString();
            b.price = (int)r["Price"];
            b.isbn = r["Isbn"].ToString();
            b.date = r["Date"].ToString();
            b.adText = r["AdText"].ToString();
            b.mail = r["Mail"].ToString();
            
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

        public static List<BookAd> Read(string cmd)
        {
            List<BookAd> bookAds = null;
            using (DataTable table = DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text))
            {
                if (table.Rows.Count > 0)
                {
                    bookAds = MapBooks(table.Rows);
                }
            }
            return bookAds;
        }
        
        public static BookAd getBookAd(string cmd)
        {
            List<BookAd> tmpBookAds = Read(String.Format("SELECT * FROM BookAd WHERE title = '{0}'",cmd));
            if (tmpBookAds.Count > 0)
            {
                BookAd book = tmpBookAds[0];
                return book;
            }
            else return null;
        }

        public static DataTable ReadDt(string cmd)
        {
            DataTable table = DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text);
            return table;
        }
        /*
        public static void Insert(string title, string author, string isbn, string date, string price, string adtext, string course, string mail)
        {
            string cmd = String.Format("INSERT INTO BookAd VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", title, author, isbn, date, price, adtext, course, mail);
            DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text);
        }
        */
        public static int Insert(string title, string author, string isbn, string date, int price, string adtext, string course, string mail)
        {
            string cmd = String.Format("INSERT INTO BookAd VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", title, isbn, author, date, price, adtext, course, mail); //String.Format för att underlätta inmatning
            int rowsAffected = 0;
            rowsAffected = DataBaseConnect.ExecuteNonQuery(cmd, CommandType.Text);
            return rowsAffected;
        }

        public static void Delete(string Title, string Author, string Isbn, string Date, string Price, string AdText, string Course, string Mail)
        {
            string cmd = String.Format("DELETE FROM BookAd WHERE isbn = '" + Isbn + "' ;");
            DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text);
        }
    }
}