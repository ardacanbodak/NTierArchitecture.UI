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
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();
            cRepo = new CategoryRepository(context);
            cService = new CategoryService(cRepo);
            
        }
        ApplicationDbContext context = new ApplicationDbContext();
        private CategoryRepository cRepo;
        CategoryService cService;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cService.CategoryNameExists(txtAd.Text))
                {
                    MessageBox.Show("Aynı isimde bir kategori zaten mevcut.");
                    return;
                }

                Category c = new Category();
                c.CategoryName = txtAd.Text;
                c.Description = txtAciklama.Text;
                c.IsActive = chkAktifPasif.Checked;

                cService.Add(c);

                MessageBox.Show("İşlem Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetAllCategory();
        }
        private void GetAllCategory()
        {
            lstListe.DataSource = null;
            lstListe.DisplayMember = "CategoryName" + "Description";
            lstListe.ValueMember = "ID";
            lstListe.DataSource = cService.GetAll();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /*if (lstListe.SelectedIndex != -1)
             {
                 cService.Delete(Guid.Parse(lstListe.SelectedValue.ToString()));
                 GetAllCategory();
                 MessageBox.Show("Kategori başarıyla silindi.");
             }
            else
             {
                 throw new Exception("Aktif category silinemez!!");
             }*/
            try
            {
                if (lstListe.SelectedIndex != -1)
                {
                    cService.Delete(Guid.Parse(lstListe.SelectedValue.ToString()));
                    GetAllCategory();
                    MessageBox.Show("Kategori başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir kategori seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            chkAktifPasif.Checked = true;
        }

        private void chkAktifPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAktifPasif.Checked)
            {
                chkAktifPasif.Text = "Aktif";
            }
            else
            {
                chkAktifPasif.Text = "Pasif";
            }
            Category c;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                try
                {
                    var selectedCategoryId = Guid.Parse(lstListe.SelectedValue.ToString());
                    if (cService.CategoryNameExists(txtAd.Text, selectedCategoryId))
                    {
                        MessageBox.Show("Aynı isimde bir kategori zaten mevcut.");
                        return;
                    }

                    var categoryToUpdate = cService.GetByID(selectedCategoryId);

                    categoryToUpdate.CategoryName = txtAd.Text;
                    categoryToUpdate.Description = txtAciklama.Text;
                    categoryToUpdate.IsActive = chkAktifPasif.Checked;

                    cService.Update(categoryToUpdate);

                    MessageBox.Show("Güncelleme Başarılı.");
                    GetAllCategory();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir kategori seçin.");
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                var selectedCategoryId = Guid.Parse(lstListe.SelectedValue.ToString());
                var selectedCategory = cService.GetByID(selectedCategoryId);

                if (selectedCategory != null)
                {
                    txtAd.Text = selectedCategory.CategoryName; 
                    txtAciklama.Text = selectedCategory.Description;
                    chkAktifPasif.Checked = selectedCategory.IsActive;
                }
            }
        }
    }
}

