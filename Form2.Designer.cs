﻿namespace Market_Otomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaekran));
            this.button1 = new System.Windows.Forms.Button();
            this.stuffbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maashesaplama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stuffbutton
            // 
            this.stuffbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stuffbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stuffbutton.Location = new System.Drawing.Point(497, 58);
            this.stuffbutton.Name = "stuffbutton";
            this.stuffbutton.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.stuffbutton.Size = new System.Drawing.Size(259, 55);
            this.stuffbutton.TabIndex = 1;
            this.stuffbutton.Text = "Personel Paneli";
            this.stuffbutton.UseVisualStyleBackColor = true;
            this.stuffbutton.Click += new System.EventHandler(this.stuffbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // maashesaplama
            // 
            this.maashesaplama.Location = new System.Drawing.Point(50, 58);
            this.maashesaplama.Name = "maashesaplama";
            this.maashesaplama.Size = new System.Drawing.Size(118, 55);
            this.maashesaplama.TabIndex = 3;
            this.maashesaplama.Text = "Maaş Hesaplama";
            this.maashesaplama.UseVisualStyleBackColor = true;
            this.maashesaplama.Click += new System.EventHandler(this.maashesaplama_Click);
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.maashesaplama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stuffbutton);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "anaekran";
            this.Text = "Anaekran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stuffbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button maashesaplama;
    }
}