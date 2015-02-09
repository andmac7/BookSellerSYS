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
        static readonly string[] conString = {"user id = Administrator; password=SYSA14; server=VAIOPRO11; Trusted_Connection=yes; database=BookAd; connection timeout=5", 
            "user id=ramy; password=123456; server=Ramy; Trusted_Connection=yes; database=BookAd; connection timeout=5",
            "user id=SverkerJerker; password=; server=ANDREAS-PC\\SQLEXPRESS; Trusted_Connection=yes; database=BookSeller; connection timeout=5",
            "user id=Robin; password=; server=WIN-FQSEFO9B1JF; Trusted_Connection=yes; database=BookAd; connection timeout=5"};
        static int i = 2; // 0 = Thomas, 1 = Ramy, 2 = Andreas, 3 = Robin
  
        public static SqlConnection conn = null;

        public static DataTable ExecuteSelectCommand(string cmdName, CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(conString[i])) // Skapar ett temporärt SqlConnection-objekt som slängs i slutet av funktionen, när den hämtat data från databasen.
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
                    catch (Exception e)
                    {

                        System.Windows.Forms.MessageBox.Show("Could not connect to the database.\nPlease try again later.\n\n" + e);
                        //throw;
                    }
                }
            }
            return table;
        }

        /*
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
        }*/

        public static int ExecuteNonQuery(string cmdName, CommandType cmdType)
        {
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(conString[i]))
            {
                using (SqlCommand command = new SqlCommand(cmdName, con))
                {
                    command.CommandType = cmdType;
                    command.CommandText = cmdName;

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}