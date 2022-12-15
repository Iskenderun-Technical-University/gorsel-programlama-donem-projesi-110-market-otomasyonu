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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Market_Otomasyonu
{
    public partial class maashesaplama : Form
    {
        public maashesaplama()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaekran anaekransec = new anaekran();
            anaekransec.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
         
            SqlConnection baglanti = SqlVariables.SqlVariables.connection;
            
            int a=0;
            SqlCommand komut = new SqlCommand("select * from marketotomasyonu where sicil like '" + textBox2.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                 a = Convert.ToInt32(read["maas"]);
            }
            baglanti.Close();
            int b = int.Parse(textBox1.Text);
            ucret.Text = (a * b).ToString();

        }

        private void maashesaplama_Load(object sender, EventArgs e)
        {

        }
    }
}
