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
        public string kAdTut { get; set; }
        public double bakiyeTut { get; set; }
        string miktarlar;
        string fiyatlar;
        int ilk_Mi ;
        int satisNo,kontrol=1;
        string sat_kAd;
        int sat_miktar;
        int sayac;
        double fiyatTut;
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
            OleDbCommand komut = new OleDbCommand("insert into Satis(kAd,urunAd,miktar,fiyat)values('"+kAdTut+"','"+comboBox1.SelectedItem.ToString()+"',"+Convert.ToInt32(satTxt.Text)+","+Convert.ToDouble(fytTxt.Text)+")", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();                
                MessageBox.Show("Ürününüz Satıştadır");
                OleDbCommand komut2 = new OleDbCommand();
                komut2.Connection = baglanti;
                //Satışa konulan ürün kullanıcının ürün bakiyesinden düşülüyor.
                if (comboBox1.SelectedItem.ToString() == "Çilek")
                {
                    komut2.CommandText="update Kullanicilar set cilek=cilek-" + urunMiktar + " where kAd='" + kAdTut + "' ";       
                }
                else if (comboBox1.SelectedItem.ToString() == "Limon")
                {
                    komut2.CommandText = "update Kullanicilar set limon=limon-" + urunMiktar + " where kAd='" + kAdTut + "' ";
                }
                else if(comboBox1.SelectedItem.ToString() == "Mısır")
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
            fiyatTut = 0;
            OleDbCommand komut = new OleDbCommand("select * from Satis where urunAd='" + comboBox2.SelectedItem.ToString() + "'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sayac++;
                if (sayac == 1)
                {
                    fiyatTut = Convert.ToDouble(oku["fiyat"]);
                    sat_kAd = oku["kAd"].ToString();
                    sat_miktar = Convert.ToInt32(oku["miktar"]);
                    satisNo = Convert.ToInt32(oku["satisNo"]);
                }
                if (Convert.ToDouble(oku["fiyat"]) < fiyatTut)
                {
                    fiyatTut = Convert.ToDouble(oku["fiyat"]);
                    sat_kAd = oku["kAd"].ToString();
                    sat_miktar = Convert.ToInt32(oku["miktar"]);
                    satisNo = Convert.ToInt32(oku["satisNo"]);
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
                label5.Text = fiyatTut.ToString() + " TL";
            }
           
        }
        /*Alım işlemi sonucunda alimSatim tablosuna aktarılan verilerden yararlanılarak ,
        ilgili kullanıcıların bakiyeleri ve ürünleri güncellenmektedir.*/
        public void AlimSatimTamamla()
        {
            string alici, satici,urun;
            int satisMiktar,islemNo;
            double tutar;
            OleDbCommand komut = new OleDbCommand("select * from AlimSatim where durum=" +0+ "", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                alici = oku["alici_kAd"].ToString();
                satici = oku["satici_kAd"].ToString();
                urun = oku["urunAd"].ToString();
                satisMiktar = Convert.ToInt32(oku["satisMiktar"]);
                islemNo = Convert.ToInt32(oku["islemNo"]);
                tutar = Convert.ToDouble(oku["toplamFiyat"]);
                OleDbCommand komut2 = new OleDbCommand("update Kullanicilar set bakiye=bakiye+"+tutar+" where kAd='"+satici+"'", baglanti);
                komut2.ExecuteNonQuery();
                if (urun == "Çilek")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set bakiye=bakiye-" + tutar + ",cilek=cilek+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else if (urun == "Limon")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set bakiye=bakiye-" + tutar + ",limon=limon+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else if (urun == "Mısır")
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set bakiye=bakiye-" + tutar + ",misir=misir+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else 
                {
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set bakiye=bakiye-" + tutar + ",havuc=havuc+" + satisMiktar + " where kAd='" + alici + "'", baglanti);
                    komut3.ExecuteNonQuery();
                }
                OleDbCommand komut4 = new OleDbCommand("update AlimSatim set durum="+1+ " where islemNo=" + islemNo + "", baglanti);
                komut4.ExecuteNonQuery();
            }           
            baglanti.Close(); 
        }
        //bu fonksiyonda alınan ürün fiyat bilgisi ve ürün miktarları gerekli konroller yapılarak AlimSatim tablosuna eklenmektedir.
        public void urunAl()
        {
            miktarlar = "";
            fiyatlar = "";
            int devirMiktar;
            double toplamFiyat;
            int alinanMiktar = Convert.ToInt32(alTxt.Text);
            devirMiktar = alinanMiktar;
            while (devirMiktar > sat_miktar && sayac != 0 && kontrol == 1)
            {
                ilk_Mi++;
                if ((sat_miktar * fiyatTut) > bakiyeTut)
                {
                    kontrol = 0;
                }
                else
                {
                    toplamFiyat = 0;
                    sayac = 0;
                    devirMiktar = devirMiktar - sat_miktar;
                    toplamFiyat = toplamFiyat + (sat_miktar * fiyatTut);
                    bakiyeTut = bakiyeTut - toplamFiyat;
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into AlimSatim(satici_kAd,alici_kAd,urunAd,satisMiktar,toplamFiyat,islemZamani)values('" + sat_kAd + "','" + kAdTut + "','" + comboBox2.SelectedItem.ToString() + "'," + sat_miktar + "," + toplamFiyat + ",'" + DateTime.Now.ToString() + "')", baglanti);
                    komut.ExecuteNonQuery();
                    miktarlar += " " + sat_miktar.ToString() + "kg";
                    fiyatlar += " " + fiyatTut.ToString() + "TL";
                    OleDbCommand komut2 = new OleDbCommand("Delete from Satis where satisNo=" + satisNo + "", baglanti);
                    komut2.ExecuteNonQuery();
                    OleDbCommand komut3 = new OleDbCommand("select * from Satis where urunAd='" + comboBox2.SelectedItem.ToString() + "'", baglanti);
                    OleDbDataReader oku = komut3.ExecuteReader();
                    while (oku.Read())
                    {
                        sayac++;
                        if (sayac == 1)
                        {
                            fiyatTut = Convert.ToDouble(oku["fiyat"]);
                            sat_kAd = oku["kAd"].ToString();
                            sat_miktar = Convert.ToInt32(oku["miktar"]);
                            satisNo = Convert.ToInt32(oku["satisNo"]);
                        }
                        if (Convert.ToDouble(oku["fiyat"]) < fiyatTut)
                        {
                            fiyatTut = Convert.ToDouble(oku["fiyat"]);
                            sat_kAd = oku["kAd"].ToString();
                            sat_miktar = Convert.ToInt32(oku["miktar"]);
                            satisNo = Convert.ToInt32(oku["satisNo"]);
                        }
                    }
                    baglanti.Close();
                }
            }
            if (kontrol == 1 && sayac == 0)
            {
                MessageBox.Show(alinanMiktar + " kg " + comboBox2.SelectedItem.ToString() +
                    " alım işleminizin " + (alinanMiktar - devirMiktar) + " kg kısmı sırası ile" + miktarlar + " /" + fiyatlar + " şeklinde gerçekleştirilmiştir.Kalan " + devirMiktar +
                    " kg kısım ise sistemdeki ürün yetersizliğinden işleme alınmamıştır.");
            }
            else if (kontrol == 0 && ilk_Mi != 1)
            {
                MessageBox.Show(alinanMiktar + " kg " + comboBox2.SelectedItem.ToString() +
                            " alım işleminizin " + (alinanMiktar - devirMiktar) + " kg kısmı sırası ile" +
                            miktarlar + " /" + fiyatlar + " şeklinde gerçekleştirilmiştir.Kalan " + devirMiktar +
                            " kg kısım ise bakiyenizin yetersiz olmasından dolayı işleme alınmamıştır." +
                            Environment.NewLine + "Ürünün güncel fiyatı: :" +
                             fiyatTut + " TL" + Environment.NewLine + "Güncel Bakiyeniz :" + bakiyeTut + " TL");
            }
            else if (kontrol == 0 && ilk_Mi == 1)
            {
                MessageBox.Show("İşlemi gerçekleştirmek için bakiyeniz yetersizdir.");
            }
            else if (ilk_Mi == 0 && (devirMiktar * fiyatTut) > bakiyeTut)
            {
                MessageBox.Show("İşlemi gerçekleştirmek için bakiyeniz yetersizdir.");
            }
            else if ((devirMiktar * fiyatTut) <= bakiyeTut && sayac != 0)
            {
                toplamFiyat = 0;
                baglanti.Open();
                toplamFiyat = toplamFiyat + (devirMiktar * fiyatTut);
                sat_miktar = sat_miktar - devirMiktar;
                OleDbCommand komut = new OleDbCommand("insert into AlimSatim(satici_kAd,alici_kAd,urunAd,satisMiktar,toplamFiyat,islemZamani)values('" + sat_kAd + "','" + kAdTut + "','" + comboBox2.SelectedItem.ToString() + "'," + devirMiktar + "," + toplamFiyat + ",'" + DateTime.Now.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                miktarlar += " " + devirMiktar.ToString() + "kg";
                fiyatlar += " " + fiyatTut.ToString() + "TL";
                if (sat_miktar != 0)
                {
                    OleDbCommand komut2 = new OleDbCommand("update Satis set miktar=" + sat_miktar + " where satisNo=" + satisNo + "", baglanti);
                    komut2.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand komut2 = new OleDbCommand("Delete from Satis where satisNo=" + satisNo + "", baglanti);
                    komut2.ExecuteNonQuery();
                }
                baglanti.Close();
                MessageBox.Show(alinanMiktar + " kg " + comboBox2.SelectedItem.ToString() +
                           " alım işleminizin " + alinanMiktar + " kg kısmı sırası ile" +
                           miktarlar + " /" + fiyatlar + " şeklinde gerçekleştirilmiştir.");
            }
            else
            {
                MessageBox.Show(alinanMiktar + " kg " + comboBox2.SelectedItem.ToString() +
                           " alım işleminizin " + (alinanMiktar - devirMiktar) + " kg kısmı sırası ile" +
                           miktarlar + " /" + fiyatlar + " şeklinde gerçekleştirilmiştir.Kalan" + devirMiktar +
                           " kg kısım ise bakiyenizin yetersiz olmasından dolayı işleme alınmamıştır." +
                           Environment.NewLine + "Ürünün güncel fiyatı: " +
                           fiyatTut + " TL" + Environment.NewLine + "Güncel Bakiyeniz :" + bakiyeTut + " TL");
            }
            comboBox2.Text = "Seçiniz";
            alTxt.Text = "";
            label5.Text = "";
            ilk_Mi = 0;
            kontrol = 1;
            AlimSatimTamamla();
            OleDbCommand komut4 = new OleDbCommand("select * from Kullanicilar where kAd='" + kAdTut + "'", baglanti);
            baglanti.Open();
            OleDbDataReader oku4 = komut4.ExecuteReader();
            if (oku4.Read())
            {
                bakiyeTut = Convert.ToDouble(oku4["bakiye"]);
            }
            baglanti.Close();
        }
        //comboDoldur() fonksiyonu burada çağırılmaktadır.
        private void alimSatimForm_Load(object sender, EventArgs e)
        {
            comboDoldur();
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
            else if (label5.Text == "")
            {
                MessageBox.Show("Seçtiğiniz ürünün satışı bulunmamaktadır.");
            }
            else
            {
                urunAl();
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
