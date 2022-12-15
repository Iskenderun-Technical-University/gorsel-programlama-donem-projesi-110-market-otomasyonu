using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bağlantıyı sürekli açıp kapatmak yerine metot kullandık.
namespace Market_Otomasyonu.Classes1
{
   public class Sqlconnection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V68AV88;Initial Catalog=marketotomasyonu;Integrated Security=True");

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();

            }
        }
    }
}
