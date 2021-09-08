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
    public partial class KayitOlForm : Form
    {
        public KayitOlForm()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users/CASPER/Desktop/bilet.accdb");
        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand Kaydetkomut = new OleDbCommand("insert into Login (ad,soyad,kullanici,sifre) values ('" + txtKayitAd.Text.ToString() + "','" + txtKayitSoyad.Text.ToString() + "','" + txtYeniKAdi.Text.ToString() + "','" + txtYeniSifre.Text.ToString() + "')",baglanti);
            Kaydetkomut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti");
            this.Hide();
            LoginForm backLogin = new LoginForm();
            backLogin.Show();
            baglanti.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm backLoginForm = new LoginForm();
            backLoginForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtYeniSifre.PasswordChar = '\0';
            }
            else
            {
                txtYeniSifre.PasswordChar = '*';
            }
        }

        private void KayitOlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
