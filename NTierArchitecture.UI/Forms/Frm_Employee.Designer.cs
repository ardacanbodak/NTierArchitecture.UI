namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Employee
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblUlke = new Label();
            lblSehir = new Label();
            lblNo = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtUlke = new TextBox();
            txtSehir = new TextBox();
            txtNo = new TextBox();
            groupBox1 = new GroupBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            lstList = new ListBox();
            chkAktifPasif = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(6, 19);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(6, 48);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(45, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblUlke
            // 
            lblUlke.AutoSize = true;
            lblUlke.Location = new Point(6, 77);
            lblUlke.Name = "lblUlke";
            lblUlke.Size = new Size(36, 15);
            lblUlke.TabIndex = 2;
            lblUlke.Text = "Ülke :";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(6, 106);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(39, 15);
            lblSehir.TabIndex = 3;
            lblSehir.Text = "Şehir :";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(6, 135);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(51, 15);
            lblNo.TabIndex = 4;
            lblNo.Text = "Telefon :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(113, 16);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(214, 23);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(113, 45);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(214, 23);
            txtSoyad.TabIndex = 6;
            // 
            // txtUlke
            // 
            txtUlke.Location = new Point(113, 74);
            txtUlke.Name = "txtUlke";
            txtUlke.Size = new Size(214, 23);
            txtUlke.TabIndex = 7;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(113, 103);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(214, 23);
            txtSehir.TabIndex = 8;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(113, 132);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(214, 23);
            txtNo.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAktifPasif);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(txtSehir);
            groupBox1.Controls.Add(lblUlke);
            groupBox1.Controls.Add(txtUlke);
            groupBox1.Controls.Add(lblSehir);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 255);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çalışan İşlem Paneli";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(177, 208);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(93, 40);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(177, 162);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(93, 40);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(276, 161);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 87);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(387, 15);
            lstList.Name = "lstList";
            lstList.Size = new Size(401, 334);
            lstList.TabIndex = 11;
            // 
            // chkAktifPasif
            // 
            chkAktifPasif.AutoSize = true;
            chkAktifPasif.Location = new Point(80, 208);
            chkAktifPasif.Name = "chkAktifPasif";
            chkAktifPasif.Size = new Size(81, 19);
            chkAktifPasif.TabIndex = 13;
            chkAktifPasif.Text = "Aktif/Pasif";
            chkAktifPasif.UseVisualStyleBackColor = true;
            // 
            // Frm_Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lstList);
            Controls.Add(groupBox1);
            Name = "Frm_Employee";
            Text = "Frm_Employee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblUlke;
        private Label lblSehir;
        private Label lblNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtUlke;
        private TextBox txtSehir;
        private TextBox txtNo;
        private GroupBox groupBox1;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private ListBox lstList;
        private CheckBox chkAktifPasif;
    }
}