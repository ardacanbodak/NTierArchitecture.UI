using System;
using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.UI.Forms;


namespace NTierArchitecture.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationDbContext context = new ApplicationDbContext();
            CategoryRepository categoryRepository = new CategoryRepository(context);
            CategoryService categoryService = new CategoryService(categoryRepository);
            SupplierRepository supplierRepository = new SupplierRepository(context);
            SupplierService supplierService = new SupplierService(supplierRepository);

            ProductRepository productRepository = new ProductRepository(context);
            ProductService productService = new ProductService(productRepository);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_Main());
        }
    }
}