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
    public partial class kayitForm : Form
    {
        public kayitForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kullanicilar(kAd,sifre,adSoyad,tc,tel,e_mail,adres)values('" + kAd2Txt.Text + "','" + sifre2Txt.Text + "','" + adSoyadTxt.Text + "','" + tcTxt.Text + "','" + telTxt.Text + "','" + e_mailTxt.Text + "','" + adresTxt.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız tamamlandı");
            kAd2Txt.Text = "";
            sifre2Txt.Text = "";
            adSoyadTxt.Text = "";
            tcTxt.Text = "";
            telTxt.Text = "";
            e_mailTxt.Text = "";
            adresTxt.Text = "";
        }
    }
}
