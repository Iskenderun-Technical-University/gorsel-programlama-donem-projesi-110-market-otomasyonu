using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_Otomasyonu.Classes1;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Market_Otomasyonu
{
    public partial class anaekran : Form
    {
        public string departman;
        public anaekran()
        {
            InitializeComponent();
        }
        //sepet sql bağlantı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V68AV88;Initial Catalog=marketotomasyonu;Integrated Security=True");
        DataSet dataset = new DataSet();

        //sepet listeleme
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(dataset, "sepet");
            dataGridView1.DataSource = dataset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        
        private void hesapla()
        {
            //Toplam Tutarın Hesaplanması
           try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet ", baglanti);
                lable4.Text = komut.ExecuteScalar().ToString() + " TL";
                baglanti.Close();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void Temizle()
        {
            //Texxtboxların Temizlenmesi
            if (textBox1.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        if (item != adtextbox)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        //
        bool durum = true;
        private void barkodkontrol()
        {
            //Aynı Üründen var mı kontrol
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["urunid"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        //Stok Kontrolü
        int secim;
        private void urunmiktarikontrol()
        {
            secim = 1;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urunler", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["envanterID"].ToString())
                {
                    int miktar = int.Parse(read["envanter_adedi"].ToString());
                    if (miktar <= 0 || miktar < int.Parse(adettextbox.Text))
                    {
                        secim = 0;
                    }

                }
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            dataset.Tables["sepet"].Clear();
            baglanti.Close();
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
            maashesaplama maashesaplamasec = new maashesaplama();
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
            // TODO: Bu kod satırı 'marketotomasyonuDataSet.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter.Fill(this.marketotomasyonuDataSet.sepet);
            sepetlistele();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlForm depo = new SqlForm();
            depo.Show();
            this.Close();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tofiyattextbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //TextBox içindeki yazı değiştiğinde otomatik olarak diğer textboxları dolurur.
            if (urunıdtext.Text == "*")
            {
                urunıdtext.Text = "";
            }
            Temizle();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urunler where envanterID like '" + textBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adtextbox.Text = read["envanter_ismi"].ToString();
                fiyattextbox.Text = read["envanter_fiyatı"].ToString();

            }
            adettextbox.Text = "1";
            baglanti.Close();
        }

        private void faturkes_Click(object sender, EventArgs e)
        {  
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            dataset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void satisiptal_Click_1(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürünler sepetten çıkarıldı");
            dataset.Tables["sepet"].Clear();
            baglanti.Close();
            sepetlistele();
            hesapla();
        }

        private void fiyattextbox_TextChanged_1(object sender, EventArgs e)
        {
            //fiyat değişiminde toplam fiyatı değiştirir
            try
            {
                tofiyattextbox.Text = (double.Parse(adettextbox.Text) * double.Parse(fiyattextbox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void adettextbox_TextChanged_1(object sender, EventArgs e)
        {
            //adet değişiminde toplam fiyatı değiştirir
            try
            {
                tofiyattextbox.Text = (double.Parse(adettextbox.Text) * double.Parse(fiyattextbox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            baglanti.Close();
            urunmiktarikontrol();
            //stok kontrol
            if (secim == 1)
            {
                //aynı ürün kontrolü
                if (durum == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into sepet(urunadi,urunid,urunfiyati,toplamfiyat,urunmiktari,tarih) values(@purunadi,@purunid,@purunfiyati,@ptoplamfiyat,@purunmiktari,@ptarih)", baglanti);
                    komut.Parameters.AddWithValue("@purunadi", adtextbox.Text);
                    komut.Parameters.AddWithValue("@purunid", textBox1.Text);
                    komut.Parameters.AddWithValue("@purunfiyati", double.Parse(fiyattextbox.Text));
                    komut.Parameters.AddWithValue("@ptoplamfiyat", double.Parse(tofiyattextbox.Text));
                    komut.Parameters.AddWithValue("@purunmiktari", int.Parse(adettextbox.Text));
                    komut.Parameters.AddWithValue("@ptarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update sepet set urunmiktari=urunmiktari+'" + int.Parse(adettextbox.Text) + "'where urunid like '" + textBox1.Text + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyat=urunmiktari*urunfiyati where urunid like '" + textBox1.Text + "'", baglanti);
                    komut3.ExecuteNonQuery();
                    durum = true;
                    baglanti.Close();
                }
            }
            else if (secim==0)
            {
                MessageBox.Show("Yetersiz Stok");
            }
            adettextbox.Text = "1";
            dataset.Tables["sepet"].Clear(); 
            sepetlistele();
            hesapla();
            //textboxları temizliyor
            foreach (Control item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }

            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
