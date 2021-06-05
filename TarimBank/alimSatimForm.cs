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
    public partial class alimSatimForm : Form
    {
        public alimSatimForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        public string kAdTut { get; set; }
        public double bakiyeTut { get; set; }
        int satisNo;
        int alimEmirNo = 0;
        string sat_kAd;
        int sat_miktar;
        int sayac;
        int emirMiktar;
        double emirFiyat,komisyon,toplamTutar;
        string emirUrunAd;
        double fiyat_goster;
        //Ürünlerin listelendiği comboboxlar doldurulur.
        public void comboDoldur()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string[] urunler = { "Çilek", "Limon", "Mısır", "Havuç" };
            comboBox1.Items.AddRange(urunler);
            comboBox2.Items.AddRange(urunler);
        }
        //Kullanıcı satacağı ürünün türünü,miktarını ve fiyatını belirleyip satışa sunmaktadır.
        public void urunSat()
        {
            int urunMiktar = Convert.ToInt32(satTxt.Text);
            OleDbCommand komut = new OleDbCommand("insert into Satis(kAd,urunAd,miktar,fiyat)values('" + kAdTut + "','" + comboBox1.SelectedItem.ToString() + "'," + Convert.ToInt32(satTxt.Text) + "," + Convert.ToDouble(fytTxt.Text) + ")", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürününüz Satıştadır");
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglanti;
            //Satışa konulan ürün kullanıcının ürün bakiyesinden düşülüyor.
            if (comboBox1.SelectedItem.ToString() == "Çilek")
            {
                komut2.CommandText = "update Kullanicilar set cilek=cilek-" + urunMiktar + " where kAd='" + kAdTut + "' ";
            }
            else if (comboBox1.SelectedItem.ToString() == "Limon")
            {
                komut2.CommandText = "update Kullanicilar set limon=limon-" + urunMiktar + " where kAd='" + kAdTut + "' ";
            }
            else if (comboBox1.SelectedItem.ToString() == "Mısır")
            {
                komut2.CommandText = "update Kullanicilar set misir=misir-" + urunMiktar + " where kAd='" + kAdTut + "' ";
            }
            else
            {
                komut2.CommandText = "update Kullanicilar set havuc=havuc-" + urunMiktar + " where kAd='" + kAdTut + "' ";
            }
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
        //Alınacak ürünün en uygun fiyatlısını ekranda gösterme işlemini gerçekleştirilmektedir.
        public void fiyatGoster()
        {
            sayac = 0;
            fiyat_goster = 0;
            OleDbCommand komut = new OleDbCommand("select * from Satis where urunAd='" + comboBox2.SelectedItem.ToString() + "'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sayac++;
                if (sayac == 1)
                {
                    fiyat_goster = Convert.ToDouble(oku["fiyat"]);                  
                }
                if (Convert.ToDouble(oku["fiyat"]) < fiyat_goster)
                {
                    fiyat_goster = Convert.ToDouble(oku["fiyat"]);
                }

            }
            baglanti.Close();
            if (sayac == 0)
            {
                label5.Text = "";
                MessageBox.Show("Seçtiğiniz ürünün satışı bulunmamaktadır.");
                comboBox2.Text = "Seçiniz";

            }
            else
            {
                label5.Text = fiyat_goster.ToString() + " TL";
            }

        }
        /*Alım işlemi sonucunda alimSatim tablosuna aktarılan verilerden yararlanılarak ,
        ilgili kullanıcıların bakiyeleri ve ürünleri güncellenmektedir.*/
        public void alimSatimTamamla()
        {
            string alici, satici, urun;
            int satisMiktar, islemNo;
            double tutar;
            OleDbCommand komut = new OleDbCommand("select * from AlimSatim where durum=" + 0 + "", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                alici = oku["alici_kAd"].ToString();
                satici = oku["satici_kAd"].ToString();
                urun = oku["urunAd"].ToString();
                satisMiktar = Convert.ToInt32(oku["satisMiktar"]);
                islemNo = Convert.ToInt32(oku["islemNo"]);
                tutar = Convert.ToDouble(oku["toplamFiyat"]);
                OleDbCommand komut2 = new OleDbCommand("update Kullanicilar set bakiye=bakiye+@tutar where kAd='" + satici + "'", baglanti); 
                komut2.Parameters.AddWithValue("@tutar", tutar);
                komut2.ExecuteNonQuery();
                if (urun == "Çilek")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set cilek=cilek+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else if (urun == "Limon")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set limon=limon+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else if (urun == "Mısır")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set misir=misir+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set havuc=havuc+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                OleDbCommand komut4 = new OleDbCommand("update AlimSatim set durum=" + 1 + " where islemNo=" + islemNo + "", baglanti);
                komut4.ExecuteNonQuery();
            }
            baglanti.Close();
        } 
        /*bu fonksiyonda alınan ürün fiyat bilgisi ve ürün miktarları gerekli konroller yapılarak 
         AlimSatim tablosuna eklenmektedir.Satış tablosu ve, alım emirleri tabloları güncellenmektedir. 
        */
        public void urunAl()
        {
            //int devirMiktar;
            double toplamFiyat=0;
            int alinanMiktar = emirMiktar;
            //devirMiktar = alinanMiktar;   
            if (emirMiktar > sat_miktar)
            {
                alinanMiktar = sat_miktar;
                emirMiktar = emirMiktar - alinanMiktar;
                toplamFiyat = alinanMiktar * emirFiyat;
                OleDbCommand komut = new OleDbCommand("insert into AlimSatim(satici_kAd,alici_kAd,urunAd,satisMiktar,toplamFiyat,islemZamani)values('" + sat_kAd + "','" + kAdTut + "','" + emirUrunAd + "'," + alinanMiktar + ", @toplamFiyat,'" + DateTime.Now + "')", baglanti);
                komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
                OleDbCommand komut2 = new OleDbCommand("update AlimEmir set miktar=" + emirMiktar + " where alimEmirNo=" + alimEmirNo + "", baglanti);
                OleDbCommand komut3 = new OleDbCommand("Delete from Satis where satisNo=" + satisNo + "", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Birim Fiyatı " + emirFiyat + " TL den " + alinanMiktar + " adet " + emirUrunAd +
                    " alım işleminiz tamamlanmıştır." );
            }
            else if(emirMiktar < sat_miktar)
            {
                toplamFiyat = alinanMiktar * emirFiyat;
                sat_miktar = sat_miktar - alinanMiktar;
                OleDbCommand komut = new OleDbCommand("insert into AlimSatim(satici_kAd,alici_kAd,urunAd,satisMiktar,toplamFiyat,islemZamani)values('" + sat_kAd + "','" + kAdTut + "','" + emirUrunAd + "'," + alinanMiktar + ", @toplamFiyat,'" + DateTime.Now + "')", baglanti);
                komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
                OleDbCommand komut4 = new OleDbCommand("update Satis set miktar=" + sat_miktar + " where satisNo=" + satisNo + "", baglanti);
                OleDbCommand komut5 = new OleDbCommand("Delete from AlimEmir where alimEmirNo=" + alimEmirNo + "", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut4.ExecuteNonQuery();
                komut5.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Birim Fiyatı " + emirFiyat + " TL den " + alinanMiktar + " adet " + emirUrunAd + 
                    " alım işleminiz tamamlanmıştır.");
            }
            else
            {
                toplamFiyat = alinanMiktar * emirFiyat;
                OleDbCommand komut = new OleDbCommand("insert into AlimSatim(satici_kAd,alici_kAd,urunAd,satisMiktar,toplamFiyat,islemZamani)values('" + sat_kAd + "','" + kAdTut + "','" + emirUrunAd + "'," + alinanMiktar + ", @toplamFiyat,'" + DateTime.Now + "')", baglanti);
                komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
                OleDbCommand komut5 = new OleDbCommand("Delete from AlimEmir where alimEmirNo=" + alimEmirNo + "", baglanti);
                OleDbCommand komut3 = new OleDbCommand("Delete from Satis where satisNo=" + satisNo + "", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut3.ExecuteNonQuery();
                komut5.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Birim Fiyatı " + emirFiyat + " TL den " + alinanMiktar + " adet " + emirUrunAd +
                    " alım işleminiz tamamlanmıştır.");
            }
            alimSatimTamamla();
        }
        /*Veri tabanında kullanıcın istediği kriterlere uygun satış var ise satıcı bilgileri bu fonksiyonda çekilmektedir.*/
        public int saticiBilgileriAl()
        {
            int durum = 0;
            OleDbCommand komut = new OleDbCommand("select * from Satis where urunAd='" + emirUrunAd + "' and fiyat=@fiyat", baglanti);
            komut.Parameters.AddWithValue("@fiyat", emirFiyat);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                durum = 1;
                sat_kAd = oku["kAd"].ToString();
                sat_miktar = Convert.ToInt32(oku["miktar"]);
                satisNo = Convert.ToInt32(oku["satisNo"]);
            }
            baglanti.Close();
            return durum;
        }
        /*Alım emri bu fonksiyonda oluşmaktadır*/
        public void alimEmir()
        {
            OleDbCommand komut = new OleDbCommand("insert into AlimEmir(kAd,urunAd,miktar,fiyat_emri)values('" + kAdTut + "','" + emirUrunAd.ToString() + "'," + Convert.ToInt32(emirMiktar) + ",@fiyat)", baglanti);
            komut.Parameters.AddWithValue("@fiyat", emirFiyat);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçtiğiniz fiyattan alım emri oluşturulmuştur." 
                + Environment.NewLine+ " Komisyon Tutarı : " + komisyon); 
            bakiyeGuncelle(toplamTutar);
            bakiyeTut = bakiyeTut - toplamTutar;
        }
        /*Bu fonksiyon kullanıcın bakiyesi güncellenmektedir*/
        public void bakiyeGuncelle(double tutar)
        {
            OleDbCommand komut = new OleDbCommand("update Kullanicilar set bakiye=bakiye-'" +tutar+ "' where kAd='" + kAdTut + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        /*Form Load olayında bu fonksiyon çağırılır ve kullanıcının sistemde bekletilen emirleri
         tek tek kontrol edilir satışta istediği fiyattan ürün olduğunda satıcı bilgileri 
        alınarak ürün alma işlemi tamamlanır*/
        public void emirTara()
        {
            OleDbCommand komut = new OleDbCommand("select * from AlimEmir where kAd='" + kAdTut + "'", baglanti2);
            baglanti2.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                emirFiyat = Convert.ToDouble(oku["fiyat_emri"]);
                emirMiktar = Convert.ToInt32(oku["miktar"]);
                emirUrunAd = oku["urunAd"].ToString();
                alimEmirNo = Convert.ToInt32(oku["alimEmirNo"]); 
                if (saticiBilgileriAl()==1)
                {
                    urunAl();
                }
            }
            baglanti2.Close();
        }
        //Adminin bakiyesine komisyon tutarı eklenir.
        public void komisyonAktar(double komisyon)
        {
            string admin = "admin";
            OleDbCommand komut = new OleDbCommand("update Kullanicilar set bakiye=bakiye+'" + komisyon + "' where kAd='"+admin+"'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //comboDoldur() fonksiyonu burada çağırılmaktadır.
        private void alimSatimForm_Load(object sender, EventArgs e)
        {
            comboDoldur();
            emirTara();
        }
        //Kullanıcının satacağı üründen elinde ne kadar olduğu ekranda gösterilir.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            OleDbCommand komut = new OleDbCommand("select * from Kullanicilar where kAd='"+kAdTut+"'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                if(comboBox1.SelectedItem.ToString()=="Çilek")
                {
                    mevcutUrunLabel.Text= oku["cilek"].ToString();
                }
                else if(comboBox1.SelectedItem.ToString() == "Limon")
                {
                    mevcutUrunLabel.Text = oku["limon"].ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Mısır")
                {
                    mevcutUrunLabel.Text = oku["misir"].ToString();
                }
                else
                {
                    mevcutUrunLabel.Text = oku["havuc"].ToString();
                }
            }
            baglanti.Close();
        }
        //urunSat() fonksiyonu burada çağırılmaktadır.
        private void btnSat_Click(object sender, EventArgs e)
        {
            if (satTxt.Text == "" || fytTxt.Text == "")
            {
                MessageBox.Show("Lütfen fiyat ve miktar girdiğinizden emin olunuz !!");
            }
            else if(Convert.ToInt32(satTxt.Text) == 0 || Convert.ToInt32(fytTxt.Text)  == 0)
            {
                MessageBox.Show("Fiyat veya miktar 0 olamaz !!");
            }
            else if (mevcutUrunLabel.Text=="")
            {
                MessageBox.Show("Lütfen ürün Seçiniz");
            }
            else if (Convert.ToInt32(mevcutUrunLabel.Text) < Convert.ToInt32(satTxt.Text))
            {
                MessageBox.Show("İşlemi gerçekleştirmek için yeterli ürününüz bulunmamaktadır.");
            }
            else
            {
                urunSat();
            }
        }
        //fiyatGoster() fonksiyonu burada çağırılmaktadır.
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fiyatGoster();
        }
        //gerekli kontroller yapılarak urunAl() fonksiyonu çağırılmaktadır.
        private void btnAl_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Seçiniz" || alTxt.Text == "")
            {
                MessageBox.Show("Lütfen ürün seçiniz veya miktar girdiğinizden emin olunuz !!");
            }
            else if(Convert.ToInt32(alTxt.Text)== 0)
            {
                MessageBox.Show("Miktar 0 olamaz !!");
            }
            else 
            {
                emirMiktar = Convert.ToInt32(alTxt.Text);
                emirUrunAd = comboBox2.SelectedItem.ToString();
                emirFiyat = Convert.ToDouble(emirFytTxt.Text);
                toplamTutar = 0;
                komisyon = 0;
                toplamTutar = (emirFiyat * emirMiktar) + (emirFiyat * emirMiktar) / 100;
                komisyon = (emirFiyat * emirMiktar) / 100;//Yapılacak alım işlemi için komisyon hesaplanmaktadır
                if (toplamTutar > bakiyeTut)
                {
                    MessageBox.Show("Lütfen Bakiyenizi Kontrol ediniz");
                }
                else if (saticiBilgileriAl() == 0)
                {
                    /*Alıcının girdiği fiyattan ürün satışı yok ise Alım Emri oluşur.
                    //Alıcı Listelenen en uygun fiyattan o ürünü almak istediğinde ekrandaki fiyatı yazması yeterli 
                    olacaktır.Ve istediği fiyattan ürün Alım işlemi gerçekleşecektir.
                    */
                    komisyonAktar(komisyon);
                    alimEmir();
                }
                else
                {
                    if(emirMiktar<sat_miktar)
                    {
                        bakiyeTut = bakiyeTut - toplamTutar;                                         
                    }
                    else if(emirMiktar>sat_miktar)
                    {
                        toplamTutar = (emirFiyat * sat_miktar) + (emirFiyat * sat_miktar)/ 100;
                        komisyon = (emirFiyat * sat_miktar) / 100;
                        bakiyeTut = bakiyeTut - toplamTutar;
                                              
                    }
                    else
                    {
                        bakiyeTut = bakiyeTut - toplamTutar;
                        
                    }
                    alimEmirNo = 0;
                    bakiyeGuncelle(toplamTutar);
                    komisyonAktar(komisyon);
                    urunAl();
                    MessageBox.Show(" Komisyon Tutarı : " + komisyon);
                }
            }
        }
        private void fytTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }
        //textboxlar için gerekli string veri kontrolleri.
        private void satTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }

        private void alTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }
    }
}
