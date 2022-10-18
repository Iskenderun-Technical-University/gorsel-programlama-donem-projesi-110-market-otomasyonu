using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Market_Otomasyonu.SqlVariables
{
    public class SqlVariables
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-S444LMQT\\MSSQLSERVER2;Initial Catalog=stuffdb;Integrated Security=True");

        public static void CheckConnection (SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();  

            }
        }



    }
}
