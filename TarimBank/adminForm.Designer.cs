
namespace TarimBank
{
    partial class adminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bakiyeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBkyOnay = new System.Windows.Forms.Button();
            this.bkyOnyTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUrnOnay = new System.Windows.Forms.Button();
            this.urnOnyTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bakiyeListView);
            this.groupBox1.Controls.Add(this.btnBkyOnay);
            this.groupBox1.Controls.Add(this.bkyOnyTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(596, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAKİYE YÜKLEME TALEPLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Talep Numarası :";
            // 
            // bakiyeListView
            // 
            this.bakiyeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.bakiyeListView.HideSelection = false;
            this.bakiyeListView.Location = new System.Drawing.Point(6, 22);
            this.bakiyeListView.Name = "bakiyeListView";
            this.bakiyeListView.Size = new System.Drawing.Size(542, 183);
            this.bakiyeListView.TabIndex = 0;
            this.bakiyeListView.UseCompatibleStateImageBehavior = false;
            this.bakiyeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Talep Numarası";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kullanıcı Adı";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yüklenecek Bakiye";
            this.columnHeader5.Width = 132;
            // 
            // btnBkyOnay
            // 
            this.btnBkyOnay.Location = new System.Drawing.Point(286, 212);
            this.btnBkyOnay.Name = "btnBkyOnay";
            this.btnBkyOnay.Size = new System.Drawing.Size(91, 32);
            this.btnBkyOnay.TabIndex = 4;
            this.btnBkyOnay.Text = "Onayla";
            this.btnBkyOnay.UseVisualStyleBackColor = true;
            this.btnBkyOnay.Click += new System.EventHandler(this.btnBkyOnay_Click);
            // 
            // bkyOnyTxt
            // 
            this.bkyOnyTxt.Location = new System.Drawing.Point(169, 217);
            this.bkyOnyTxt.Name = "bkyOnyTxt";
            this.bkyOnyTxt.Size = new System.Drawing.Size(111, 23);
            this.bkyOnyTxt.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUrnOnay);
            this.groupBox2.Controls.Add(this.urnOnyTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.urunListView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN EKLEME TALEPLERİ";
            // 
            // btnUrnOnay
            // 
            this.btnUrnOnay.Location = new System.Drawing.Point(287, 212);
            this.btnUrnOnay.Name = "btnUrnOnay";
            this.btnUrnOnay.Size = new System.Drawing.Size(91, 32);
            this.btnUrnOnay.TabIndex = 3;
            this.btnUrnOnay.Text = "Onayla";
            this.btnUrnOnay.UseVisualStyleBackColor = true;
            this.btnUrnOnay.Click += new System.EventHandler(this.btnUrnOnay_Click);
            // 
            // urnOnyTxt
            // 
            this.urnOnyTxt.Location = new System.Drawing.Point(170, 216);
            this.urnOnyTxt.Name = "urnOnyTxt";
            this.urnOnyTxt.Size = new System.Drawing.Size(111, 23);
            this.urnOnyTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Talep Numarası :";
            // 
            // urunListView
            // 
            this.urunListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.urunListView.HideSelection = false;
            this.urunListView.Location = new System.Drawing.Point(6, 22);
            this.urunListView.Name = "urunListView";
            this.urunListView.Size = new System.Drawing.Size(542, 183);
            this.urunListView.TabIndex = 0;
            this.urunListView.UseCompatibleStateImageBehavior = false;
            this.urunListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Talep Numarası";
            this.columnHeader7.Width = 122;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kullanıcı Adı";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün Adı";
            this.columnHeader9.Width = 73;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ürün Miktarı";
            this.columnHeader10.Width = 84;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView urunListView;
        private System.Windows.Forms.ListView bakiyeListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnUrnOnay;
        private System.Windows.Forms.TextBox urnOnyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBkyOnay;
        private System.Windows.Forms.TextBox bkyOnyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}