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
    public partial class emirlerimForm : Form
    {
        public emirlerimForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        public string kAdTut { get; set; }
        public void emirListele()
        {
            DataTable dt = new DataTable();
            string ole = "select urunAd,miktar,fiyat_emri from AlimEmir where kAd=@kAd";
            OleDbDataAdapter da = new OleDbDataAdapter(ole, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@kAd", kAdTut);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void emirlerimForm_Load(object sender, EventArgs e)
        {
            emirListele();
        }
    }
}
