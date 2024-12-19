namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Category
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
            chkAktifPasif = new CheckBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            lstListe = new ListBox();
            txtAciklama = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // chkAktifPasif
            // 
            chkAktifPasif.AutoSize = true;
            chkAktifPasif.Checked = true;
            chkAktifPasif.CheckState = CheckState.Checked;
            chkAktifPasif.Location = new Point(315, 204);
            chkAktifPasif.Name = "chkAktifPasif";
            chkAktifPasif.Size = new Size(90, 41);
            chkAktifPasif.TabIndex = 14;
            chkAktifPasif.TabStop = false;
            chkAktifPasif.Text = "Aktif";
            chkAktifPasif.UseVisualStyleBackColor = true;
            chkAktifPasif.CheckedChanged += chkAktifPasif_CheckedChanged;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(424, 473);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 68);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(571, 473);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(141, 68);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(1, 278);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(711, 189);
            lstListe.TabIndex = 11;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(315, 67);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(397, 121);
            txtAciklama.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 7;
            label2.Text = "Açıklama";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(315, 18);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(397, 43);
            txtAd.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 8;
            label1.Text = "Kategori Adı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(498, 204);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(214, 68);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Frm_Category
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(731, 553);
            Controls.Add(chkAktifPasif);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(lstListe);
            Controls.Add(txtAciklama);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Category";
            Text = "Frm_Category";
            Load += Frm_Category_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAktifPasif;
        private Button btnGuncelle;
        private Button btnSil;
        private ListBox lstListe;
        private TextBox txtAciklama;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private Button btnKaydet;
    }
}