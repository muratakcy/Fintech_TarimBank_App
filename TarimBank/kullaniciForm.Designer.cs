
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
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
            this.bkyLabel.Location = new System.Drawing.Point(703, 37);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
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
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adLbl.Location = new System.Drawing.Point(703, 9);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(46, 18);
            this.adLbl.TabIndex = 7;
            this.adLbl.Text = "label2";
            // 
            // kullaniciForm
            // 
            this.ClientSize = new System.Drawing.Size(833, 416);
            this.Controls.Add(this.adLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bkyLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "kullaniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.kullaniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekleBtn;
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
    }
}