namespace Db_Proje
{
    partial class FrmDatabase
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
            this.TxtSunucuAdi = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbWindowsAuth = new System.Windows.Forms.CheckBox();
            this.Veritabanlari = new System.Windows.Forms.ListBox();
            this.TxtSeciliVeritabani = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtProcedure = new System.Windows.Forms.RichTextBox();
            this.BtnVeritabaninaAktar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProsedurAdi = new System.Windows.Forms.TextBox();
            this.BtnEnabled = new System.Windows.Forms.Button();
            this.CmbVeritabani = new System.Windows.Forms.ComboBox();
            this.BtnSorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSunucuAdi
            // 
            this.TxtSunucuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSunucuAdi.Location = new System.Drawing.Point(111, 36);
            this.TxtSunucuAdi.Name = "TxtSunucuAdi";
            this.TxtSunucuAdi.Size = new System.Drawing.Size(242, 26);
            this.TxtSunucuAdi.TabIndex = 1;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(111, 68);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(242, 26);
            this.TxtKullaniciAdi.TabIndex = 2;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(111, 100);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(242, 26);
            this.TxtSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunucu Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Veritabanı Adı:";
            // 
            // CmbWindowsAuth
            // 
            this.CmbWindowsAuth.AutoSize = true;
            this.CmbWindowsAuth.Location = new System.Drawing.Point(111, 141);
            this.CmbWindowsAuth.Name = "CmbWindowsAuth";
            this.CmbWindowsAuth.Size = new System.Drawing.Size(141, 17);
            this.CmbWindowsAuth.TabIndex = 4;
            this.CmbWindowsAuth.Text = "Windows Authentication";
            this.CmbWindowsAuth.UseVisualStyleBackColor = true;
            this.CmbWindowsAuth.CheckedChanged += new System.EventHandler(this.CmbWindowsAuth_CheckedChanged);
            // 
            // Veritabanlari
            // 
            this.Veritabanlari.FormattingEnabled = true;
            this.Veritabanlari.Location = new System.Drawing.Point(382, 39);
            this.Veritabanlari.Name = "Veritabanlari";
            this.Veritabanlari.Size = new System.Drawing.Size(189, 160);
            this.Veritabanlari.TabIndex = 3;
            this.Veritabanlari.SelectedIndexChanged += new System.EventHandler(this.Veritabanlari_SelectedIndexChanged);
            // 
            // TxtSeciliVeritabani
            // 
            this.TxtSeciliVeritabani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeciliVeritabani.Location = new System.Drawing.Point(413, 219);
            this.TxtSeciliVeritabani.Name = "TxtSeciliVeritabani";
            this.TxtSeciliVeritabani.ReadOnly = true;
            this.TxtSeciliVeritabani.Size = new System.Drawing.Size(158, 26);
            this.TxtSeciliVeritabani.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(283, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seçilen Veritabanı:";
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnInsert.ForeColor = System.Drawing.Color.White;
            this.BtnInsert.Location = new System.Drawing.Point(172, 294);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(141, 38);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "Ekle";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(319, 294);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(141, 38);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(466, 294);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 38);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtProcedure
            // 
            this.TxtProcedure.Location = new System.Drawing.Point(613, 36);
            this.TxtProcedure.Name = "TxtProcedure";
            this.TxtProcedure.ReadOnly = true;
            this.TxtProcedure.Size = new System.Drawing.Size(333, 296);
            this.TxtProcedure.TabIndex = 6;
            this.TxtProcedure.Text = "";
            // 
            // BtnVeritabaninaAktar
            // 
            this.BtnVeritabaninaAktar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnVeritabaninaAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVeritabaninaAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVeritabaninaAktar.ForeColor = System.Drawing.Color.White;
            this.BtnVeritabaninaAktar.Location = new System.Drawing.Point(286, 358);
            this.BtnVeritabaninaAktar.Name = "BtnVeritabaninaAktar";
            this.BtnVeritabaninaAktar.Size = new System.Drawing.Size(141, 58);
            this.BtnVeritabaninaAktar.TabIndex = 5;
            this.BtnVeritabaninaAktar.Text = "Veritabanına Aktar";
            this.BtnVeritabaninaAktar.UseVisualStyleBackColor = false;
            this.BtnVeritabaninaAktar.Click += new System.EventHandler(this.BtnVeritabaninaAktar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(462, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Store Procedure Adı:";
            // 
            // TxtProsedurAdi
            // 
            this.TxtProsedurAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtProsedurAdi.Location = new System.Drawing.Point(613, 374);
            this.TxtProsedurAdi.Name = "TxtProsedurAdi";
            this.TxtProsedurAdi.ReadOnly = true;
            this.TxtProsedurAdi.Size = new System.Drawing.Size(333, 26);
            this.TxtProsedurAdi.TabIndex = 7;
            // 
            // BtnEnabled
            // 
            this.BtnEnabled.Location = new System.Drawing.Point(931, 15);
            this.BtnEnabled.Name = "BtnEnabled";
            this.BtnEnabled.Size = new System.Drawing.Size(15, 15);
            this.BtnEnabled.TabIndex = 9;
            this.BtnEnabled.Text = "button1";
            this.BtnEnabled.UseVisualStyleBackColor = true;
            this.BtnEnabled.Click += new System.EventHandler(this.BtnEnabled_Click);
            // 
            // CmbVeritabani
            // 
            this.CmbVeritabani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVeritabani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbVeritabani.FormattingEnabled = true;
            this.CmbVeritabani.Location = new System.Drawing.Point(111, 173);
            this.CmbVeritabani.Name = "CmbVeritabani";
            this.CmbVeritabani.Size = new System.Drawing.Size(242, 28);
            this.CmbVeritabani.TabIndex = 5;
            this.CmbVeritabani.SelectedIndexChanged += new System.EventHandler(this.CmbVeritabani_SelectedIndexChanged);
            // 
            // BtnSorgula
            // 
            this.BtnSorgula.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSorgula.ForeColor = System.Drawing.Color.White;
            this.BtnSorgula.Location = new System.Drawing.Point(12, 294);
            this.BtnSorgula.Name = "BtnSorgula";
            this.BtnSorgula.Size = new System.Drawing.Size(151, 38);
            this.BtnSorgula.TabIndex = 11;
            this.BtnSorgula.Text = "Sorgula";
            this.BtnSorgula.UseVisualStyleBackColor = false;
            this.BtnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(964, 435);
            this.Controls.Add(this.BtnSorgula);
            this.Controls.Add(this.CmbVeritabani);
            this.Controls.Add(this.BtnEnabled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtProsedurAdi);
            this.Controls.Add(this.TxtProcedure);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnVeritabaninaAktar);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.Veritabanlari);
            this.Controls.Add(this.CmbWindowsAuth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSeciliVeritabani);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.TxtSunucuAdi);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "FrmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSunucuAdi;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CmbWindowsAuth;
        private System.Windows.Forms.ListBox Veritabanlari;
        private System.Windows.Forms.TextBox TxtSeciliVeritabani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.RichTextBox TxtProcedure;
        private System.Windows.Forms.Button BtnVeritabaninaAktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProsedurAdi;
        private System.Windows.Forms.Button BtnEnabled;
        private System.Windows.Forms.ComboBox CmbVeritabani;
        private System.Windows.Forms.Button BtnSorgula;
    }
}

