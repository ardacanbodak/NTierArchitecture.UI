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
    public partial class Frm_Employee : Form
    {
        public Frm_Employee()
        {
            InitializeComponent();
            eRepo = new EmployeeRepository(context);
            eService = new EmployeeService(eRepo);
        }
        ApplicationDbContext context = new ApplicationDbContext();
        private EmployeeRepository eRepo;
        EmployeeService eService;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                Employee emp = new Employee();
                emp.Name = txtAd.Text;
                emp.Surname = txtSoyad.Text;
                emp.Country = txtUlke.Text;
                emp.City = txtSehir.Text;
                emp.Phone = txtNo.Text;
                
                emp.IsActive = chkAktifPasif.Checked;

                eService.Add(emp);

                MessageBox.Show("İşlem Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetAllEmployee();
        }
        private void GetAllEmployee()
        {
            lstList.DataSource = null;
            lstList.DisplayMember = "Name" + "Surname";
            lstList.ValueMember = "ID";
            lstList.DataSource = eService.GetAll();

        }
    }
    
}
