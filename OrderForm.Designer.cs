﻿namespace Market_Otomasyonu
{
    partial class OrderForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Deneme",
            "5",
            "6"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(6, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "SİPARİŞ VER";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(714, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 466);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepetim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(150, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(30, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Location = new System.Drawing.Point(13, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 466);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(557, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sepete Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(432, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(19, 569);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1104, 139);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş Bİlgileri";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(363, 42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(530, 72);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(301, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adres: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(174, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon Numarası:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(174, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(962, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 723);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}