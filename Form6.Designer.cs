namespace Market_Otomasyonu
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marketotomasyonuDataSet1 = new Market_Otomasyonu.marketotomasyonuDataSet1();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new Market_Otomasyonu.marketotomasyonuDataSet1TableAdapters.urunlerTableAdapter();
            this.envanterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanterismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanteradediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanterfiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketotomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(570, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "envanter silme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "envanter ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 0;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(570, 140);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketotomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private marketotomasyonuDataSet1 marketotomasyonuDataSet1;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private marketotomasyonuDataSet1TableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterismiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanteradediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterfiyatıDataGridViewTextBoxColumn;
    }
}