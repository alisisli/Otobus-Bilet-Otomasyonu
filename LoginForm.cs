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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users/CASPER/Desktop/bilet.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtKAdi.Text;
            string parola = txtSifre.Text;
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login WHERE kullanici = '" + ad + "' AND sifre = '" + parola + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                bilet biletForm = new bilet();
                biletForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            con.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitOlForm kayitform = new KayitOlForm();
            kayitform.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
