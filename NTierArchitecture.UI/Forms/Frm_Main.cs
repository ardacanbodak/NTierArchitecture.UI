using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void FormKontrol(Form fCat)
        {
            fCat.MdiParent = this;
            if (FormUtils.IsFormOpen(fCat))
            {
                MessageBox.Show("Form zaten açık");
            }
            else
            {
                fCat.Show();
            }
        }

        private void kategoriTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category fCat = new Frm_Category();
            FormKontrol(fCat);
        }

        private void ürünTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            CategoryRepository categoryRepository = new CategoryRepository(context);
            CategoryService categoryService = new CategoryService(categoryRepository);
            SupplierRepository supplierRepository = new SupplierRepository(context);
            SupplierService supplierService = new SupplierService(supplierRepository);

            ProductRepository productRepository = new ProductRepository(context);
            ProductService productService = new ProductService(productRepository);
            Frm_Product fProduct = new Frm_Product(productService);
            FormKontrol(fProduct);
        }

        private void tedarikçiTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Supplier fSup = new Frm_Supplier();
            FormKontrol(fSup);
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Order fOrder = new Frm_Order();
            FormKontrol(fOrder);
        }

        private void çalışanTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Employee fEmployee = new Frm_Employee();
            FormKontrol(fEmployee);
        }

        private void müşteriTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Frm_Customer fCustomer = new Frm_Customer();
            FormKontrol(fCustomer);
        }
    }
}
