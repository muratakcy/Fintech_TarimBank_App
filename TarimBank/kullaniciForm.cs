using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarimBank.Properties;
using System.Data.OleDb;

namespace TarimBank
{
    public partial class kullaniciForm : Form
    {
        public kullaniciForm()
        {
            InitializeComponent();
        }
        public string adTut { get; set; }
        public string kAdTut { get; set; }
        double bakiye = 0;
        

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        //urun adları comboboxa eklenir.
        public void urunComboDoldur()
        {
            comboBox1.Items.Clear();
            string[] urunler = { "Çilek", "Limon", "Mısır", "Havuç" };
            comboBox1.Items.AddRange(urunler);

        }
        //Para birimleri comboboxa eklenir
        public void paraBirimComboDoldur()
        {
            paraBirimcombo.Items.Clear();
            string[] birimlerler = { "TL", "USD", "EUR", "GBP" };
            paraBirimcombo.Items.AddRange(birimlerler);
        }
        //Kullanıcının ürünleri Listeleniyor.
        public void urunListele()
        {
            urunlerListView.Items.Clear();
            OleDbCommand komut = new OleDbCommand("select * from Kullanicilar where kAd='"+kAdTut+"'",baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            ListViewItem ekle = new ListViewItem();
            if (oku.Read())
            {
                
                ekle.Text = oku["cilek"].ToString();
                ekle.SubItems.Add(oku["limon"].ToString());
                ekle.SubItems.Add(oku["misir"].ToString());
                ekle.SubItems.Add(oku["havuc"].ToString());
                urunlerListView.Items.Add(ekle);
            }
            baglanti.Close();

        }
        //Veri tabanından kullanıcı bakiyesi ve adı verileri çekilerek ekranda gösterilir.
        public void bakiyeGoster()
        {
            OleDbCommand komut = new OleDbCommand("select * from Kullanicilar where kAd='" + kAdTut + "'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                bakiye = Convert.ToDouble(oku["bakiye"]);
            }
            baglanti.Close();
            bkyLabel.Text = bakiye.ToString() + " TL";
            adLbl.Text = adTut.ToUpper();
        }
        //Ürün ekleme talebi sisteme iletiliyor.
        public void urunEkle()
        {
            OleDbCommand komut = new OleDbCommand("insert into Onay(kAd,urunMiktar,urunAd)values('" + kAdTut + "','" + Convert.ToInt32(urunMktrTxt.Text) + "','" + comboBox1.SelectedItem + "')", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close(); 
        }
        //Kullanıcının seçtiği para birimine göre akiye ekleme talebi sisteme iletiliyor.
        public void bakiyeEkle()
        {
            int kontrol = 1;
            OleDbCommand komut = new OleDbCommand("insert into Onay(kAd,yuklenenBakiye,try)values('" + kAdTut + "','" + Convert.ToDouble(bakiyeTxt.Text) + "'," + kontrol + ")", baglanti);
            OleDbCommand komut2 = new OleDbCommand("insert into Onay(kAd,yuklenenBakiye,usd)values('" + kAdTut + "','" + Convert.ToDouble(bakiyeTxt.Text) + "'," + kontrol + ")", baglanti);
            OleDbCommand komut3 = new OleDbCommand("insert into Onay(kAd,yuklenenBakiye,eur)values('" + kAdTut + "','" + Convert.ToDouble(bakiyeTxt.Text) + "'," + kontrol + ")", baglanti);
            OleDbCommand komut4 = new OleDbCommand("insert into Onay(kAd,yuklenenBakiye,gbp)values('" + kAdTut + "','" + Convert.ToDouble(bakiyeTxt.Text) + "',"+kontrol+")", baglanti);
            baglanti.Open();
            if (paraBirimcombo.Text=="TL")
            {
                komut.ExecuteNonQuery();
            }
            else if(paraBirimcombo.Text == "USD")
            {
                komut2.ExecuteNonQuery();
            }
            else if(paraBirimcombo.Text == "EUR")
            {
                komut3.ExecuteNonQuery();
            }
            else
            {
                komut4.ExecuteNonQuery();
            }
            baglanti.Close();
           
        }
        //Ürün ekleme butonuna basıldığında urunEkle() fonksiyonu çağırılıyor.
        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            if(urunMktrTxt.Text=="" || comboBox1.Text=="Seçiniz")
            {
                MessageBox.Show("Ürün seçtiğinizden veya ürün miktarı girdiğinizden emin olunuz.");
            }
            else
            {
                urunEkle();
                urunMktrTxt.Text = "";
                comboBox1.Text = "Seçiniz";
                MessageBox.Show("Ürün ekleme talebiniz oluşturulmuştur.Ürününüz onaylandıktan sonra sisteme eklenecektir.");
            }
        }
        //Bakiye yükleme butonuna basıldığında bakiyeEkle() fonksiyonu çağırılıyor.
        private void bakiyeBtn_Click(object sender, EventArgs e)
        {
            if(bakiyeTxt.Text == "" || paraBirimcombo.Text == "Seçiniz")
            {
                MessageBox.Show("Yüklemek istediğiniz bakiye miktarını girdiğinizden ve para birimi seçtiğinizden emin olunuz.");
            }
            else
            {
                bakiyeEkle();
                bakiyeTxt.Text = "";
                paraBirimcombo.Text = "Seçiniz";
                MessageBox.Show("Bakiye yükleme talebiniz oluşturulmuştur.Bakiyeniz onaylandıktan sonra sisteme eklenecektir.");
            }
            
        }
        //Picturebox'a ilgili ürün resmi getirilmektedir.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                pictureBox1.Image = Resources.cilek;
            }
            else if (comboBox1.SelectedIndex ==1) { pictureBox1.Image = Resources.lemon; }
            else if (comboBox1.SelectedIndex == 2) { pictureBox1.Image = Resources.misir; }
            else { pictureBox1.Image = Resources.havuc; }

        }
        //Form yüklenirken fonksiyonlar çağırılarak gerekli veriler veritabanından alınır.
        private void kullaniciForm_Load(object sender, EventArgs e)
        {
            paraBirimComboDoldur();
            urunComboDoldur();
            urunListele();
            bakiyeGoster();
        }
        //Bu buton ile Alım-Satım işlemleri formuna geçilir
        
        //gerekli textbox kontrolleri yapılmaktadır
        private void urunMktrTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Lütfen sayısal veri giriniz");
                e.Handled = true;
            }
        }
        private void bakiyeTxt_KeyPress(object sender, KeyPressEventArgs e)
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
        /*Yenile butonu ile urunListele() ve bakiyeUrunGoster() fonksiyonları tekrar çağırılarak
        güncel bakiye ve ürün durumu kullanıcıya gösterilmektedir.*/
        private void btnYenile_Click(object sender, EventArgs e)
        { 
            urunListele();
            bakiyeGoster();
        }

        private void btnAlimSatim_Click(object sender, EventArgs e)
        {
            alimSatimForm alimSatim = new alimSatimForm();
            alimSatim.bakiyeTut = bakiye;
            alimSatim.kAdTut = this.kAdTut;
            alimSatim.Show();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            gecmisForm gecmis = new gecmisForm();
            gecmis.kAdTut = this.kAdTut;
            gecmis.Show();
        }

        private void btnEmirlerim_Click(object sender, EventArgs e)
        {
            emirlerimForm emirlerim = new emirlerimForm();
            emirlerim.kAdTut = this.kAdTut;
            emirlerim.Show();
        }
    }
}
