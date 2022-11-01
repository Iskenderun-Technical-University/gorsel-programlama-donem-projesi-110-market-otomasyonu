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
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.girisbuton = new System.Windows.Forms.Button();
            this.kullaniciadilabel = new System.Windows.Forms.Label();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.orderbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciadi
            // 
            resources.ApplyResources(this.kullaniciadi, "kullaniciadi");
            this.kullaniciadi.Name = "kullaniciadi";
            // 
            // sifre
            // 
            resources.ApplyResources(this.sifre, "sifre");
            this.sifre.Name = "sifre";
            // 
            // girisbuton
            // 
            resources.ApplyResources(this.girisbuton, "girisbuton");
            this.girisbuton.Name = "girisbuton";
            this.girisbuton.UseVisualStyleBackColor = true;
            this.girisbuton.Click += new System.EventHandler(this.girisbuton_Click);
            // 
            // kullaniciadilabel
            // 
            resources.ApplyResources(this.kullaniciadilabel, "kullaniciadilabel");
            this.kullaniciadilabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kullaniciadilabel.Name = "kullaniciadilabel";
            // 
            // sifrelabel
            // 
            resources.ApplyResources(this.sifrelabel, "sifrelabel");
            this.sifrelabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sifrelabel.Name = "sifrelabel";
            // 
            // orderbutton
            // 
            resources.ApplyResources(this.orderbutton, "orderbutton");
            this.orderbutton.Name = "orderbutton";
            this.orderbutton.UseVisualStyleBackColor = true;
            this.orderbutton.Click += new System.EventHandler(this.orderbutton_Click);
            // 
            // giris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.orderbutton);
            this.Controls.Add(this.sifrelabel);
            this.Controls.Add(this.kullaniciadilabel);
            this.Controls.Add(this.girisbuton);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Name = "giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button girisbuton;
        private System.Windows.Forms.Label kullaniciadilabel;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.Button orderbutton;
    }
}

