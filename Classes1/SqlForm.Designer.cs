namespace Market_Otomasyonu.Classes1
{
    partial class SqlForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.textBox1name = new System.Windows.Forms.TextBox();
            this.marketotomasyonuDataSet1 = new Market_Otomasyonu.marketotomasyonuDataSet1();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new Market_Otomasyonu.marketotomasyonuDataSet1TableAdapters.urunlerTableAdapter();
            this.envanterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanterismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanteradediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanterfiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketotomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.envanterIDDataGridViewTextBoxColumn,
            this.envanterismiDataGridViewTextBoxColumn,
            this.envanteradediDataGridViewTextBoxColumn,
            this.envanterfiyatıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(808, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ekle);
            this.groupBox1.Controls.Add(this.textBoxFiyat);
            this.groupBox1.Controls.Add(this.textBoxAdet);
            this.groupBox1.Controls.Add(this.textBox1name);
            this.groupBox1.Location = new System.Drawing.Point(16, 454);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(805, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(100, 100);
            this.Ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(181, 46);
            this.Ekle.TabIndex = 3;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(532, 44);
            this.textBoxFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFiyat.Multiline = true;
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(185, 25);
            this.textBoxFiyat.TabIndex = 2;
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(278, 44);
            this.textBoxAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdet.Multiline = true;
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(192, 25);
            this.textBoxAdet.TabIndex = 1;
            // 
            // textBox1name
            // 
            this.textBox1name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1name.Location = new System.Drawing.Point(51, 44);
            this.textBox1name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1name.Multiline = true;
            this.textBox1name.Name = "textBox1name";
            this.textBox1name.Size = new System.Drawing.Size(164, 25);
            this.textBox1name.TabIndex = 0;
            // 
            // marketotomasyonuDataSet1
            // 
            this.marketotomasyonuDataSet1.DataSetName = "marketotomasyonuDataSet1";
            this.marketotomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this.marketotomasyonuDataSet1;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // envanterIDDataGridViewTextBoxColumn
            // 
            this.envanterIDDataGridViewTextBoxColumn.DataPropertyName = "envanterID";
            this.envanterIDDataGridViewTextBoxColumn.HeaderText = "envanterID";
            this.envanterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.envanterIDDataGridViewTextBoxColumn.Name = "envanterIDDataGridViewTextBoxColumn";
            this.envanterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.envanterIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // envanterismiDataGridViewTextBoxColumn
            // 
            this.envanterismiDataGridViewTextBoxColumn.DataPropertyName = "envanter_ismi";
            this.envanterismiDataGridViewTextBoxColumn.HeaderText = "envanter_ismi";
            this.envanterismiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.envanterismiDataGridViewTextBoxColumn.Name = "envanterismiDataGridViewTextBoxColumn";
            this.envanterismiDataGridViewTextBoxColumn.Width = 125;
            // 
            // envanteradediDataGridViewTextBoxColumn
            // 
            this.envanteradediDataGridViewTextBoxColumn.DataPropertyName = "envanter_adedi";
            this.envanteradediDataGridViewTextBoxColumn.HeaderText = "envanter_adedi";
            this.envanteradediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.envanteradediDataGridViewTextBoxColumn.Name = "envanteradediDataGridViewTextBoxColumn";
            this.envanteradediDataGridViewTextBoxColumn.Width = 125;
            // 
            // envanterfiyatıDataGridViewTextBoxColumn
            // 
            this.envanterfiyatıDataGridViewTextBoxColumn.DataPropertyName = "envanter_fiyatı";
            this.envanterfiyatıDataGridViewTextBoxColumn.HeaderText = "envanter_fiyatı";
            this.envanterfiyatıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.envanterfiyatıDataGridViewTextBoxColumn.Name = "envanterfiyatıDataGridViewTextBoxColumn";
            this.envanterfiyatıDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ürün Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "AnaEkran";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 622);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SqlForm";
            this.Text = "SqlForm";
            this.Load += new System.EventHandler(this.SqlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketotomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.TextBox textBox1name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private marketotomasyonuDataSet1 marketotomasyonuDataSet1;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private marketotomasyonuDataSet1TableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterismiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanteradediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterfiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}