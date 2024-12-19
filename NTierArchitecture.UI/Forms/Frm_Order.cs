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
    public partial class Frm_Order : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly ProductService _productService;
        private readonly ProductRepository _productRepository;
        private readonly OrderService _orderService;
        private readonly OrderRepository _orderRepository;
        private readonly OrderDetailService _orderDetailService;
        private readonly OrderDetailRepository _orderDetailRepository;
        public Frm_Order()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _productRepository = new ProductRepository(_context);
            _productService = new ProductService(_productRepository);

            _orderRepository = new OrderRepository(_context);
            _orderService = new OrderService(_orderRepository);

            _orderDetailRepository = new OrderDetailRepository(_context);
            _orderDetailService = new OrderDetailService(_orderDetailRepository);
        }

        private void Frm_Order_Load(object sender, EventArgs e)
        {
            GetAllProducts();
            GetAllOrders();
        }

        private void GetAllOrders()
        {
            lstOrders.DataSource = _orderService.GetAll();
        }

        private void GetAllProducts()
        {
            lstProductList.ValueMember = "Id";
            lstProductList.DisplayMember = "ProductName";
            lstProductList.DataSource = _productService.GetAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 3)
            {
                var pList = _productService.GetAll().Where(p => p.ProductName.ToLower().Contains(searchText));

                lstProductList.ValueMember = "Id";
                lstProductList.DisplayMember = "ProductName";
                lstProductList.DataSource = pList.ToList();
            }
            else if (searchText.Length == 0)
            {
                GetAllProducts();
            }
        }
        Product? selectedProduct;

        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedIndex != -1)
            {
                selectedProduct = (Product?)lstProductList.SelectedItem;
                txtPrice.Text = selectedProduct.UnitPrice.ToString();
            }
        }
        Card sepet = new Card();

        private void btnBasket_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                CardItem item = new CardItem()
                {
                    CardItemID = Guid.NewGuid(),
                    ProductID = selectedProduct.Id,
                    Quantity = Convert.ToInt32(nmrQuantity.Value),
                    UnitPrice = Convert.ToDouble(txtPrice.Text),
                    ProductName = selectedProduct.ProductName
                };

                sepet.AddItem(item);
                GetAllCardItems();
                CardandCardItemTotal();
            }
        }
        private void CardandCardItemTotal()
        {
            double bTotal = 0;

            foreach (var item in sepet.CardItems)
            {
                bTotal += item.Quantity * item.UnitPrice;
            }
            lblBasketTotal.Text = $"Sepet Toplamı: {bTotal:C}";
            lblBasketCount.Text = $"Ürün Adedi: {sepet.CardItems.Count}";
        }

        private void GetAllCardItems()
        {
            lstBasket.Items.Clear();
            sepet.CardItems.ForEach(x => lstBasket.Items.Add(x));
        }

        CardItem? selectedCardItem;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedIndex != -1)
            {
                selectedCardItem = (CardItem?)lstBasket.SelectedItem;

                if (selectedCardItem != null)
                {
                    sepet.DeleteItem(selectedCardItem.CardItemID);
                    GetAllCardItems();
                    CardandCardItemTotal();
                }
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Order o = new Order()
                    {
                        IsActive = true,
                        CreatedDate = DateTime.Now,
                        OrderDate = DateOnly.FromDateTime(DateTime.Now),
                        EmployeeID = Guid.Parse("827f7e0a-7a21-426a-a342-a3fbbefb5d08"),
                        CustomerID = Guid.Parse("3e863e0d-fb09-47e3-a1e4-38498fbb0a4f"),
                        ShipCity = "İstanbul"
                    };

                    _orderService.Add(o);
                    //throw new Exception("hata");
                    #region Yontem1
                    //foreach (var item in sepet.CardItems)
                    //{
                    //    OrderDetail od = new OrderDetail()
                    //    {
                    //        IsActive = true,
                    //        CreatedDate = DateTime.Now,
                    //        Quantity = item.Quantity,
                    //        UnitPrice = item.UnitPrice,
                    //        OrderID = o.Id,
                    //        ProductID = item.ProductID,
                    //    };

                    //    _orderDetailService.Add(od);
                    //}
                    #endregion

                    #region Yontem2

                    sepet.CardItems.ForEach(x => _orderDetailService.Add(
                        new OrderDetail()
                        {
                            CreatedDate = DateTime.Now,
                            IsActive = true,
                            ProductID = x.ProductID,
                            OrderID = o.Id,
                            Quantity = x.Quantity,
                            UnitPrice = x.UnitPrice
                        }
                        ));
                    #endregion

                    transaction.Commit();
                    GetAllOrders();
                    MessageBox.Show("Sipariş başarı ile kayıt edildi.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    //MessageBox.Show($"Hata oluştu: {ex.Message}. Detaylar için iç hata mesajına bakınız: {ex.InnerException?.Message}");
                    MessageBox.Show(ex.Message);
                }
            }
        }
        Order? selectedOrder;

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex != -1)
            {
                selectedOrder = (Order?)lstOrders.SelectedItem;

                if (selectedOrder != null)
                {
                    var odDetails = _orderDetailService.GetOrderDetails(selectedOrder.Id);

                    dgwOrderDetails.DataSource = odDetails.ToList();
                }
            }
        }

        private void dgwOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
