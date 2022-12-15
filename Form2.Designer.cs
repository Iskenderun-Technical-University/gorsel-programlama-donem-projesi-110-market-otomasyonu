namespace Market_Otomasyonu
{
    partial class anaekran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.stuffbutton = new System.Windows.Forms.Button();
            this.maashesaplama = new System.Windows.Forms.Button();
            this.openorders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketotomasyonuDataSet = new Market_Otomasyonu.marketotomasyonuDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ekle = new System.Windows.Forms.Button();
            this.faturkes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.satisiptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.urunıdtext = new System.Windows.Forms.Label();
            this.adtextbox = new System.Windows.Forms.TextBox();
            this.adettextbox = new System.Windows.Forms.TextBox();
            this.tofiyattextbox = new System.Windows.Forms.TextBox();
            this.fiyattextbox = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.sepetTableAdapter = new Market_Otomasyonu.marketotomasyonuDataSetTableAdapters.sepetTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketotomasyonuDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stuffbutton
            // 
            this.stuffbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stuffbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stuffbutton.Location = new System.Drawing.Point(584, 12);
            this.stuffbutton.Name = "stuffbutton";
            this.stuffbutton.Size = new System.Drawing.Size(226, 55);
            this.stuffbutton.TabIndex = 1;
            this.stuffbutton.Text = "Personel Paneli";
            this.stuffbutton.UseVisualStyleBackColor = true;
            this.stuffbutton.Click += new System.EventHandler(this.stuffbutton_Click);
            // 
            // maashesaplama
            // 
            this.maashesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maashesaplama.Location = new System.Drawing.Point(165, 12);
            this.maashesaplama.Name = "maashesaplama";
            this.maashesaplama.Size = new System.Drawing.Size(201, 55);
            this.maashesaplama.TabIndex = 3;
            this.maashesaplama.Text = "Maaş Hesaplama";
            this.maashesaplama.UseVisualStyleBackColor = true;
            this.maashesaplama.Click += new System.EventHandler(this.maashesaplama_Click);
            // 
            // openorders
            // 
            this.openorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openorders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openorders.Location = new System.Drawing.Point(372, 12);
            this.openorders.Name = "openorders";
            this.openorders.Size = new System.Drawing.Size(206, 55);
            this.openorders.TabIndex = 4;
            this.openorders.Text = "Siparişler";
            this.openorders.UseVisualStyleBackColor = true;
            this.openorders.Click += new System.EventHandler(this.openorders_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(816, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Envanter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.urunmiktariDataGridViewTextBoxColumn,
            this.urunfiyatiDataGridViewTextBoxColumn,
            this.toplamfiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sepetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(317, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 388);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urunid";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "urunid";
            this.urunidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunmiktariDataGridViewTextBoxColumn
            // 
            this.urunmiktariDataGridViewTextBoxColumn.DataPropertyName = "urunmiktari";
            this.urunmiktariDataGridViewTextBoxColumn.HeaderText = "urunmiktari";
            this.urunmiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunmiktariDataGridViewTextBoxColumn.Name = "urunmiktariDataGridViewTextBoxColumn";
            this.urunmiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunfiyatiDataGridViewTextBoxColumn
            // 
            this.urunfiyatiDataGridViewTextBoxColumn.DataPropertyName = "urunfiyati";
            this.urunfiyatiDataGridViewTextBoxColumn.HeaderText = "urunfiyati";
            this.urunfiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunfiyatiDataGridViewTextBoxColumn.Name = "urunfiyatiDataGridViewTextBoxColumn";
            this.urunfiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamfiyatDataGridViewTextBoxColumn
            // 
            this.toplamfiyatDataGridViewTextBoxColumn.DataPropertyName = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn.HeaderText = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamfiyatDataGridViewTextBoxColumn.Name = "toplamfiyatDataGridViewTextBoxColumn";
            this.toplamfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // sepetBindingSource
            // 
            this.sepetBindingSource.DataMember = "sepet";
            this.sepetBindingSource.DataSource = this.marketotomasyonuDataSet;
            // 
            // marketotomasyonuDataSet
            // 
            this.marketotomasyonuDataSet.DataSetName = "marketotomasyonuDataSet";
            this.marketotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(141, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 28);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.ekle);
            this.groupBox1.Controls.Add(this.faturkes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.satisiptal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Fiyat);
            this.groupBox1.Controls.Add(this.urunıdtext);
            this.groupBox1.Controls.Add(this.adtextbox);
            this.groupBox1.Controls.Add(this.adettextbox);
            this.groupBox1.Controls.Add(this.tofiyattextbox);
            this.groupBox1.Controls.Add(this.fiyattextbox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 332);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(141, 206);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(137, 35);
            this.ekle.TabIndex = 18;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // faturkes
            // 
            this.faturkes.Location = new System.Drawing.Point(10, 260);
            this.faturkes.Name = "faturkes";
            this.faturkes.Size = new System.Drawing.Size(268, 50);
            this.faturkes.TabIndex = 20;
            this.faturkes.Text = "Fatura Kes";
            this.faturkes.UseVisualStyleBackColor = true;
            this.faturkes.Click += new System.EventHandler(this.faturkes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Toplam Fiyat:";
            // 
            // satisiptal
            // 
            this.satisiptal.Location = new System.Drawing.Point(10, 206);
            this.satisiptal.Name = "satisiptal";
            this.satisiptal.Size = new System.Drawing.Size(119, 35);
            this.satisiptal.TabIndex = 18;
            this.satisiptal.Text = "Satış İptal";
            this.satisiptal.UseVisualStyleBackColor = true;
            this.satisiptal.Click += new System.EventHandler(this.satisiptal_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Miktar:";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat.Location = new System.Drawing.Point(69, 128);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(54, 24);
            this.Fiyat.TabIndex = 13;
            this.Fiyat.Text = "Fiyat:";
            // 
            // urunıdtext
            // 
            this.urunıdtext.AutoSize = true;
            this.urunıdtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunıdtext.Location = new System.Drawing.Point(51, 22);
            this.urunıdtext.Name = "urunıdtext";
            this.urunıdtext.Size = new System.Drawing.Size(78, 24);
            this.urunıdtext.TabIndex = 12;
            this.urunıdtext.Text = "Ürün İD:";
            // 
            // adtextbox
            // 
            this.adtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtextbox.Location = new System.Drawing.Point(141, 56);
            this.adtextbox.Name = "adtextbox";
            this.adtextbox.Size = new System.Drawing.Size(137, 28);
            this.adtextbox.TabIndex = 11;
            // 
            // adettextbox
            // 
            this.adettextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adettextbox.Location = new System.Drawing.Point(141, 90);
            this.adettextbox.Name = "adettextbox";
            this.adettextbox.Size = new System.Drawing.Size(137, 28);
            this.adettextbox.TabIndex = 10;
            this.adettextbox.TextChanged += new System.EventHandler(this.adettextbox_TextChanged_1);
            // 
            // tofiyattextbox
            // 
            this.tofiyattextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tofiyattextbox.Location = new System.Drawing.Point(141, 158);
            this.tofiyattextbox.Name = "tofiyattextbox";
            this.tofiyattextbox.Size = new System.Drawing.Size(137, 28);
            this.tofiyattextbox.TabIndex = 9;
            // 
            // fiyattextbox
            // 
            this.fiyattextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyattextbox.Location = new System.Drawing.Point(141, 124);
            this.fiyattextbox.Name = "fiyattextbox";
            this.fiyattextbox.Size = new System.Drawing.Size(137, 28);
            this.fiyattextbox.TabIndex = 8;
            this.fiyattextbox.TextChanged += new System.EventHandler(this.fiyattextbox_TextChanged_1);
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lable4.Location = new System.Drawing.Point(82, 438);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(0, 24);
            this.lable4.TabIndex = 17;
            // 
            // sepetTableAdapter
            // 
            this.sepetTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tutar:";
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 491);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openorders);
            this.Controls.Add(this.maashesaplama);
            this.Controls.Add(this.stuffbutton);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "anaekran";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.anaekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketotomasyonuDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stuffbutton;
        private System.Windows.Forms.Button maashesaplama;
        private System.Windows.Forms.Button openorders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label urunıdtext;
        private System.Windows.Forms.TextBox adtextbox;
        private System.Windows.Forms.TextBox adettextbox;
        private System.Windows.Forms.TextBox tofiyattextbox;
        private System.Windows.Forms.TextBox fiyattextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label lable4;
        private marketotomasyonuDataSet marketotomasyonuDataSet;
        private System.Windows.Forms.BindingSource sepetBindingSource;
        private marketotomasyonuDataSetTableAdapters.sepetTableAdapter sepetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button satisiptal;
        private System.Windows.Forms.Button faturkes;
        private System.Windows.Forms.Label label1;
    }
}