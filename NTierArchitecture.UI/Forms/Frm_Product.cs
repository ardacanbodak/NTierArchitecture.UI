using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
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
    public partial class Frm_Product : Form
    {
        private readonly ProductService _productService;
        ApplicationDbContext context = new ApplicationDbContext();
        private ProductRepository pRepo;
        ProductService pService;
        CategoryService cService;
        CategoryRepository cRepo;
        SupplierService sService;
        SupplierRepository sRepo;
        public Frm_Product(ProductService productService)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            pRepo = new ProductRepository(context);
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            pService = _productService;
            cRepo = new CategoryRepository(context);
            cService = new CategoryService(cRepo);
            sRepo = new SupplierRepository(context);
            sService = new SupplierService(sRepo);
            LoadCategories();
            LoadSuppliers();
        }


        private void LoadCategories()
        {
            try
            {
                var categories = _productService.GetAllCategory(cService);
                if (categories != null)
                {
                    cmdCategories.DataSource = categories.ToList();
                    cmdCategories.DisplayMember = "CategoryName";
                    cmdCategories.ValueMember = "ID";
                }
                else
                {
                    MessageBox.Show("Kategori verileri alınamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void LoadSuppliers()
        {
            try
            {
                var supliers = _productService.GetAllSupplier(sService);
                if (supliers != null)
                {
                    cmdSuppliers.DataSource = supliers.ToList();
                    cmdSuppliers.DisplayMember = "CompanyName";
                    cmdSuppliers.ValueMember = "ID";
                }
                else
                {
                    MessageBox.Show("Tedarik verileri alınamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedaikçiler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pService.ProductNameExists(txtPName.Text))
                {
                    MessageBox.Show("Aynı isimde bir ürün zaten mevcut.");
                    return;
                }
                Product p = new Product();
                p.ProductName = txtPName.Text;
                // p.UnitPrice = double.Parse(txtPrice.Text);

                p.UnitPrice = double.TryParse(txtPrice.Text, out double price) ? price : 0;
                p.UnitsInStock = int.TryParse(txtStock.Text, out int stock) ? stock : 0;

                /* if (int.TryParse(txtStock.Text, out int unitsInStock))

                 {
                     p.UnitsInStock = unitsInStock;
                 }*/

                if (Guid.TryParse(cmdCategories.SelectedValue.ToString(), out Guid categoryID))
                {
                    p.CategoryID = categoryID;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir kategori seçin.");
                    return;
                }

                if (Guid.TryParse(cmdSuppliers.SelectedValue.ToString(), out Guid supplierID))
                {
                    p.SupplierID = supplierID;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir tedarikçi seçin.");
                    return;
                }

                p.IsActive = chkActive.Checked;
                p.Discontinued = chkDisc.Checked;

                _productService.Add(p);

                MessageBox.Show("Ürün başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetAllProducts();


        }
        private void GetAllProducts()
        {
            lstList.DataSource = null;
            lstList.DisplayMember = "ProductName" + " - " + "UnitPrice" + " - " + "UnitsInStock";
            lstList.ValueMember = "ID";
            lstList.DataSource = pRepo.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstList.SelectedIndex != -1)
                {
                    var selectedProductId = lstList.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(selectedProductId) && Guid.TryParse(selectedProductId, out Guid productId))
                    {
                        pService.Delete(productId);
                        GetAllProducts();
                        MessageBox.Show("Ürün başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir ürün seçin.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir ürün seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            chkActive.Checked = true;
            chkDisc.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region
            /*if (lstList.SelectedIndex != -1)
            {
                try
                {
                    var selectedProductId = Guid.Parse(lstList.SelectedValue.ToString());
                    var productToUpdate = _productService.GetByID(selectedProductId);

                    productToUpdate.ProductName = txtPName.Text;
                    productToUpdate.UnitPrice = double.TryParse(txtPrice.Text, out double price) ? price : 0;
                    productToUpdate.UnitsInStock = int.TryParse(txtStock.Text, out int stock) ? stock : 0;
                    //productToUpdate.UnitPrice = double.Parse(txtPrice.Text);
                    /*if (int.TryParse(txtStock.Text, out int unitsInStock))
                    {
                        productToUpdate.UnitsInStock = unitsInStock;
                    }*/
            /* if (Guid.TryParse(cmdCategories.SelectedValue.ToString(), out Guid categoryID))
             {
                 productToUpdate.CategoryID = categoryID;
             }
             if (Guid.TryParse(cmdSuppliers.SelectedValue.ToString(), out Guid supplierID))
             {
                 productToUpdate.SupplierID = supplierID;
             }
             productToUpdate.IsActive = chkActive.Checked;
             productToUpdate.Discontinued = chkDisc.Checked;

             _productService.Update(productToUpdate);

             MessageBox.Show("Güncelleme Başarılı.");
             GetAllProducts();
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message);
         }

     }*/
            #endregion

            if (lstList.SelectedIndex != -1)
            {
                try
                {
                    var selectedProductId = lstList.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(selectedProductId) && Guid.TryParse(selectedProductId, out Guid productId))
                    {
                        var productToUpdate = _productService.GetByID(productId);
                        if (productToUpdate != null)
                        {
                            productToUpdate.ProductName = txtPName.Text;
                            productToUpdate.UnitPrice = double.TryParse(txtPrice.Text, out double price) ? price : 0;
                            productToUpdate.UnitsInStock = int.TryParse(txtStock.Text, out int stock) ? stock : 0;

                            if (Guid.TryParse(cmdCategories.SelectedValue?.ToString(), out Guid categoryID))
                            {
                                productToUpdate.CategoryID = categoryID;
                            }
                            else
                            {
                                MessageBox.Show("Lütfen geçerli bir kategori seçin.");
                                return;
                            }

                            if (Guid.TryParse(cmdSuppliers.SelectedValue?.ToString(), out Guid supplierID))
                            {
                                productToUpdate.SupplierID = supplierID;
                            }
                            else
                            {
                                MessageBox.Show("Lütfen geçerli bir tedarikçi seçin.");
                                return;
                            }

                            _productService.Update(productToUpdate);
                            MessageBox.Show("Güncelleme Başarılı.");
                            GetAllProducts();
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.");
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkActive.Text = "Aktif";
            }
            else
            {
                chkActive.Text = "Pasif";
            }
            Product p;
        }

        private void chkDisc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisc.Checked)
            {
                chkDisc.Text = "Evet";
            }
            else
            {
                chkDisc.Text = "Hayır";
            }
            Product p;
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstList.SelectedIndex != -1)
                {
                    var selectedProductId = lstList.SelectedValue?.ToString();
                    if (!string.IsNullOrEmpty(selectedProductId) && Guid.TryParse(selectedProductId, out Guid productId))
                    {
                        var product = _productService.GetByID(productId);
                        if (product != null)
                        {
                            txtPName.Text = product.ProductName;
                            txtPrice.Text = product.UnitPrice.ToString();
                            txtStock.Text = product.UnitsInStock.ToString();
                            cmdCategories.SelectedValue = product.CategoryID;
                            cmdSuppliers.SelectedValue = product.SupplierID;
                            chkDisc.Checked = product.Discontinued;
                            chkActive.Checked = product.IsActive;
                        }
                        else
                        {
                            MessageBox.Show("Seçilen ürün bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void cmdSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
