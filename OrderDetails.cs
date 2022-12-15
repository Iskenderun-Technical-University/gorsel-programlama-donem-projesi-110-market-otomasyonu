using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//TODO: silmek istediğinize emin misiniz 
namespace Market_Otomasyonu
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }
        //Button Kaydı Sil
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE from siparis2 where siparisno=@siparisno", SqlVariables.SqlVariables.connection);
            SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
            cmd.Parameters.AddWithValue("@siparisno", label12.Text);
            cmd.ExecuteNonQuery();
            this.Close();   

        }
    }
}
