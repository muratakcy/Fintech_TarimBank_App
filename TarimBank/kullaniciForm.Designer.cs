
namespace TarimBank
{
    partial class kullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunMktrTxt = new System.Windows.Forms.TextBox();
            this.mktrLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bkyLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paraBirimcombo = new System.Windows.Forms.ComboBox();
            this.bakiyeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bakiyeTxt = new System.Windows.Forms.TextBox();
            this.adLbl = new System.Windows.Forms.Label();
            this.btnAlimSatim = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.urunlerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.btnEmirlerim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // urunEkleBtn
            // 
            this.urunEkleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.urunEkleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.urunEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkleBtn.ForeColor = System.Drawing.Color.White;
            this.urunEkleBtn.Location = new System.Drawing.Point(11, 116);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(213, 29);
            this.urunEkleBtn.TabIndex = 0;
            this.urunEkleBtn.Text = "Ürün Ekle";
            this.urunEkleBtn.UseVisualStyleBackColor = false;
            this.urunEkleBtn.Click += new System.EventHandler(this.urunEkleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.urunMktrTxt);
            this.groupBox1.Controls.Add(this.mktrLabel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.urunEkleBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN EKLEME";
            // 
            // urunMktrTxt
            // 
            this.urunMktrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunMktrTxt.Location = new System.Drawing.Point(103, 39);
            this.urunMktrTxt.Name = "urunMktrTxt";
            this.urunMktrTxt.Size = new System.Drawing.Size(121, 23);
            this.urunMktrTxt.TabIndex = 4;
            this.urunMktrTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunMktrTxt_KeyPress);
            // 
            // mktrLabel
            // 
            this.mktrLabel.AutoSize = true;
            this.mktrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mktrLabel.Location = new System.Drawing.Point(8, 40);
            this.mktrLabel.Name = "mktrLabel";
            this.mktrLabel.Size = new System.Drawing.Size(89, 17);
            this.mktrLabel.TabIndex = 3;
            this.mktrLabel.Text = "Ürün miktar :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TarimBank.Properties.Resources.misir;
            this.pictureBox1.Location = new System.Drawing.Point(11, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bkyLabel
            // 
            this.bkyLabel.AutoSize = true;
            this.bkyLabel.BackColor = System.Drawing.Color.Transparent;
            this.bkyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkyLabel.Location = new System.Drawing.Point(41, 43);
            this.bkyLabel.Name = "bkyLabel";
            this.bkyLabel.Size = new System.Drawing.Size(32, 18);
            this.bkyLabel.TabIndex = 5;
            this.bkyLabel.Text = "asd";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.paraBirimcombo);
            this.groupBox2.Controls.Add(this.bakiyeBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bakiyeTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BAKİYE YÜKLEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para Birimleri :";
            // 
            // paraBirimcombo
            // 
            this.paraBirimcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paraBirimcombo.FormattingEnabled = true;
            this.paraBirimcombo.Location = new System.Drawing.Point(110, 74);
            this.paraBirimcombo.Name = "paraBirimcombo";
            this.paraBirimcombo.Size = new System.Drawing.Size(121, 24);
            this.paraBirimcombo.TabIndex = 5;
            this.paraBirimcombo.Text = "Seçiniz";
            // 
            // bakiyeBtn
            // 
            this.bakiyeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.bakiyeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(190)))), ((int)(((byte)(84)))));
            this.bakiyeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakiyeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeBtn.ForeColor = System.Drawing.Color.White;
            this.bakiyeBtn.Location = new System.Drawing.Point(9, 116);
            this.bakiyeBtn.Name = "bakiyeBtn";
            this.bakiyeBtn.Size = new System.Drawing.Size(222, 29);
            this.bakiyeBtn.TabIndex = 5;
            this.bakiyeBtn.Text = "Bakiye Yükle";
            this.bakiyeBtn.UseVisualStyleBackColor = false;
            this.bakiyeBtn.Click += new System.EventHandler(this.bakiyeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakiye Miktar :";
            // 
            // bakiyeTxt
            // 
            this.bakiyeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeTxt.Location = new System.Drawing.Point(110, 40);
            this.bakiyeTxt.Name = "bakiyeTxt";
            this.bakiyeTxt.Size = new System.Drawing.Size(121, 23);
            this.bakiyeTxt.TabIndex = 0;
            this.bakiyeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bakiyeTxt_KeyPress);
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.BackColor = System.Drawing.Color.Transparent;
            this.adLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adLbl.Location = new System.Drawing.Point(12, 12);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(0, 18);
            this.adLbl.TabIndex = 7;
            // 
            // btnAlimSatim
            // 
            this.btnAlimSatim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
            this.btnAlimSatim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
            this.btnAlimSatim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimSatim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlimSatim.ForeColor = System.Drawing.Color.White;
            this.btnAlimSatim.Location = new System.Drawing.Point(470, 411);
            this.btnAlimSatim.Name = "btnAlimSatim";
            this.btnAlimSatim.Size = new System.Drawing.Size(220, 29);
            this.btnAlimSatim.TabIndex = 8;
            this.btnAlimSatim.Text = "Alım-Satım İşlemleri";
            this.btnAlimSatim.UseVisualStyleBackColor = false;
            this.btnAlimSatim.Click += new System.EventHandler(this.btnAlimSatim_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.urunlerListView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(184, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 173);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜNLERİM";
            // 
            // urunlerListView
            // 
            this.urunlerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.urunlerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunlerListView.HideSelection = false;
            this.urunlerListView.Location = new System.Drawing.Point(11, 21);
            this.urunlerListView.Name = "urunlerListView";
            this.urunlerListView.Size = new System.Drawing.Size(487, 137);
            this.urunlerListView.TabIndex = 0;
            this.urunlerListView.UseCompatibleStateImageBehavior = false;
            this.urunlerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Çilek Miktarı";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Limon Miktarı";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mısır Miktarı";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Havuç Miktarı";
            this.columnHeader4.Width = 93;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(747, 505);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 29);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TarimBank.Properties.Resources.para;
            this.pictureBox2.Location = new System.Drawing.Point(3, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.btnYenile.BackgroundImage = global::TarimBank.Properties.Resources.refresh;
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(223)))), ((int)(((byte)(188)))));
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Location = new System.Drawing.Point(3, 76);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(40, 42);
            this.btnYenile.TabIndex = 12;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
            this.btnGecmis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
            this.btnGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmis.ForeColor = System.Drawing.Color.White;
            this.btnGecmis.Location = new System.Drawing.Point(470, 446);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(220, 29);
            this.btnGecmis.TabIndex = 13;
            this.btnGecmis.Text = "İşlem Geçmişi";
            this.btnGecmis.UseVisualStyleBackColor = false;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // btnEmirlerim
            // 
            this.btnEmirlerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
            this.btnEmirlerim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
            this.btnEmirlerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmirlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmirlerim.ForeColor = System.Drawing.Color.White;
            this.btnEmirlerim.Location = new System.Drawing.Point(470, 376);
            this.btnEmirlerim.Name = "btnEmirlerim";
            this.btnEmirlerim.Size = new System.Drawing.Size(220, 29);
            this.btnEmirlerim.TabIndex = 14;
            this.btnEmirlerim.Text = "Emirlerim";
            this.btnEmirlerim.UseVisualStyleBackColor = false;
            this.btnEmirlerim.Click += new System.EventHandler(this.btnEmirlerim_Click);
            // 
            // kullaniciForm
            // 
            this.BackgroundImage = global::TarimBank.Properties.Resources._5104194;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 546);
            this.Controls.Add(this.btnEmirlerim);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAlimSatim);
            this.Controls.Add(this.adLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bkyLabel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullaniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.kullaniciForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button urunEkleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bkyLabel;
        private System.Windows.Forms.TextBox urunMktrTxt;
        private System.Windows.Forms.Label mktrLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bakiyeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bakiyeTxt;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.Button btnAlimSatim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView urunlerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox paraBirimcombo;
        private System.Windows.Forms.Button btnEmirlerim;
    }
}