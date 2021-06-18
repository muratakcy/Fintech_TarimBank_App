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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace TarimBank
{
    public partial class gecmisForm : Form
    {
        public gecmisForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tarimBank.accdb");
        public string kAdTut { get; set; }
        //Seçilen tarih aralıkları ve ürüne göre kullanıcının alım işlem geçmişini listeleyen fonksiyon
        public void alimlistele()
        {
            DataTable dt = new DataTable();
            string ole = "select urunAd,satisMiktar,toplamFiyat,islemZamani from AlimSatim where islemZamani BETWEEN @baslangic AND @bitis AND alici_kAd=@kAd AND urunAd=@urunAd";
            OleDbDataAdapter da = new OleDbDataAdapter(ole, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@baslangic", bslngcDateTimePicker.Value);
            da.SelectCommand.Parameters.AddWithValue("@bitis", bitisDateTimePicker.Value);
            da.SelectCommand.Parameters.AddWithValue("@kAd", kAdTut);
            da.SelectCommand.Parameters.AddWithValue("@urunAd", urunComboBox.Text);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //Seçilen tarih aralıkları ve ürüne göre kullanıcının satım işlem geçmişini listeleyen fonksiyon
        public void satimListele()
        {
            DataTable dt = new DataTable();
            string ole = "select urunAd,satisMiktar,toplamFiyat,islemZamani from AlimSatim where islemZamani BETWEEN @baslangic AND @bitis AND satici_kAd=@kAd AND urunAd=@urunAd";
            OleDbDataAdapter da = new OleDbDataAdapter(ole, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@baslangic", bslngcDateTimePicker.Value);
            da.SelectCommand.Parameters.AddWithValue("@bitis", bitisDateTimePicker.Value);
            da.SelectCommand.Parameters.AddWithValue("@kAd", kAdTut);
            da.SelectCommand.Parameters.AddWithValue("@urunAd", urunComboBox.Text);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            if(alimRadioButton.Checked==true)
            {
                alimlistele();
            }
            else
            {
                satimListele();
            }
            
        }
        //Form Load olayında bu fonksiyon çalışır ve ürün isimleri combobox a doldurulur.
        public void urunComboDoldur()
        {
            urunComboBox.Items.Clear();
            string[] urunler = { "Çilek", "Limon", "Mısır", "Havuç" };
            urunComboBox.Items.AddRange(urunler);
        }
        private void gecmisForm_Load(object sender, EventArgs e)
        {
            urunComboDoldur();
        }
        //Pdf çıktısı alınması işlemini gerçekleştiren fonksiyon
        public static void PDF_Disa_Aktar(DataGridView dataGridView1)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 80;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; 
                pdfTable.DefaultCell.BorderWidth = 1; 
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); 
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            PDF_Disa_Aktar(dataGridView1);
            MessageBox.Show("Çıktınız pdf olarak oluşturulmuştur.");
        }
    }
}
