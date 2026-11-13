using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelBoots.AppControls;
using MarvelBoots.AppModels;

namespace MarvelBoots.AppForms
{
    public partial class ProductListForm : ParentForm
    {
        private List<Product> _products;
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ShowProducts()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }

        }

        private void SelectProducts()
        {
            string searchInput = searchTextBox.Text.Trim();
            bool cheapFirstInput = cheapFirst.Checked;
            string categoryInput = (string)categoryComboBox.SelectedItem;

            IQueryable<Product> tmpProducts = Program.context.ProductSize.Where(p => p.Stock > 0).Select(p => p.Product).Distinct();
            
            if (!String.IsNullOrEmpty(searchInput))
            {
                tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.ProductName, "%" + searchInput + "%")
                || DbFunctions.Like(obj.Description, "%" + searchInput + "%")
                );
            }

            if (categoryInput != null && categoryInput != "Все категории")
            {
                tmpProducts = tmpProducts.Where(p => p.Category.CategoryName == categoryInput);
            }

            _products = tmpProducts.ToList();
        }

        private void ClearProducts()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void RefreshList()
        {
            ClearProducts();
            SelectProducts();
            ShowProducts();
        }

        private void cheapFirst_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void expensiveFirst_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
