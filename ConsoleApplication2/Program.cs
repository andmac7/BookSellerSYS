using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace BookSeller
{
    class Program
    {
        public static int i;
        static void s(string[] args)
        {
            System.Console.WriteLine("0 = Thomas, 1 = Ramy, 2 = Andreas, 3 = Robin");
            //i = int.Parse(Console.ReadLine());
            i = 2;
            DataBaseConnect dbConn = new DataBaseConnect();

            //dbConn.ConnectDb
            //int i = int.Parse(Console.ReadLine());
            /*
            TestClass.TestBooksRead();
            TestClass.TestCourseRead();
            TestClass.TestInstRead();
            TestClass.TestSellerRead();
            Console.Read();*/
        }
    }
}
