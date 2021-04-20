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

namespace TarimBank
{
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kullanicilar where kAd='" + kAd1Txt.Text + "' and sifre='" + sifre1Txt.Text + "'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (oku["yetki"].ToString() == "1")
                {
                    adminForm admin = new adminForm();
                    admin.Show();
                }
                else
                {
                    kullaniciForm kullaniciForm = new kullaniciForm();
                    kullaniciForm.adTut = oku["adSoyad"].ToString();
                    kullaniciForm.kAdTut = oku["kAd"].ToString();
                    kullaniciForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı");
            }
            baglanti.Close();
        }

        private void girisForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            baglanti.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kayitForm kayit = new kayitForm();
            kayit.Show();
        }
    }
}
