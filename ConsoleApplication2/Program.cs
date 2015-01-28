using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseConnect dbConn = new DataBaseConnect();
            //dbConn.ConnectDb();
            TestClass.TestBooksRead();

        }
    }
}
