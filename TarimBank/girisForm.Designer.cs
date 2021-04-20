
namespace TarimBank
{
    partial class girisForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifre1Txt = new System.Windows.Forms.TextBox();
            this.kAd1Txt = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // sifre1Txt
            // 
            this.sifre1Txt.Location = new System.Drawing.Point(139, 79);
            this.sifre1Txt.Name = "sifre1Txt";
            this.sifre1Txt.PasswordChar = '*';
            this.sifre1Txt.Size = new System.Drawing.Size(156, 22);
            this.sifre1Txt.TabIndex = 56;
            // 
            // kAd1Txt
            // 
            this.kAd1Txt.Location = new System.Drawing.Point(139, 39);
            this.kAd1Txt.Name = "kAd1Txt";
            this.kAd1Txt.Size = new System.Drawing.Size(156, 22);
            this.kAd1Txt.TabIndex = 55;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(220, 118);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 25);
            this.btnKayit.TabIndex = 54;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(139, 118);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 25);
            this.btnGiris.TabIndex = 53;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre1Txt);
            this.Controls.Add(this.kAd1Txt);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnGiris);
            this.Name = "girisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.girisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifre1Txt;
        private System.Windows.Forms.TextBox kAd1Txt;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGiris;
    }
}

