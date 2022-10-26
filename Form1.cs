using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciadilabel_Click(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
        }

        private void girisbuton_Click(object sender, EventArgs e)
        {
            if(kullaniciadi.Text=="admin"&sifre.Text=="123456")
            {
                anaekran anaekransec = new anaekran();
                anaekransec.Show();
                this.Hide();
            }
        }

        private void orderbutton_Click(object sender, EventArgs e)
        { 
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
