using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Services;
using NTierArchitecture.Business.Validators;
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
    public partial class Frm_Customer : Form
    {
        public Frm_Customer()
        {
            InitializeComponent();
            cRepo = new CustomerRepository(context);
            cService = new CustomerService(cRepo);
        }
        ApplicationDbContext context = new ApplicationDbContext();
        private CustomerRepository cRepo;
        CustomerService cService;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                Customer cus = new Customer();
                cus.CustomerName = txtAd.Text;
                cus.Country = txtUlke.Text;
                cus.City = txtSehir.Text;
                cus.Phone = txtNo.Text;
                cus.IsActive = chkAktifPasif.Checked;

                cService.Add(cus);

                MessageBox.Show("İşlem Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetAllCustomer();
        }
        private void GetAllCustomer()
        {
            lstList.DataSource = null;
            lstList.DisplayMember = "CustomerName" ;
            lstList.ValueMember = "ID";
            lstList.DataSource = cService.GetAll();

        }
    }
    
}
