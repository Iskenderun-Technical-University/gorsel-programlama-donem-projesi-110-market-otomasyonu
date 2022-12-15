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
            // TODO: Bu kod satırı 'marketotomasyonuDataSet1.urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter.Fill(this.marketotomasyonuDataSet1.urunler);
            SqlCommand commandList = new SqlCommand("Select * from urunler", Sqlconnection.connection);
            Sqlconnection.connection.Close();
            Sqlconnection.connection.Open();


            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            Sqlconnection.connection.Close();
        }


        public void GetData()
        {
            this.urunlerTableAdapter.Fill(this.marketotomasyonuDataSet1.urunler);
            SqlCommand commandList = new SqlCommand("Select * from urunler", Sqlconnection.connection);
            Sqlconnection.connection.Close();
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
                SqlCommand commandAdd = new SqlCommand("insert into urunler(envanter_ismi, envanter_adedi,envanter_fiyatı) values (@pname, @padet,@pfiyat)", Sqlconnection.connection);
                Sqlconnection.CheckConnection(Sqlconnection.connection);
                commandAdd.Parameters.AddWithValue("@pname", textBox1name.Text);
                commandAdd.Parameters.AddWithValue("@padet", textBoxAdet.Text);
                commandAdd.Parameters.AddWithValue("@pfiyat", textBoxFiyat.Text);

                commandAdd.ExecuteNonQuery();
                GetData();

            }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran anaekransec = new anaekran();
            anaekransec.Show();
            this.Close();
        }
    }
    }

