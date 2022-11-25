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

namespace Market_Otomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void LoadCategories()
        {

            SqlCommand commandListCategories = new SqlCommand("Select * Table_2", SqlConnection.connect);
            SqlConnection.CheckConnection(SqlConnection.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandListCategories);
            SqlDataAdapter da = new SqlDataAdapter(commandListCategories);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public  void Form3_Load(object sender, EventArgs e)
        {
            LoadCategories();

        }
    }
}
