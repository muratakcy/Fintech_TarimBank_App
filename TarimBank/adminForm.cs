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
using System.Xml;

namespace TarimBank
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        Boolean urunIslemNoKontrol,bakiyeIslemNoKontrol;
        //Kullanıcıların ürün ekleme talepleri listelenir.
        public void urunIstekGoster()
        {
            urunListView.Items.Clear();
            OleDbCommand komut = new OleDbCommand("select * from Onay", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            { 
                if (oku["urunMiktar"].ToString() != "0")
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["islemNo"].ToString();
                    ekle.SubItems.Add(oku["kAd"].ToString());
                    ekle.SubItems.Add(oku["urunAd"].ToString());
                    ekle.SubItems.Add(oku["urunMiktar"].ToString());
                    urunListView.Items.Add(ekle);
                }
            }
            baglanti.Close();
        }
        //Adminin alım işlemlerinden topladığı komisyonun ekranda gösterilmesini sağlayan fonksiyon.
        public void komisyonGoster()
        {
            OleDbCommand komut = new OleDbCommand("select * from Kullanicilar where kAd='admin'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                komisyonLabel.Text = Convert.ToDouble(oku["bakiye"])+" TL";
            }
            baglanti.Close();
        }
        //Kullanıcıların bakiye yükleme talepleri listelenir.
        public void bakiyeIstekGoster(){
            double bakiyeKontrol = 0;
            bakiyeListView.Items.Clear();
            OleDbCommand komut = new OleDbCommand("select * from Onay", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToDouble(oku["yuklenenBakiye"]) != bakiyeKontrol)
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["islemNo"].ToString();
                    ekle.SubItems.Add(oku["kAd"].ToString());
                    ekle.SubItems.Add(oku["yuklenenBakiye"].ToString());
                    bakiyeListView.Items.Add(ekle);
                }
            }
            baglanti.Close();
        }
        //Onaylanan ürün yükleme talebi,tablodan silinir
        public void urunOnay()
        {
            OleDbCommand komut = new OleDbCommand("delete from Onay where islemNo=" + Convert.ToInt32(urnOnyTxt.Text) + "", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //Onaylanan bakiye yükleme talebi,tablodan silinir
        public void bakiyeOnay()
        {
            OleDbCommand komut = new OleDbCommand("delete from Onay where islemNo=" + Convert.ToInt32(bkyOnyTxt.Text) + "", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //Kullanıcının onaylanan ürünü , ürün bakiyesine eklenmektedir.  
        public Boolean urunAktar()
        {
            string kAd;
            int miktar = 0;
            OleDbCommand komut = new OleDbCommand("select * from Onay where islemNo=" + Convert.ToInt32(urnOnyTxt.Text) + "and yuklenenBakiye="+0+"", baglanti);           
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                urunIslemNoKontrol = true;
                kAd = oku["kAd"].ToString() ;
                miktar = Convert.ToInt32(oku["urunMiktar"]);

                if (oku["urunAd"].ToString() == "Havuç") { 
                    OleDbCommand komut2 = new OleDbCommand("update Kullanicilar set havuc=havuc+"+miktar+" where kAd='"+kAd+"' ", baglanti);
                    komut2.ExecuteNonQuery();
                }
                else if (oku["urunAd"].ToString() == "Çilek")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set cilek=cilek+" +miktar + " where kAd='" + kAd + "' ", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else if (oku["urunAd"].ToString() == "Limon")
                {
                    OleDbCommand komut4 = new OleDbCommand("update Kullanicilar set limon=limon+" + miktar + " where kAd='" + kAd + "' ", baglanti);
                    komut4.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand komut5 = new OleDbCommand("update Kullanicilar set misir=misir+" + miktar + " where kAd='" + kAd + "' ", baglanti);
                    komut5.ExecuteNonQuery();
                }
            }
            baglanti.Close();
            return urunIslemNoKontrol;


        }
        //Kullanıcının anlık döviz kuruna göre onaylanan bakiyesi , Tl bakiyesine dönüştürülerek mevcut bakiyesine eklenmektedir.  
        public Boolean bakiyeAktar()
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string usd;
            string eur;
            string gbp;
            string kAd;
            double bakiye = 0 ;
            int kontrol = 1;
            OleDbCommand komut = new OleDbCommand("select * from Onay where islemNo=" + Convert.ToInt32(bkyOnyTxt.Text) + "and urunMiktar=" + 0 + "", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                bakiyeIslemNoKontrol = true;
                kAd = oku["kAd"].ToString();

                if (Convert.ToInt32(oku["usd"]) == kontrol)
                {
                    usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
                    bakiye = Convert.ToDouble(oku["yuklenenBakiye"]) * (Convert.ToDouble(usd) * 1 / 10000);
                }
                else if (Convert.ToInt32(oku["eur"]) == kontrol)
                {
                    eur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
                    bakiye = Convert.ToDouble(oku["yuklenenBakiye"]) * (Convert.ToDouble(eur) * 1 / 10000);
                }
                else if (Convert.ToInt32(oku["gbp"]) == kontrol)
                {
                    gbp = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
                    bakiye = Convert.ToDouble(oku["yuklenenBakiye"]) * (Convert.ToDouble(gbp) * 1 / 10000);
                }
                else
                {
                    bakiye = Convert.ToDouble(oku["yuklenenBakiye"]);
                }
                OleDbCommand komut2 = new OleDbCommand("update Kullanicilar set bakiye=bakiye+'" + bakiye + "' where kAd='" + kAd + "' ", baglanti);
                komut2.ExecuteNonQuery();
            }
            baglanti.Close();  
            return bakiyeIslemNoKontrol;
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            urunIstekGoster();
            bakiyeIstekGoster();
            komisyonGoster();
        }
        //Ürün onay butonuna basıldığında gerekli kontroller gerçekleştirilip fonksiyonlar çağırılır.
        private void btnUrnOnay_Click(object sender, EventArgs e)
        {
            if (urnOnyTxt.Text=="")
            {
                MessageBox.Show("Lütfen bir talep numarası girdiğinizden emin olunuz");
            }
            else if(urunAktar()== false)
            {
                MessageBox.Show("Ürün ekleme talebi bulunamadı");
            }
            else
            {
                urunOnay();
                urunIslemNoKontrol =false;
                urunIstekGoster();
                MessageBox.Show("İşlem Onaylandı");
            }
        }
        //Bakiye onay butonuna basıldığında gerekli kontroller gerçekleştirilip fonksiyonlar çağırılır.
        private void btnBkyOnay_Click(object sender, EventArgs e)
        {
            if (bkyOnyTxt.Text == "")
            {
                MessageBox.Show("Lütfen bir talep numarası girdiğinizden emin olunuz");
            }
            else if (bakiyeAktar() == false)
            {
                MessageBox.Show("Bakiye yükleme talebi bulunamadı");
            }
            else
            {
                bakiyeOnay();
                bakiyeIslemNoKontrol = false;
                bakiyeIstekGoster();
                MessageBox.Show("İşlem Onaylandı");
            }
        }
        //Textboxlara ilişkin string veri tipi kontrolü yapılmaktadır.
        private void urnOnyTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }
        private void bkyOnyTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }

        //Çıkış işlemleri
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkış yapmak istediğinize eminmisiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("İşlemlerinize devam edebilirsiniz !!");
            }
        }
    }
}
