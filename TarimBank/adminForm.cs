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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");

        //Kullanıcıların ürün ekleme talepleri listelenir.
        public void urunIstekGoster()
        {
            urunListView.Items.Clear();
            OleDbCommand komut = new OleDbCommand("select * from Onay where onayDurum="+0+"", baglanti);
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
        //Kullanıcıların bakiye yükleme talepleri listelenir.
        public void bakiyeIstekGoster(){
            bakiyeListView.Items.Clear();
            OleDbCommand komut = new OleDbCommand("select * from Onay where onayDurum=" + 0 + "", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["yuklenenBakiye"].ToString() != "0")
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
        //Onaylanacak ürünün onay durumu güncellenir.
        public void urunOnay()
        {
            OleDbCommand komut = new OleDbCommand("update Onay set onayDurum="+1+" where islemNo=" + Convert.ToInt32(urnOnyTxt.Text) + "", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //Onaylanacak bakiyenin onay durumu güncellenir.
        public void bakiyeOnay()
        {
            OleDbCommand komut = new OleDbCommand("update Onay set onayDurum=" + 1 + " where islemNo=" + Convert.ToInt32(bkyOnyTxt.Text) + "", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //Kullanıcının onaylanan ürünü , ürün bakiyesine eklenmektedir.  
        public void urunAktar()
        {
            string kAd;
            int miktar = 0;
            OleDbCommand komut = new OleDbCommand("select * from Onay where islemNo=" + Convert.ToInt32(urnOnyTxt.Text) + "", baglanti);           
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                kAd = oku["kAd"].ToString() ;
                miktar = Convert.ToInt32(oku["urunMiktar"]);

                if (oku["urunAd"].ToString() == "Havuç") { 
                    OleDbCommand komut3 = new OleDbCommand("update Kullanicilar set havuc=havuc+"+miktar+" where kAd='"+kAd+"' ", baglanti);
                    komut3.ExecuteNonQuery();
                }
                else if (oku["urunAd"].ToString() == "Çilek")
                {
                    OleDbCommand komut4 = new OleDbCommand("update Kullanicilar set cilek=cilek+" +miktar + " where kAd='" + kAd + "' ", baglanti);
                    komut4.ExecuteNonQuery();
                }
                else if (oku["urunAd"].ToString() == "Limon")
                {
                    OleDbCommand komut5 = new OleDbCommand("update Kullanicilar set limon=limon+" + miktar + " where kAd='" + kAd + "' ", baglanti);
                    komut5.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand komut6 = new OleDbCommand("update Kullanicilar set misir=misir+" + miktar + " where kAd='" + kAd + "' ", baglanti);
                    komut6.ExecuteNonQuery();
                }
            }
            baglanti.Close();
            MessageBox.Show("İşlem Onaylandı");
            
        }
        //Kullanıcının onaylanan bakiyesi , Tl bakiyesine eklenmektedir.  
        public void bakiyeAktar()
        {
            string kAd;
            int bakiye = 0;
            OleDbCommand komut = new OleDbCommand("select * from Onay where islemNo=" + Convert.ToInt32(bkyOnyTxt.Text) + "", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                kAd = oku["kAd"].ToString();
                bakiye = Convert.ToInt32(oku["yuklenenBakiye"]);
                OleDbCommand komut2 = new OleDbCommand("update Kullanicilar set bakiye=bakiye+" + bakiye + " where kAd='" + kAd + "' ", baglanti);
                komut2.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("İşlem Onaylandı");
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            urunIstekGoster();
            bakiyeIstekGoster();
        }
        private void btnUrnOnay_Click(object sender, EventArgs e)
        {
            urunOnay();
            urunAktar();
            urunIstekGoster();
        }
        private void btnBkyOnay_Click(object sender, EventArgs e)
        {
            bakiyeOnay();
            bakiyeAktar();
            bakiyeIstekGoster();
        }
    }
}
