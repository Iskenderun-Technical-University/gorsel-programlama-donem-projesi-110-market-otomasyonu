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
    
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisbuton_Click(object sender, EventArgs e)
        {
            

        }

        private void orderbutton_Click(object sender, EventArgs e)
        { 
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();   
            orders.Show();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void girisbuton_Click_1(object sender, EventArgs e)
        {
            //Personel Veritabanı ile Giriş Sorgulama Bağlantısı
            SqlCommand logincommand = new SqlCommand("Select * from marketotomasyonu where  sicil=@name AND sifre=@password", SqlVariables.SqlVariables.connection);
            logincommand.Parameters.AddWithValue("@name", kullaniciadi.Text);
            logincommand.Parameters.AddWithValue("@password", sifre.Text);
            SqlDataAdapter da = new SqlDataAdapter(logincommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {     
                anaekran anaekransec = new anaekran();
                anaekransec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

           
        }
    }
}
