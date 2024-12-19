namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Supplier
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
            grpProductInfo = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label6 = new Label();
            chkActive = new CheckBox();
            txtPhone = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            label1 = new Label();
            txtCountry = new TextBox();
            label5 = new Label();
            txtContact = new TextBox();
            label4 = new Label();
            txtSName = new TextBox();
            label3 = new Label();
            lstListe = new ListBox();
            grpProductInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grpProductInfo
            // 
            grpProductInfo.Controls.Add(btnUpdate);
            grpProductInfo.Controls.Add(btnDelete);
            grpProductInfo.Controls.Add(btnSave);
            grpProductInfo.Controls.Add(label6);
            grpProductInfo.Controls.Add(chkActive);
            grpProductInfo.Controls.Add(txtPhone);
            grpProductInfo.Controls.Add(label2);
            grpProductInfo.Controls.Add(txtCity);
            grpProductInfo.Controls.Add(label1);
            grpProductInfo.Controls.Add(txtCountry);
            grpProductInfo.Controls.Add(label5);
            grpProductInfo.Controls.Add(txtContact);
            grpProductInfo.Controls.Add(label4);
            grpProductInfo.Controls.Add(txtSName);
            grpProductInfo.Controls.Add(label3);
            grpProductInfo.Location = new Point(12, 11);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(851, 404);
            grpProductInfo.TabIndex = 3;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Tedarikçi Bilgileri";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(461, 356);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(461, 297);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 42);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(656, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 101);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 297);
            label6.Name = "label6";
            label6.Size = new Size(98, 37);
            label6.TabIndex = 5;
            label6.Text = "Durum";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(310, 297);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(90, 41);
            chkActive.TabIndex = 3;
            chkActive.Text = "Aktif";
            chkActive.UseVisualStyleBackColor = true;
            chkActive.CheckedChanged += chkActive_CheckedChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(310, 238);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(535, 43);
            txtPhone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 238);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 1;
            label2.Text = "Telefon";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(310, 189);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(535, 43);
            txtCity.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 189);
            label1.Name = "label1";
            label1.Size = new Size(76, 37);
            label1.TabIndex = 1;
            label1.Text = "Şehir";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(310, 140);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(535, 43);
            txtCountry.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 140);
            label5.Name = "label5";
            label5.Size = new Size(70, 37);
            label5.TabIndex = 1;
            label5.Text = "Ülke";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(310, 91);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(535, 43);
            txtContact.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 91);
            label4.Name = "label4";
            label4.Size = new Size(116, 37);
            label4.TabIndex = 1;
            label4.Text = "İlgili Kişi";
            // 
            // txtSName
            // 
            txtSName.Location = new Point(310, 42);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(535, 43);
            txtSName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 42);
            label3.Name = "label3";
            label3.Size = new Size(167, 37);
            label3.TabIndex = 1;
            label3.Text = "Tedarikçi Adı";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(12, 421);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(845, 189);
            lstListe.TabIndex = 4;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // Frm_Supplier
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(871, 621);
            Controls.Add(grpProductInfo);
            Controls.Add(lstListe);
            Font = new Font("Segoe UI", 20F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Supplier";
            Text = "Frm_Supplier";
            Load += Frm_Supplier_Load;
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductInfo;
        private Button btnSave;
        private Label label6;
        private CheckBox chkActive;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtCity;
        private Label label1;
        private TextBox txtCountry;
        private Label label5;
        private TextBox txtContact;
        private Label label4;
        private TextBox txtSName;
        private Label label3;
        private ListBox lstListe;
        private Button btnDelete;
        private Button btnUpdate;
    }
}