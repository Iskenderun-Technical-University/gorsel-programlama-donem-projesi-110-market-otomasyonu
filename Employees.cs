using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_Otomasyonu.SqlVariables;

namespace Market_Otomasyonu
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        //Veri Çek
        public void GetData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Table_1", SqlVariables.SqlVariables.connection);
            SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //Form Yüklenirken
        private void Stuff_Load_1(object sender, EventArgs e)
        {
            GetData();
            comboBox1.SelectedIndex = 0;
        }
        //Button Personel Kayıt
        private void button3_Click(object sender, EventArgs e)
        {
            AddEmployee personelkayit = new AddEmployee();
            personelkayit.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            personelkayit.Show();
        }
        //Eklemeden sonra veri güncelle
        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetData();
        }
        //Button Ana Ekran
        private void button4_Click(object sender, EventArgs e)
        {
            anaekran mainmenu = new anaekran();
            mainmenu.Show();
            this.Close();

        }
        //Button Yenile
        private void button5_Click(object sender, EventArgs e)
        {
            GetData();
        }
        //Button Ara
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("Select * from Table_1 where sicil=@id",SqlVariables.SqlVariables.connection);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
                    SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                } 
                else if (comboBox1.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("Select * from Table_1 where isim=@name", SqlVariables.SqlVariables.connection);
                    cmd.Parameters.AddWithValue("@name",textBox1.Text);
                    SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception)
            {
            }


            


        }
        //Public değişkenler
        public int selectedID;
        public string selectedN;
        public string selectedP;
        public int selectedS;
        public string selectedD;
        //Listeden veri al
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["sicilDataGridViewTextBoxColumn"].Value);
               selectedN = Convert.ToString(dataGridView1.CurrentRow.Cells["isimDataGridViewTextBoxColumn"].Value);
               selectedP = Convert.ToString(dataGridView1.CurrentRow.Cells["sifreDataGridViewTextBoxColumn"].Value);
               selectedS = Convert.ToInt32(dataGridView1.CurrentRow.Cells["maasDataGridViewTextBoxColumn"].Value);
               selectedD = Convert.ToString(dataGridView1.CurrentRow.Cells["departmanDataGridViewTextBoxColumn"].Value);

            }
            catch (Exception)
            {
            }


            textBox2.Text = selectedN;
            textBox3.Text = selectedP;
            textBox5.Text = Convert.ToString(selectedS);
            comboBox2.Text = selectedD;
        }
        //Button Sil
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Personeli veri tabanından silmek istediğinize emin misiniz?", "Personel Sil", MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete from Table_1 where sicil=@id", SqlVariables.SqlVariables.connection);
                SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
                cmd.Parameters.AddWithValue("@id", selectedID);
                cmd.ExecuteNonQuery();
                GetData();
            }
        }
        //Button Düzenle
        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Table_1 SET isim=@name, sifre=@password, maas=@sallary, departman=@department where sicil=@id", SqlVariables.SqlVariables.connection);
            SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);

            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@password",textBox3.Text);
            cmd.Parameters.AddWithValue("@sallary",textBox5.Text);
            cmd.Parameters.AddWithValue("@department",comboBox2.Text);
            cmd.Parameters.AddWithValue("@id",selectedID);

            cmd.ExecuteNonQuery();
            GetData();

        }
        //Button Kapat
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
            Application.Exit();
        }
    }
}
