using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DataBaseConnect
    {
        private string sqlString;
        private string strCon;
        System.Data.SqlClient.SqlDataAdapter da;
        public String SqlString 
        { 
            set { sqlString = value; } 
        }
        public String StrCon 
        { 
            set { strCon = value; } 
        }
        public System.Data.DataSet GetConnection
        {
            get { return MyDataSet(); }
        }

        private System.Data.DataSet MyDataSet()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter(sqlString, con);
            System.Data.DataSet datSet = new System.Data.DataSet();
            da.Fill(datSet, "Table_Data");
            con.Close();
            return datSet;
        }
    }
}
