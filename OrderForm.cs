using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//TODO: silmek istediğinize emin misiniz 
//Tıklanabilir Öğelere Courser Eklenecek.

namespace Market_Otomasyonu
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        //Veritabanından Veri Çek
        public void getData()
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select * from Urunler", SqlVariables.SqlVariables.connection);
            SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["urunkodu"].ToString());
                item.SubItems.Add(row["urunadi"].ToString());
                item.SubItems.Add(row["fiyat"].ToString());
                item.SubItems.Add(row["stok"].ToString());
                listView1.Items.Add(item);
            }

        }
        //Sepette Satır Oluştur
        public void createRow(int x, int y, int z, int t, int p) {


            // Label Urun Adı Başlık
            System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label5.ForeColor = System.Drawing.SystemColors.InfoText;
            label5.Location = new System.Drawing.Point(20, 38);
            label5.Name = "label578967";
            label5.Size = new System.Drawing.Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "Ürün Adı";

            groupBox1.Controls.Add(label5);

            // Label Adet Başlık
            System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label6.ForeColor = System.Drawing.SystemColors.InfoText;
            label6.Location = new System.Drawing.Point(143, 38);
            label6.Name = "label5456435";
            label6.Size = new System.Drawing.Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Adet";

            groupBox1.Controls.Add(label6);

            // Label Tutar Başlık
            System.Windows.Forms.Label label7 = new System.Windows.Forms.Label();
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label7.ForeColor = System.Drawing.SystemColors.InfoText;
            label7.Location = new System.Drawing.Point(210, 38);
            label7.Name = "label5234323";
            label7.Size = new System.Drawing.Size(47, 20);
            label7.TabIndex = 0;
            label7.Text = "Tutar";

            groupBox1.Controls.Add(label7);

            // Label tutar toplam
            System.Windows.Forms.Label label8 = new System.Windows.Forms.Label();
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(18, 390);
            label8.Name = "label5234323";
            label8.Size = new System.Drawing.Size(47, 20);
            label8.TabIndex = 0;
            label8.Text = "Toplam Tutar: "+Convert.ToString(TutarBul())+" tl.";

            groupBox1.Controls.Add(label8);


            for (int i = 0; i < x; i++) {


                //Combox adet
                System.Windows.Forms.ComboBox ncombox = new System.Windows.Forms.ComboBox();
                ncombox.FormattingEnabled = true;
                ncombox.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                ncombox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
                ncombox.Location = new System.Drawing.Point(140, t);
                ncombox.Name = "combox" + y.ToString();
                ncombox.Size = new System.Drawing.Size(41, 31);
                ncombox.TabIndex = 1;
                ncombox.SelectedIndex = 0;
                ncombox.SelectedValueChanged += new System.EventHandler(this.ncombox_SelectedValueChanged);
                
                

                groupBox1.Controls.Add(ncombox);

                

                //Label urunadi
                System.Windows.Forms.Label nlabel = new System.Windows.Forms.Label();
                nlabel.AutoSize = true;
                nlabel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                nlabel.ForeColor = System.Drawing.SystemColors.WindowText;
                nlabel.Location = new System.Drawing.Point(18, z);
                nlabel.Name = "label" + y.ToString();
                nlabel.Size = new System.Drawing.Size(57, 20);
                nlabel.TabIndex = 0;
                nlabel.Text = listView1.CheckedItems[i].SubItems[1].Text;

                groupBox1.Controls.Add(nlabel);

                //Tutarı hesapla
                string getPrice()
                {
                    int unit = Convert.ToInt32(groupBox1.Controls[groupBox1.Controls.Count-2].Text);
                    int price = Convert.ToInt32(listView1.CheckedItems[i].SubItems[2].Text);
                    return Convert.ToString(unit * price) + " tl.";

                }
                


                //Label tutar
                System.Windows.Forms.Label nlabel2 = new System.Windows.Forms.Label();
                nlabel2.AutoSize = true;
                nlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                nlabel2.ForeColor = System.Drawing.Color.Red;
                nlabel2.Location = new System.Drawing.Point(215, p);
                nlabel2.Name = "label7";
                nlabel2.Size = new System.Drawing.Size(79, 16);
                nlabel2.TabIndex = 2;
                nlabel2.Text = getPrice();

                groupBox1.Controls.Add(nlabel2);


                z += 30;
                t += 30;
                p += 30;
                y++;
            }




        }
        //Seçimleri Temizle
        public void RemoveSelections()
        {
            groupBox1.Controls.Clear();
            // Label sepette ürün yok
            System.Windows.Forms.Label nlabel3 = new System.Windows.Forms.Label();
            nlabel3.AutoSize = true;
            nlabel3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            nlabel3.ForeColor = System.Drawing.SystemColors.MenuText;
            nlabel3.Location = new System.Drawing.Point(12, 39);
            nlabel3.Name = "labelempty";
            nlabel3.Size = new System.Drawing.Size(158, 20);
            nlabel3.TabIndex = 0;
            nlabel3.Text = "Sepetinizde ürün yok.";

            groupBox1.Controls.Add(nlabel3);
        }
        //Form Yüklenme
        private void OrderForm_Load(object sender, EventArgs e)
        {

            RemoveSelections();

            // ListView Configuration
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.CheckBoxes = true;

            listView1.Columns.Add("Ürün Kodu", 120);
            listView1.Columns.Add("Ürün Adı", 120);
            listView1.Columns.Add("Fiyat", 120);
            listView1.Columns.Add("Stok", 120);

            getData();


        }
        //Sepete Ekle
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count != 0)
            {
                groupBox1.Controls.Clear();
                int x = listView1.CheckedItems.Count;
                int y = 7;
                int z = 70;
                int t = 65;
                int p = 70;

                this.createRow(x, y, z, t, p);
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen en az bir ürün seçin.", "Seçili Ürün Yok", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
        }
        //Sepeti Temizle
        private void button2_Click(object sender, EventArgs e)
        {
            RemoveSelections();
            button2.Visible = false;
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
        }
        //Stok & Kalem kontrol
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true && e.Item.SubItems[3].Text == "0")
            {
                MessageBox.Show("Seçili ürünün stoğu yok.", "Stok yok", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                e.Item.Checked = false;
            }
            if (listView1.CheckedItems.Count > 10)
            {
                MessageBox.Show("En fazla 10 ürün seçebilirsiniz.", "Fazla Ürün", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                e.Item.Checked = false;
            }

        }
        //Stokları Güncelle
        public void updateStock()
        {
            int a = groupBox1.Controls.Count-1;
            int i = listView1.CheckedItems.Count - 1;

            for (int b = 1; b < a-2; b += 3)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Urunler SET stok=@stok where urunadi=@urunadi", SqlVariables.SqlVariables.connection);
                int stok = Convert.ToInt32(listView1.CheckedItems[i].SubItems[3].Text) - Convert.ToInt32(groupBox1.Controls[a - b - 1].Text);
                cmd.Parameters.AddWithValue("@stok", stok);
                cmd.Parameters.AddWithValue("@urunadi", groupBox1.Controls[a - b].Text);
                cmd.ExecuteNonQuery();
                i--;

            }


        }
        //Tutar Bul
        public float TutarBul()
        {
            int a = listView1.CheckedItems.Count;
            float t = 0;
            for (int i = 0; i < a; i++)
            {
                t = t + Convert.ToInt32(listView1.CheckedItems[i].SubItems[2].Text);
            }
            return t;
        }
        //Tutar Güncelle
        private void ncombox_SelectedValueChanged(object sender, EventArgs e)
        {
            int x = groupBox1.Controls.Count;
            int y = ((x - 2) / 3)-1;
            int z = 1;
            int tprice = 0;
            for (int i = y; i >= 0; i--)
            {
                int unit = Convert.ToInt32(groupBox1.Controls[x - z - 2].Text);
                int price = Convert.ToInt32(listView1.CheckedItems[i].SubItems[2].Text);
                int amount = unit * price;
                tprice = amount + tprice;
                groupBox1.Controls[x - z].Text = Convert.ToString(amount)+" tl.";
                z += 3;

            }
            groupBox1.Controls[3].Text = "Toplam Tutar: " + tprice.ToString() + " tl.";
        }
        //Urunleri Yaz
        public string UrunYaz()
        {
            int a = groupBox1.Controls.Count - 1;
            int i = listView1.CheckedItems.Count - 1;
            string s = "";

            for (int b = 1; b < a - 2; b += 3)
            {
                if (b == 1)
                {
                    s = s + groupBox1.Controls[a - b].Text;
                }
                else
                {
                    s = s + ", " + groupBox1.Controls[a - b].Text;

                }

            }

            return s;
        }
        //Tamamla
        private void button1_Click(object sender, EventArgs e)
        {
            int x = groupBox1.Controls.Count;
            int y = ((x - 2) / 3) - 1;
            int z = 1;
            int tprice = 0;
            for (int i = y; i >= 0; i--)
            {
                int unit = Convert.ToInt32(groupBox1.Controls[x - z - 2].Text);
                int price = Convert.ToInt32(listView1.CheckedItems[i].SubItems[2].Text);
                int amount = unit * price;
                tprice = amount + tprice;
                z += 3;

            }

            if (groupBox1.Controls.Count < 3)
            {
                MessageBox.Show("Lütfen sepetinize ürün ekleyin.", "Sepetiniz Boş", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
            else if(textBox1.Text=="" || textBox2.Text== "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen sipariş bilgilerinizi eksiksiz girin.", "Eksik Bilgi", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);

            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into Siparisler_ (isim,telefon,adres,tutar,urunler) values (@isim,@telefon,@adres,@tutar,@urunler)", SqlVariables.SqlVariables.connection);
                SqlVariables.SqlVariables.CheckConnection(SqlVariables.SqlVariables.connection);
                cmd.Parameters.AddWithValue("@isim", textBox1.Text);
                cmd.Parameters.AddWithValue("@telefon", textBox2.Text);
                cmd.Parameters.AddWithValue("@adres", textBox3.Text);
                cmd.Parameters.AddWithValue("@tutar", Convert.ToString(tprice));
                cmd.Parameters.AddWithValue("@urunler", UrunYaz());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Siparişiniz başarı ile tamamlandı.", "Sipariş Alındı", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

                updateStock();
                RemoveSelections();
                textBox1.Clear();   
                textBox2.Clear();   
                textBox3.Clear();
                getData();

            }
            button2.Visible = false;

        }
    }
}
