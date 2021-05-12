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
        //Kayit işlemini gerçekleştiren fonksiyon
        public void kayit()
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
        //Boş alan kontroller yapılıp fonksiyon çağırılıyor
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (kAd2Txt.Text == ""|| sifre2Txt.Text == ""|| adSoyadTxt.Text == ""|| tcTxt.Text == ""|| 
                telTxt.Text == ""|| e_mailTxt.Text == ""||adresTxt.Text==""|| kAd2Txt.Text == String.Empty || 
                sifre2Txt.Text == String.Empty|| adSoyadTxt.Text == String.Empty|| tcTxt.Text == String.Empty||
                telTxt.Text == String.Empty|| e_mailTxt.Text == String.Empty|| adresTxt.Text == String.Empty)
            { 
                MessageBox.Show("Lütfen bütün alanları doldurduğunuzdan emin olunuz", "Boş Alan Hatası");
            }
            else
            {
                kayit();
                MessageBox.Show("Kayıt işleminiz tamamlanmıştır.");
            }
        }
        //Telefon Numarası ve Tc numarası için sayısal veri kontrollleri
        private void tcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }
        private void telTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }
    }
}
