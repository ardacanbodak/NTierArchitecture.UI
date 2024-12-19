namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Main
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
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            tANIMLAMALARToolStripMenuItem = new ToolStripMenuItem();
            kategoriTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            ürünTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            tedarikçiTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            iŞLEMLERToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            çalışanTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            müşteriTanımlarıToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(141, 526);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.AutoSize = false;
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tANIMLAMALARToolStripMenuItem, iŞLEMLERToolStripMenuItem });
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(160, 22);
            mENUToolStripMenuItem.Text = "MENU#";
            // 
            // tANIMLAMALARToolStripMenuItem
            // 
            tANIMLAMALARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kategoriTanımlarıToolStripMenuItem, ürünTanımlarıToolStripMenuItem, tedarikçiTanımlarıToolStripMenuItem, çalışanTanımlarıToolStripMenuItem, müşteriTanımlarıToolStripMenuItem });
            tANIMLAMALARToolStripMenuItem.Name = "tANIMLAMALARToolStripMenuItem";
            tANIMLAMALARToolStripMenuItem.Size = new Size(180, 22);
            tANIMLAMALARToolStripMenuItem.Text = "TANIMLAMALAR";
            // 
            // kategoriTanımlarıToolStripMenuItem
            // 
            kategoriTanımlarıToolStripMenuItem.Name = "kategoriTanımlarıToolStripMenuItem";
            kategoriTanımlarıToolStripMenuItem.Size = new Size(180, 22);
            kategoriTanımlarıToolStripMenuItem.Text = "Kategori Tanımları";
            kategoriTanımlarıToolStripMenuItem.Click += kategoriTanımlarıToolStripMenuItem_Click;
            // 
            // ürünTanımlarıToolStripMenuItem
            // 
            ürünTanımlarıToolStripMenuItem.Name = "ürünTanımlarıToolStripMenuItem";
            ürünTanımlarıToolStripMenuItem.Size = new Size(180, 22);
            ürünTanımlarıToolStripMenuItem.Text = "Ürün Tanımları";
            ürünTanımlarıToolStripMenuItem.Click += ürünTanımlarıToolStripMenuItem_Click;
            // 
            // tedarikçiTanımlarıToolStripMenuItem
            // 
            tedarikçiTanımlarıToolStripMenuItem.Name = "tedarikçiTanımlarıToolStripMenuItem";
            tedarikçiTanımlarıToolStripMenuItem.Size = new Size(180, 22);
            tedarikçiTanımlarıToolStripMenuItem.Text = "Tedarikçi Tanımları";
            tedarikçiTanımlarıToolStripMenuItem.Click += tedarikçiTanımlarıToolStripMenuItem_Click;
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem });
            iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            iŞLEMLERToolStripMenuItem.Size = new Size(180, 22);
            iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(180, 22);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // çalışanTanımlarıToolStripMenuItem
            // 
            çalışanTanımlarıToolStripMenuItem.Name = "çalışanTanımlarıToolStripMenuItem";
            çalışanTanımlarıToolStripMenuItem.Size = new Size(180, 22);
            çalışanTanımlarıToolStripMenuItem.Text = "Çalışan Tanımları";
            çalışanTanımlarıToolStripMenuItem.Click += çalışanTanımlarıToolStripMenuItem_Click;
            // 
            // müşteriTanımlarıToolStripMenuItem
            // 
            müşteriTanımlarıToolStripMenuItem.Name = "müşteriTanımlarıToolStripMenuItem";
            müşteriTanımlarıToolStripMenuItem.Size = new Size(180, 22);
            müşteriTanımlarıToolStripMenuItem.Text = "Müşteri Tanımları";
            müşteriTanımlarıToolStripMenuItem.Click += müşteriTanımlarıToolStripMenuItem_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 526);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm_Main";
            Text = "Frm_Main";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem tANIMLAMALARToolStripMenuItem;
        private ToolStripMenuItem kategoriTanımlarıToolStripMenuItem;
        private ToolStripMenuItem ürünTanımlarıToolStripMenuItem;
        private ToolStripMenuItem tedarikçiTanımlarıToolStripMenuItem;
        private ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem çalışanTanımlarıToolStripMenuItem;
        private ToolStripMenuItem müşteriTanımlarıToolStripMenuItem;
    }
}