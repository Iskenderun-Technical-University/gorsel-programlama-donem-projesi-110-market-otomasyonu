using Market_Otomasyonu.Classes1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(textBox1.Text);
            SqlCommand commandDelete = new SqlCommand("delete from Table_2 where envanter ID*@pid",Sqlconnection.connection);
            Sqlconnection.CheckConnection(Sqlconnection.connection);
            commandDelete.Parameters.AddWithValue("@pid",selectedID);
            commandDelete.ExecuteNonQuery();
        
        }
    }
}
