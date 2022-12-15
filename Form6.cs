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

        public void GetData()
        {
            this.urunlerTableAdapter.Fill(this.marketotomasyonuDataSet1.urunler);
        }
        // Sql'den Envanter Silme
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(textBox1.Text);
            SqlCommand commandDelete = new SqlCommand("delete from urunler where envanterID=@pid",Sqlconnection.connection);
            Sqlconnection.CheckConnection(Sqlconnection.connection);
            commandDelete.Parameters.AddWithValue("@pid",selectedID);
            commandDelete.ExecuteNonQuery();
            GetData();
        
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketotomasyonuDataSet1.urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter.Fill(this.marketotomasyonuDataSet1.urunler);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
