namespace NTierArchitecture.UI.Forms
{
    partial class Frm_Order
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
            btnSaveOrder = new Button();
            btnNewOrder = new Button();
            groupBox4 = new GroupBox();
            dgwOrderDetails = new DataGridView();
            lblTotal = new Label();
            lstOrders = new ListBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            lblBasketTotal = new Label();
            lblBasketCount = new Label();
            lblCompanyName = new Label();
            lstBasket = new ListBox();
            label2 = new Label();
            txtPrice = new TextBox();
            btnBasket = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            nmrQuantity = new NumericUpDown();
            txtSearch = new TextBox();
            lstProductList = new ListBox();
            label1 = new Label();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetails).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = SystemColors.MenuHighlight;
            btnSaveOrder.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSaveOrder.ForeColor = SystemColors.ButtonFace;
            btnSaveOrder.Location = new Point(1125, 356);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(319, 98);
            btnSaveOrder.TabIndex = 7;
            btnSaveOrder.Text = "SİPARİŞ KAYDET";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.BackColor = SystemColors.MenuHighlight;
            btnNewOrder.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNewOrder.ForeColor = SystemColors.ButtonFace;
            btnNewOrder.Location = new Point(728, 356);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(393, 98);
            btnNewOrder.TabIndex = 8;
            btnNewOrder.Text = "YENİ SİPARİŞ";
            btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Info;
            groupBox4.Controls.Add(dgwOrderDetails);
            groupBox4.Location = new Point(728, 460);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(712, 300);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sipariş Detay Raporu";
            // 
            // dgwOrderDetails
            // 
            dgwOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderDetails.Location = new Point(16, 52);
            dgwOrderDetails.Name = "dgwOrderDetails";
            dgwOrderDetails.Size = new Size(668, 222);
            dgwOrderDetails.TabIndex = 0;
            dgwOrderDetails.CellContentClick += dgwOrderDetails_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(19, 253);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(495, 37);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Fatura Toplam Tutarı: 12.000 + %20 KDV";
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 37;
            lstOrders.Location = new Point(19, 52);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(679, 189);
            lstOrders.TabIndex = 2;
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(lstOrders);
            groupBox3.Location = new Point(10, 460);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(712, 312);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sipariş Bilgisi";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(lblBasketTotal);
            groupBox2.Controls.Add(lblBasketCount);
            groupBox2.Controls.Add(lblCompanyName);
            groupBox2.Controls.Add(lstBasket);
            groupBox2.Location = new Point(728, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(716, 338);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Sepeti";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(561, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblBasketTotal
            // 
            lblBasketTotal.AutoSize = true;
            lblBasketTotal.Location = new Point(6, 286);
            lblBasketTotal.Name = "lblBasketTotal";
            lblBasketTotal.Size = new Size(198, 37);
            lblBasketTotal.TabIndex = 5;
            lblBasketTotal.Text = "Sepet Toplamı: ";
            // 
            // lblBasketCount
            // 
            lblBasketCount.AutoSize = true;
            lblBasketCount.Location = new Point(346, 286);
            lblBasketCount.Name = "lblBasketCount";
            lblBasketCount.Size = new Size(165, 37);
            lblBasketCount.TabIndex = 5;
            lblBasketCount.Text = "Ürün Adedi: ";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(458, 39);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(226, 37);
            lblCompanyName.TabIndex = 5;
            lblCompanyName.Text = "Müşteri Firma Adı";
            // 
            // lstBasket
            // 
            lstBasket.FormattingEnabled = true;
            lstBasket.ItemHeight = 37;
            lstBasket.Location = new Point(6, 88);
            lstBasket.Name = "lstBasket";
            lstBasket.Size = new Size(678, 189);
            lstBasket.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 338);
            label2.Name = "label2";
            label2.Size = new Size(73, 37);
            label2.TabIndex = 6;
            label2.Text = "Adet";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(404, 337);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(294, 43);
            txtPrice.TabIndex = 8;
            // 
            // btnBasket
            // 
            btnBasket.Location = new Point(20, 386);
            btnBasket.Name = "btnBasket";
            btnBasket.Size = new Size(679, 43);
            btnBasket.TabIndex = 3;
            btnBasket.Text = "Sepete Ekle";
            btnBasket.UseVisualStyleBackColor = true;
            btnBasket.Click += btnBasket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 338);
            label3.Name = "label3";
            label3.Size = new Size(141, 37);
            label3.TabIndex = 5;
            label3.Text = "Birim Fiyat";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnBasket);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(nmrQuantity);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(lstProductList);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(712, 442);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Listesi";
            // 
            // nmrQuantity
            // 
            nmrQuantity.Location = new Point(101, 337);
            nmrQuantity.Margin = new Padding(6, 7, 6, 7);
            nmrQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrQuantity.Name = "nmrQuantity";
            nmrQuantity.Size = new Size(122, 43);
            nmrQuantity.TabIndex = 7;
            nmrQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(678, 43);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 37;
            lstProductList.Location = new Point(20, 137);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(678, 189);
            lstProductList.TabIndex = 2;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(475, 37);
            label1.TabIndex = 0;
            label1.Text = "Lütfen aramak istediğiniz ürünü giriniz:";
            // 
            // Frm_Order
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 760);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnNewOrder);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Order";
            Text = "Frm_Order";
            Load += Frm_Order_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetails).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaveOrder;
        private Button btnNewOrder;
        private GroupBox groupBox4;
        private Label lblTotal;
        private ListBox lstOrders;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Label lblBasketTotal;
        private Label lblBasketCount;
        private Label lblCompanyName;
        private ListBox lstBasket;
        private Label label2;
        private TextBox txtPrice;
        private Button btnBasket;
        private Label label3;
        private GroupBox groupBox1;
        private NumericUpDown nmrQuantity;
        private TextBox txtSearch;
        private ListBox lstProductList;
        private Label label1;
        private DataGridView dgwOrderDetails;
    }
}