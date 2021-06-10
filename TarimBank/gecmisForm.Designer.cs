
namespace TarimBank
{
    partial class gecmisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gecmisForm));
            this.bslngcDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bitisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.alimRadioButton = new System.Windows.Forms.RadioButton();
            this.satimRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bslngcDateTimePicker
            // 
            this.bslngcDateTimePicker.CustomFormat = "";
            this.bslngcDateTimePicker.Location = new System.Drawing.Point(146, 29);
            this.bslngcDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bslngcDateTimePicker.Name = "bslngcDateTimePicker";
            this.bslngcDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.bslngcDateTimePicker.TabIndex = 2;
            // 
            // bitisDateTimePicker
            // 
            this.bitisDateTimePicker.CustomFormat = "";
            this.bitisDateTimePicker.Location = new System.Drawing.Point(146, 67);
            this.bitisDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bitisDateTimePicker.Name = "bitisDateTimePicker";
            this.bitisDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.bitisDateTimePicker.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAd,
            this.satisMiktar,
            this.toplamFiyat,
            this.islemZamani});
            this.dataGridView1.Location = new System.Drawing.Point(16, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 184);
            this.dataGridView1.TabIndex = 5;
            // 
            // urunAd
            // 
            this.urunAd.DataPropertyName = "urunAd";
            this.urunAd.HeaderText = "Ürün Adı";
            this.urunAd.MinimumWidth = 6;
            this.urunAd.Name = "urunAd";
            // 
            // satisMiktar
            // 
            this.satisMiktar.DataPropertyName = "satisMiktar";
            this.satisMiktar.HeaderText = "Miktar";
            this.satisMiktar.MinimumWidth = 6;
            this.satisMiktar.Name = "satisMiktar";
            // 
            // toplamFiyat
            // 
            this.toplamFiyat.DataPropertyName = "toplamFiyat";
            this.toplamFiyat.HeaderText = "Toplam Fiyat";
            this.toplamFiyat.MinimumWidth = 6;
            this.toplamFiyat.Name = "toplamFiyat";
            // 
            // islemZamani
            // 
            this.islemZamani.DataPropertyName = "islemZamani";
            this.islemZamani.HeaderText = "Islem Zamani";
            this.islemZamani.MinimumWidth = 6;
            this.islemZamani.Name = "islemZamani";
            // 
            // urunComboBox
            // 
            this.urunComboBox.FormattingEnabled = true;
            this.urunComboBox.Location = new System.Drawing.Point(496, 27);
            this.urunComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urunComboBox.Name = "urunComboBox";
            this.urunComboBox.Size = new System.Drawing.Size(102, 21);
            this.urunComboBox.TabIndex = 6;
            this.urunComboBox.Text = "Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(395, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(394, 97);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(204, 25);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.btnCiktiAl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.btnCiktiAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiktiAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiktiAl.ForeColor = System.Drawing.Color.White;
            this.btnCiktiAl.Location = new System.Drawing.Point(511, 341);
            this.btnCiktiAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(87, 25);
            this.btnCiktiAl.TabIndex = 11;
            this.btnCiktiAl.Text = "Çıktı Al";
            this.btnCiktiAl.UseVisualStyleBackColor = false;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // alimRadioButton
            // 
            this.alimRadioButton.AutoSize = true;
            this.alimRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.alimRadioButton.Location = new System.Drawing.Point(398, 65);
            this.alimRadioButton.Name = "alimRadioButton";
            this.alimRadioButton.Size = new System.Drawing.Size(84, 17);
            this.alimRadioButton.TabIndex = 12;
            this.alimRadioButton.TabStop = true;
            this.alimRadioButton.Text = "Alım İşlemleri";
            this.alimRadioButton.UseVisualStyleBackColor = false;
            // 
            // satimRadioButton
            // 
            this.satimRadioButton.AutoSize = true;
            this.satimRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.satimRadioButton.Location = new System.Drawing.Point(514, 65);
            this.satimRadioButton.Name = "satimRadioButton";
            this.satimRadioButton.Size = new System.Drawing.Size(88, 17);
            this.satimRadioButton.TabIndex = 13;
            this.satimRadioButton.TabStop = true;
            this.satimRadioButton.Text = "Satış İşlemleri";
            this.satimRadioButton.UseVisualStyleBackColor = false;
            // 
            // gecmisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TarimBank.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 435);
            this.Controls.Add(this.satimRadioButton);
            this.Controls.Add(this.alimRadioButton);
            this.Controls.Add(this.btnCiktiAl);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bitisDateTimePicker);
            this.Controls.Add(this.bslngcDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gecmisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçmiş";
            this.Load += new System.EventHandler(this.gecmisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker bslngcDateTimePicker;
        private System.Windows.Forms.DateTimePicker bitisDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox urunComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnCiktiAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemZamani;
        private System.Windows.Forms.RadioButton alimRadioButton;
        private System.Windows.Forms.RadioButton satimRadioButton;
    }
}