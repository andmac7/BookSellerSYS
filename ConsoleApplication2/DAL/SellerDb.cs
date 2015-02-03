﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookSeller
{
    class SellerDb
    {
        public static Seller MapSellers(DataRow r)
        {
            Seller s = new Seller();
            s.lName = r["LName"].ToString();
            s.fName = r["FName"].ToString();
            s.phoneNbr =r["PhoneNbr"].ToString();
            s.mail = r["Mail"].ToString();
            s.city = r["City"].ToString();
            s.password = r["Password"].ToString();

            return s;
        }
        public static List<Seller> MapSellers(DataRowCollection rows)
        {
            List<Seller> sellers = new List<Seller>();
            foreach (DataRow r in rows)
            {
                sellers.Add(MapSellers(r));
            }
            return sellers;
        }

        public static List<Seller> Read(string cmd)
        {
            List<Seller> sellers = null;
            using (DataTable table = DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text))
            {
                if (table.Rows.Count > 0)
                {
                    sellers = MapSellers(table.Rows);
                }
            }
            return sellers;
        }

        public static void Insert(string fName, string lName, string phoneNbr, string mail, string city, string password)
        {
            string cmd = String.Format("INSERT INTO BookAd VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", fName, lName, phoneNbr, phoneNbr, city, password);
            DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text);
        }
    }
}
