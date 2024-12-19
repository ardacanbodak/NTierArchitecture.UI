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
    public partial class Frm_Supplier : Form
    {
        public Frm_Supplier()
        {
            InitializeComponent();
            sRepo = new SupplierRepository(context);
            sService = new SupplierService(sRepo);
            //lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            //txtSName.ReadOnly = true;
        }
        ApplicationDbContext context = new ApplicationDbContext();
        private SupplierRepository sRepo;
        SupplierService sService;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sService.CompanyNameExists(txtSName.Text))
                {
                    MessageBox.Show("Aynı isimde bir tedarikçi zaten mevcut.");
                    return;
                }

                Supplier s = new Supplier();
                s.CompanyName = txtSName.Text;
                s.ContactTitle = txtContact.Text;
                s.Country = txtCountry.Text;
                s.City = txtCity.Text;
                s.Phone = txtPhone.Text;
                s.IsActive = chkActive.Checked;

                sService.Add(s);
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetAllSupplier();

        }
        private void GetAllSupplier()
        {
            lstListe.DataSource = null;
            lstListe.DisplayMember = "CompanyName" + "ContactTitle" + "Country" + "City" + "Phone";
            lstListe.ValueMember = "ID";
            lstListe.DataSource = sService.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedIndex != -1)
                {
                    sService.Delete(Guid.Parse(lstListe.SelectedValue.ToString()));
                    GetAllSupplier();
                    MessageBox.Show("Tedarikçi başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir tedarikçi seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message);
            }
        }

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            chkActive.Checked = true;
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
            Supplier s;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                try
                {
                    var selectedSupplierId = Guid.Parse(lstListe.SelectedValue.ToString());
                    if (sService.CompanyNameExists(txtSName.Text, selectedSupplierId))
                    {
                        MessageBox.Show("Aynı isimde bir Tedarikçi zaten mevcut.");
                        return;
                    }
                    var supplierToUpdate = sService.GetByID(selectedSupplierId);

                    supplierToUpdate.CompanyName = txtSName.Text;
                    supplierToUpdate.ContactTitle = txtContact.Text;
                    supplierToUpdate.Country = txtCountry.Text;
                    supplierToUpdate.City = txtCity.Text;
                    supplierToUpdate.Phone = txtPhone.Text;
                    supplierToUpdate.IsActive = chkActive.Checked;

                    sService.Update(supplierToUpdate);
                    MessageBox.Show("Güncelleme Başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                GetAllSupplier();
            }
            else
            {
                MessageBox.Show("LÖütfen güncellemek istediğiniz tedarikçiyi seçiniz");
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                var selectedSupplierId = Guid.Parse(lstListe.SelectedValue.ToString());
                var selectedSupplier = sService.GetByID(selectedSupplierId); 
                if (selectedSupplier != null)
                {
                    txtSName.Text = selectedSupplier.CompanyName;
                    txtContact.Text = selectedSupplier.ContactTitle;
                    txtCountry.Text = selectedSupplier.Country;
                    txtCity.Text = selectedSupplier.City;
                    txtPhone.Text = selectedSupplier.Phone;
                    chkActive.Checked = selectedSupplier.IsActive;
                }
            }
        }
    }
}
