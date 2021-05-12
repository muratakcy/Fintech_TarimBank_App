
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunMktrTxt = new System.Windows.Forms.TextBox();
            this.mktrLabel = new System.Windows.Forms.Label();
            this.bkyLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bakiyeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bakiyeTxt = new System.Windows.Forms.TextBox();
            this.adLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.urunlerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            // comboBox1
            // 
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
            this.urunEkleBtn.Location = new System.Drawing.Point(11, 116);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(213, 29);
            this.urunEkleBtn.TabIndex = 0;
            this.urunEkleBtn.Text = "Ürünü Ekle";
            this.urunEkleBtn.UseVisualStyleBackColor = true;
            this.urunEkleBtn.Click += new System.EventHandler(this.urunEkleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunMktrTxt);
            this.groupBox1.Controls.Add(this.mktrLabel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.urunEkleBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN EKLEME";
            // 
            // urunMktrTxt
            // 
            this.urunMktrTxt.Location = new System.Drawing.Point(103, 39);
            this.urunMktrTxt.Name = "urunMktrTxt";
            this.urunMktrTxt.Size = new System.Drawing.Size(121, 23);
            this.urunMktrTxt.TabIndex = 4;
            this.urunMktrTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunMktrTxt_KeyPress);
            // 
            // mktrLabel
            // 
            this.mktrLabel.AutoSize = true;
            this.mktrLabel.Location = new System.Drawing.Point(8, 40);
            this.mktrLabel.Name = "mktrLabel";
            this.mktrLabel.Size = new System.Drawing.Size(89, 17);
            this.mktrLabel.TabIndex = 3;
            this.mktrLabel.Text = "Ürün miktar :";
            // 
            // bkyLabel
            // 
            this.bkyLabel.AutoSize = true;
            this.bkyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkyLabel.Location = new System.Drawing.Point(12, 37);
            this.bkyLabel.Name = "bkyLabel";
            this.bkyLabel.Size = new System.Drawing.Size(79, 18);
            this.bkyLabel.TabIndex = 5;
            this.bkyLabel.Text = "Bakiyeniz :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bakiyeBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bakiyeTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BAKİYE YÜKLEME";
            // 
            // bakiyeBtn
            // 
            this.bakiyeBtn.Location = new System.Drawing.Point(9, 73);
            this.bakiyeBtn.Name = "bakiyeBtn";
            this.bakiyeBtn.Size = new System.Drawing.Size(222, 29);
            this.bakiyeBtn.TabIndex = 5;
            this.bakiyeBtn.Text = "Bakiye Yükle";
            this.bakiyeBtn.UseVisualStyleBackColor = true;
            this.bakiyeBtn.Click += new System.EventHandler(this.bakiyeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakiye Miktar :";
            // 
            // bakiyeTxt
            // 
            this.bakiyeTxt.Location = new System.Drawing.Point(110, 34);
            this.bakiyeTxt.Name = "bakiyeTxt";
            this.bakiyeTxt.Size = new System.Drawing.Size(121, 23);
            this.bakiyeTxt.TabIndex = 0;
            this.bakiyeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bakiyeTxt_KeyPress);
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adLbl.Location = new System.Drawing.Point(12, 9);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(0, 18);
            this.adLbl.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(470, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Alım-Satım İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.urunlerListView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.btnCikis.Location = new System.Drawing.Point(470, 426);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(220, 29);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // kullaniciForm
            // 
            this.ClientSize = new System.Drawing.Size(875, 515);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bkyLabel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "kullaniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.kullaniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView urunlerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCikis;
    }
}