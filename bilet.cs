using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class bilet : Form
    {
        public bilet()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users/CASPER/Desktop/bilet.accdb");
        DataTable tablo = new DataTable();
        private void verileriGoster()
        {
            lstBilgiler.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From bilet";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["TC"].ToString();
                ekle.SubItems.Add(oku["İsim"].ToString());
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Nereden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["Koltuk_No"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["Otobus"].ToString());
                lstBilgiler.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            verileriGoster();
            this.btnKayitlar.Enabled = false;
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cmbOtobus.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1 || msktxtTC.Text == " " || txtİsim.Text == " " || txtSoyisim.Text == " " || msktxtTelefon.Text == " " || cmbCinsiyet.SelectedIndex == -1 || txtFiyat.Text == " ")
            {
                MessageBox.Show("Lütfen Önce Gerekli Alanları Doldurunuz");
            }

            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into bilet (TC, İsim, Soyisim, Telefon, Cinsiyet, Nereden, Nereye, Otobus, Koltuk_No, Tarih, Fiyat) values ('" + msktxtTC.Text.ToString() + "','" + txtİsim.Text.ToString() + "','" + txtSoyisim.Text.ToString() + "','" + msktxtTelefon.Text.ToString() + "','" + cmbCinsiyet.Text.ToString() + "','" + cmbNereden.Text.ToString() + "','" + cmbNereye.Text.ToString() + "','" + cmbOtobus.Text.ToString() + "','" + tiklanan.Text.ToString() + "','" + dtpTarih.Text.ToString() + "','" + txtFiyat.Text.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (cmbCinsiyet.SelectedIndex == 0)
            {
                tiklanan.BackColor = Color.Blue;
            }
            else
            {
                tiklanan.BackColor = Color.Red;
            }
            this.Refresh();
            msktxtTC.ResetText();
            msktxtTelefon.ResetText();
            txtFiyat.ResetText();
            txtSoyisim.ResetText();
            txtİsim.ResetText();
            cmbCinsiyet.ResetText();
            cmbNereden.ResetText();
            cmbNereye.ResetText();
            dtpTarih.ResetText();
        }
        private void bilet_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbOtobus.Text)
            {
                case "Travego": KoltukDoldur(8, false); 
                    break;
                case "Setra": KoltukDoldur(12, true);
                    break;
                case "Neoplan": KoltukDoldur(10, false);
                    break;
            }
            void KoltukDoldur (int sira , bool arkaBesliMi)
            {
                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if(btn.Text == "Kaydet")
                        {
                            continue;
                        }
                    }
                }
                int koltukNo = 1;
                for (int i = 0; i < sira; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arkaBesliMi == true)
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }
                        }
                            else
                            {
                                if (j == 2)
                                    continue;
                            }
                        
                            Button koltuk = new Button();
                            koltuk.Height = koltuk.Width = 40;
                            koltuk.Top = 30 + (i * 45);
                            koltuk.Left = 35 + (j * 45);
                            koltuk.Text = koltukNo.ToString();
                            koltukNo++;
                            koltuk.ContextMenuStrip = contextMenuStrip1;
                            koltuk.MouseDown += Koltuk_MouseDown; 
                            this.Controls.Add(koltuk);
                    }
                }
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void btnKaydet_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(msktxtTC.Text == "")
            {
                MessageBox.Show("!! Lütfen Silmek İstediğiniz Kişinin TC Kimlik Numarasını Yazınız !!");
            }
            else
            {
                baglanti.Open();
                OleDbCommand silKomut = new OleDbCommand("DELETE FROM bilet where TC = '" + msktxtTC.Text + "'", baglanti);
                silKomut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Silinmiştir");
                this.btnKayitlar.Enabled = true;
                msktxtTC.ResetText();
                lstBilgiler.Items.Clear();
                baglanti.Close();
                verileriGoster();
            }
             
        }

        private void kullanici_Adi_Text_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
