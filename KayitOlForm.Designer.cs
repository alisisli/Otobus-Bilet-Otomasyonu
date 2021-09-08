
namespace WindowsFormsApp1
{
    partial class KayitOlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOlForm));
            this.btnİptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniKAdi = new System.Windows.Forms.TextBox();
            this.loginHeader = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnKayit = new System.Windows.Forms.Button();
            this.kayitSoyad = new System.Windows.Forms.Label();
            this.txtKayitSoyad = new System.Windows.Forms.TextBox();
            this.kayitAd = new System.Windows.Forms.Label();
            this.txtKayitAd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.Image")));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.Location = new System.Drawing.Point(60, 432);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(181, 47);
            this.btnİptal.TabIndex = 14;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(200, 322);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(249, 22);
            this.txtYeniSifre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtYeniKAdi
            // 
            this.txtYeniKAdi.Location = new System.Drawing.Point(200, 268);
            this.txtYeniKAdi.Name = "txtYeniKAdi";
            this.txtYeniKAdi.Size = new System.Drawing.Size(249, 22);
            this.txtYeniKAdi.TabIndex = 10;
            // 
            // loginHeader
            // 
            this.loginHeader.AutoSize = true;
            this.loginHeader.BackColor = System.Drawing.Color.Transparent;
            this.loginHeader.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginHeader.ForeColor = System.Drawing.Color.White;
            this.loginHeader.Location = new System.Drawing.Point(139, 39);
            this.loginHeader.Name = "loginHeader";
            this.loginHeader.Size = new System.Drawing.Size(252, 38);
            this.loginHeader.TabIndex = 9;
            this.loginHeader.Text = "YENİ KAYIT EKRANI";
            this.loginHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnKayit.Image")));
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.Location = new System.Drawing.Point(268, 432);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(181, 47);
            this.btnKayit.TabIndex = 15;
            this.btnKayit.Text = "KAYIT OL";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // kayitSoyad
            // 
            this.kayitSoyad.AutoSize = true;
            this.kayitSoyad.BackColor = System.Drawing.Color.Transparent;
            this.kayitSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitSoyad.ForeColor = System.Drawing.Color.White;
            this.kayitSoyad.Location = new System.Drawing.Point(105, 210);
            this.kayitSoyad.Name = "kayitSoyad";
            this.kayitSoyad.Size = new System.Drawing.Size(69, 25);
            this.kayitSoyad.TabIndex = 19;
            this.kayitSoyad.Text = "Soyad";
            // 
            // txtKayitSoyad
            // 
            this.txtKayitSoyad.Location = new System.Drawing.Point(200, 214);
            this.txtKayitSoyad.Name = "txtKayitSoyad";
            this.txtKayitSoyad.Size = new System.Drawing.Size(249, 22);
            this.txtKayitSoyad.TabIndex = 18;
            // 
            // kayitAd
            // 
            this.kayitAd.AutoSize = true;
            this.kayitAd.BackColor = System.Drawing.Color.Transparent;
            this.kayitAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitAd.ForeColor = System.Drawing.Color.White;
            this.kayitAd.Location = new System.Drawing.Point(137, 155);
            this.kayitAd.Name = "kayitAd";
            this.kayitAd.Size = new System.Drawing.Size(37, 25);
            this.kayitAd.TabIndex = 17;
            this.kayitAd.Text = "Ad";
            // 
            // txtKayitAd
            // 
            this.txtKayitAd.Location = new System.Drawing.Point(200, 159);
            this.txtKayitAd.Name = "txtKayitAd";
            this.txtKayitAd.Size = new System.Drawing.Size(249, 22);
            this.txtKayitAd.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(304, 377);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 22);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KayitOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login_back;
            this.ClientSize = new System.Drawing.Size(504, 578);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.kayitSoyad);
            this.Controls.Add(this.txtKayitSoyad);
            this.Controls.Add(this.kayitAd);
            this.Controls.Add(this.txtKayitAd);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYeniKAdi);
            this.Controls.Add(this.loginHeader);
            this.Controls.Add(this.btnKayit);
            this.Name = "KayitOlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit Ol ";
            this.Load += new System.EventHandler(this.KayitOlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniKAdi;
        private System.Windows.Forms.Label loginHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label kayitSoyad;
        private System.Windows.Forms.TextBox txtKayitSoyad;
        private System.Windows.Forms.Label kayitAd;
        private System.Windows.Forms.TextBox txtKayitAd;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}