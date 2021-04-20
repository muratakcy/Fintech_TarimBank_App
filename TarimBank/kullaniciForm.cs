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

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        public void urunComboDoldur()
        {
            string[] urunler = { "Çilek", "Limon", "Mısır", "Havuç" };
            comboBox1.Items.AddRange(urunler);

        }
        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("insert into Onay(kAd,urunMiktar,urunAd)values('" + kAdTut + "','" + Convert.ToInt32(urunMktrTxt.Text) + "','" + comboBox1.SelectedItem + "')", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            urunMktrTxt.Text = "";
            MessageBox.Show("Ürün ekleme talebiniz oluşturulmuştur.Ürününüz onaylandıktan sonra sisteme eklenecektir.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                pictureBox1.Image = Resources.cilek;
            }
            else if (comboBox1.SelectedIndex ==1) { pictureBox1.Image = Resources.lemon; }
            else if (comboBox1.SelectedIndex == 2) { pictureBox1.Image = Resources.misir; }
            else { pictureBox1.Image = Resources.havuc; }

        }

        private void kullaniciForm_Load(object sender, EventArgs e)
        {
            urunComboDoldur();
            OleDbCommand komut = new OleDbCommand("select * from Kullanicilar where kAd='" + kAdTut + "'", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                bkyLabel.Text +=oku["bakiye"]+" TL";
            }
            baglanti.Close();
            adLbl.Text = adTut.ToUpper();


        }

        private void bakiyeBtn_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("insert into Onay(kAd,yuklenenBakiye)values('"+kAdTut+ "','" + Convert.ToInt32(bakiyeTxt.Text)+"')",baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            bakiyeTxt.Text = "";
            MessageBox.Show("Bakiye yükleme talebiniz oluşturulmuştur.Bakiyeniz onaylandıktan sonra sisteme eklenecektir.");
        }

       
    }
}
