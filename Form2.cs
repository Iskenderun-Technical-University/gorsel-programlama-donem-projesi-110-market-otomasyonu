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
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void stuffbutton_Click(object sender, EventArgs e)
        {
            Employees stuff = new Employees();
            stuff.Show();
            this.Close();        

        }

        private void maashesaplama_Click(object sender, EventArgs e)
        {
            maashesaplama maashesaplamasec  = new maashesaplama();
            maashesaplamasec.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employees stuff = new Employees();
            stuff.Show();
            this.Close();

        }
        private void openorders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Close();

        }

        private void anaekran_Load(object sender, EventArgs e)
        {

        }

    }
}
