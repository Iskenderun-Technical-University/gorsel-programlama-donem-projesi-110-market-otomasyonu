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
using Market_Otomasyonu;

namespace Market_Otomasyonu
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kapat
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ekle

            SqlCommand cmd = new SqlCommand("Insert into Table_1 (isim,sifre,maas,departman) values (@sname,@spassword,@ssallary,@sdepartment)",SqlVariables.SqlVariables.connection);  
            SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);  
            cmd.Parameters.AddWithValue("@sname",textBox1.Text +" " + textBox4.Text); 
            cmd.Parameters.AddWithValue("@spassword",textBox2.Text); 
            cmd.Parameters.AddWithValue("@ssallary",textBox3.Text); 
            cmd.Parameters.AddWithValue("@sdepartment",comboBox1.Text); 

            cmd.ExecuteNonQuery();

            MessageBox.Show("Personel bilgileri başarı ile kaydedildi.","Personel Eklendi",MessageBoxButtons.OK,icon: MessageBoxIcon.Information);
            this.Close();


        }
    }
}
