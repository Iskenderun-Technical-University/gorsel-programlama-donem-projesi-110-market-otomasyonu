namespace Market_Otomasyonu
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.orderbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.kullaniciadilabel = new System.Windows.Forms.Label();
            this.girisbuton = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderbutton
            // 
            resources.ApplyResources(this.orderbutton, "orderbutton");
            this.orderbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderbutton.Name = "orderbutton";
            this.orderbutton.UseVisualStyleBackColor = true;
            this.orderbutton.Click += new System.EventHandler(this.orderbutton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sifrelabel);
            this.groupBox1.Controls.Add(this.kullaniciadilabel);
            this.groupBox1.Controls.Add(this.girisbuton);
            this.groupBox1.Controls.Add(this.sifre);
            this.groupBox1.Controls.Add(this.kullaniciadi);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // sifrelabel
            // 
            resources.ApplyResources(this.sifrelabel, "sifrelabel");
            this.sifrelabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sifrelabel.Name = "sifrelabel";
            // 
            // kullaniciadilabel
            // 
            resources.ApplyResources(this.kullaniciadilabel, "kullaniciadilabel");
            this.kullaniciadilabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kullaniciadilabel.Name = "kullaniciadilabel";
            // 
            // girisbuton
            // 
            resources.ApplyResources(this.girisbuton, "girisbuton");
            this.girisbuton.Name = "girisbuton";
            this.girisbuton.UseVisualStyleBackColor = true;
            // 
            // sifre
            // 
            resources.ApplyResources(this.sifre, "sifre");
            this.sifre.Name = "sifre";
            // 
            // kullaniciadi
            // 
            resources.ApplyResources(this.kullaniciadi, "kullaniciadi");
            this.kullaniciadi.Name = "kullaniciadi";
            // 
            // giris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderbutton);
            this.Name = "giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button orderbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.Label kullaniciadilabel;
        private System.Windows.Forms.Button girisbuton;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullaniciadi;
    }
}

