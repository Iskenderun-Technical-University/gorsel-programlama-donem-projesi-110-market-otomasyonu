using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market_Otomasyonu
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        //Form Yükle
        private void Orders_Load(object sender, EventArgs e)
        {
            this.siparisler_TableAdapter.Fill(this.stuffdbDataSet1.Siparisler_);
            comboBox1.SelectedIndex = 0;
            

        }
        //Veri Çek
        public void getData()
        {
            this.siparisler_TableAdapter.Fill(this.stuffdbDataSet1.Siparisler_);
            dataGridView1.DataSource = this.stuffdbDataSet1.Siparisler_;
        }
        //Hücre tıklama eventi
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderDetails formm = new OrderDetails();
            int index = dataGridView1.SelectedCells[0].RowIndex;
            formm.Controls[5].Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            formm.Controls[4].Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            formm.Controls[3].Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            formm.Controls[2].Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            formm.Controls[1].Text = dataGridView1.Rows[index].Cells[4].Value.ToString() + " tl.";
            formm.Controls[0].Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            formm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);

            formm.Show(); 

        }
        //Silmeden sonra veri güncelle
        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            getData();
        }
        //Button ARA
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                getData();
            }

            else if (comboBox1.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Siparisler_ where siparisno=@qtext", SqlVariables.SqlVariables.connection);
                SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
                cmd.Parameters.AddWithValue("@qtext", textBox1.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Siparisler_ where isim=@qtext", SqlVariables.SqlVariables.connection);
                SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
                cmd.Parameters.AddWithValue("@qtext", textBox1.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Siparisler_ where telefon=@qtext", SqlVariables.SqlVariables.connection);
                SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
                cmd.Parameters.AddWithValue("@qtext", textBox1.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }
        //Button Yenile
        private void button2_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
