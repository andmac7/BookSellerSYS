using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace BookSeller
{
    class DataBaseConnect 
    {
        const string conString = "user id=Administrator;" +
            "password=SYSB13; server=VAIOPRO11;" +
            "Trusted_Connection=yes;" +
            "database=BookAd; " +
            "connection timeout=5";

        public static SqlConnection conn = null;

        public static DataTable ExecuteSelectCommand(string cmdName, CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = cmdName;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }

        public void ConnectDb()
        {
            conn = new SqlConnection(conString);

            try
            {
                System.Console.WriteLine("Trying to connect...");
                conn.Open();
                System.Console.WriteLine("Connection established.");
                System.Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                System.Console.WriteLine("Couldn't establish connection.");
                System.Console.Read();
            }
        }
    }
}