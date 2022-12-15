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
using Market_Otomasyonu.Classes1;

namespace Market_Otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //sayfa yüklendiğinde veri tabanından kategori ekranı açılsın.
        private void Form4_Load(object sender, EventArgs e)
            
        {
            SqlCommand commandListKategori= new SqlCommand("Select * from Table_1",Sqlconnection.connection);
            Sqlconnection.CheckConnection(Sqlconnection.connection);
            SqlDataAdapter da= new SqlDataAdapter(commandListKategori);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //ekle butonuna basıldığında kategori eklenmesi yapılması
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandListKategori = new SqlCommand("insert into Table_1 (Kategori Adı) values (@pname)", Sqlconnection.connection);
            Sqlconnection.CheckConnection (Sqlconnection.connection);
            commandListKategori.Parameters.AddWithValue("@pname", Kategoriadi);
            commandListKategori.ExecuteNonQuery();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
