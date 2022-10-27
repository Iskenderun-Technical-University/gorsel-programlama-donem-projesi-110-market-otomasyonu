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




//Tıklanabilir Öğelere Courser Eklenecek.


namespace Market_Otomasyonu
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public void createRow (int x, int y, int z, int t, int p){
            

            for (int i = 0; i < x; i++) {

                // Label Urun Adı Başlık
                System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
                label5.AutoSize = true;
                label5.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label5.ForeColor = System.Drawing.SystemColors.InfoText;
                label5.Location = new System.Drawing.Point(20, 38);
                label5.Name = "label5";
                label5.Size = new System.Drawing.Size(47, 20);
                label5.TabIndex = 0;
                label5.Text = "Ürün";

                groupBox1.Controls.Add(label5);

                // Label Adet Başlık
                System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
                label6.AutoSize = true;
                label6.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label6.ForeColor = System.Drawing.SystemColors.InfoText;
                label6.Location = new System.Drawing.Point(110, 38);
                label6.Name = "label5";
                label6.Size = new System.Drawing.Size(47, 20);
                label6.TabIndex = 0;
                label6.Text = "Adet";

                groupBox1.Controls.Add(label6);

                //Label urunadi
                System.Windows.Forms.Label nlabel = new System.Windows.Forms.Label();
                nlabel.AutoSize = true;
                nlabel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                nlabel.ForeColor = System.Drawing.SystemColors.WindowText;
                nlabel.Location = new System.Drawing.Point(18, z);
                nlabel.Name = "label"+y.ToString();
                nlabel.Size = new System.Drawing.Size(57, 20);
                nlabel.TabIndex = 0;
                nlabel.Text = listView1.Items[0].SubItems[1].Text;
                
                groupBox1.Controls.Add(nlabel);

                //Combox adet
                System.Windows.Forms.ComboBox ncombox = new System.Windows.Forms.ComboBox();
                ncombox.FormattingEnabled = true;
                ncombox.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                ncombox.Items.AddRange(new object[] {"1","2","3","4","5","6","7","8","9","10"});
                ncombox.Location = new System.Drawing.Point(110, t);
                ncombox.Name = "combox" + y.ToString();
                ncombox.Size = new System.Drawing.Size(41, 31);
                ncombox.TabIndex = 1;
                ncombox.SelectedIndex = 0;

                groupBox1.Controls.Add(ncombox);

                //Label urunu cikart
                System.Windows.Forms.Label nlabel2 = new System.Windows.Forms.Label();
                nlabel2.AutoSize = true;
                nlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                nlabel2.ForeColor = System.Drawing.Color.Red;
                nlabel2.Location = new System.Drawing.Point(185, p);
                nlabel2.Name = "label7";
                nlabel2.Size = new System.Drawing.Size(79, 16);
                nlabel2.TabIndex = 2;
                nlabel2.Text = "Ürünü Çıkart";
                nlabel2.Click += new System.EventHandler(ClickEvent);

                groupBox1.Controls.Add(nlabel2);


                z +=30;
                t += 30;
                p += 30;
                y++;

                void ClickEvent(object sender, EventArgs e)
                {
                    groupBox1.Controls.Remove(nlabel);
                    groupBox1.Controls.Remove(nlabel2);
                    groupBox1.Controls.Remove(ncombox);


                }
            }



        
        }

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

            listView1.Items[0].Checked = false;
        }

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

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count!=0)
            {
                groupBox1.Controls.Clear();
                int x = listView1.CheckedItems.Count;
                int y = 7;
                int z = 70;
                int t = 65;
                int p = 70;

                this.createRow(x, y, z, t, p);
            }
            else
            {
                MessageBox.Show("Lütfen en az bir ürün seçin.", "Eksik Ürün", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveSelections();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Siparişiniz başarı ile tamamlandı.", "Sipariş Alındı", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                RemoveSelections();
                textBox1.Clear();   
                textBox2.Clear();   
                textBox3.Clear(); 
            }

        }
    }
}
