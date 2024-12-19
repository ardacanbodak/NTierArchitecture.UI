namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Customer
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
            lstList = new ListBox();
            groupBox1 = new GroupBox();
            lblAd = new Label();
            txtNo = new TextBox();
            txtSehir = new TextBox();
            lblUlke = new Label();
            txtUlke = new TextBox();
            lblSehir = new Label();
            lblNo = new Label();
            txtAd = new TextBox();
            chkAktifPasif = new CheckBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(387, 15);
            lstList.Name = "lstList";
            lstList.Size = new Size(401, 334);
            lstList.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAktifPasif);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtSehir);
            groupBox1.Controls.Add(lblUlke);
            groupBox1.Controls.Add(txtUlke);
            groupBox1.Controls.Add(lblSehir);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 223);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlem Paneli";
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
            // txtNo
            // 
            txtNo.Location = new Point(113, 103);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(214, 23);
            txtNo.TabIndex = 9;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(113, 74);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(214, 23);
            txtSehir.TabIndex = 8;
            // 
            // lblUlke
            // 
            lblUlke.AutoSize = true;
            lblUlke.Location = new Point(6, 48);
            lblUlke.Name = "lblUlke";
            lblUlke.Size = new Size(36, 15);
            lblUlke.TabIndex = 2;
            lblUlke.Text = "Ülke :";
            // 
            // txtUlke
            // 
            txtUlke.Location = new Point(113, 45);
            txtUlke.Name = "txtUlke";
            txtUlke.Size = new Size(214, 23);
            txtUlke.TabIndex = 7;
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(6, 77);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(39, 15);
            lblSehir.TabIndex = 3;
            lblSehir.Text = "Şehir :";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(6, 106);
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
            // chkAktifPasif
            // 
            chkAktifPasif.AutoSize = true;
            chkAktifPasif.Location = new Point(80, 178);
            chkAktifPasif.Name = "chkAktifPasif";
            chkAktifPasif.Size = new Size(81, 19);
            chkAktifPasif.TabIndex = 17;
            chkAktifPasif.Text = "Aktif/Pasif";
            chkAktifPasif.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(177, 178);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(93, 40);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(177, 132);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(93, 40);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(276, 131);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 87);
            btnKaydet.TabIndex = 14;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Frm_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstList);
            Controls.Add(groupBox1);
            Name = "Frm_Customer";
            Text = "Frm_Customer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstList;
        private GroupBox groupBox1;
        private Label lblAd;
        private TextBox txtNo;
        private TextBox txtSehir;
        private Label lblUlke;
        private TextBox txtUlke;
        private Label lblSehir;
        private Label lblNo;
        private TextBox txtAd;
        private CheckBox chkAktifPasif;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
    }
}