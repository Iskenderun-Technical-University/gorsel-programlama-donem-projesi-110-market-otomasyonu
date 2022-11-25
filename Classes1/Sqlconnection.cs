using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Market_Otomasyonu.Classes1
{
   public class Sqlconnection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HTJQEGE6;Initial Catalog=deneme;Integrated Security=True");

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();

            }
        }
    }
}
