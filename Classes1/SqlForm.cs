using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Database'den veri çekme

namespace Market_Otomasyonu.Classes1
{
    public partial class SqlForm : Form
    {
        public SqlForm()
        {
            InitializeComponent();
        }

        private void SqlForm_Load(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select * Table_2", Sqlconnection.connection);
            Sqlconnection.connection.Open();


            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            Sqlconnection.connection.Close();
        }





            // Sql ile Envanter Ekleme



            private void btnEkle_Click(object sender, EventArgs e)
            {
                SqlCommand commandAdd = new SqlCommand("İnsert İnto Table_2(envanter adı, envanter adedi,envanter fiyatı) values (@pname, @padet,@pfiyat ", Sqlconnection.connection);
                Sqlconnection.CheckConnection(Sqlconnection.connection);
                commandAdd.Parameters.AddWithValue("@pname", textBox1name.Text);
                commandAdd.Parameters.AddWithValue("@padet", textBoxAdet.Text);
                commandAdd.Parameters.AddWithValue("@pfiyat", textBoxFiyat.Text);

                commandAdd.ExecuteNonQuery();


            }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

