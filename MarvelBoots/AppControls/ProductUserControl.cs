using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelBoots.AppModels;

namespace MarvelBoots.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        public ProductUserControl(Product product)
        {
            _product=product;
            InitializeComponent();
            ShowInfo();
            HighlightRunningLow();
        }

        private void ShowInfo()
        {
            manufacturerNameLabel.Text = $"{_product.Manufacturer.ManufacturerName} | {_product.ProductName}";
            categoryLabel.Text = $"Категория: {_product.Category.CategoryName.ToString()}";
            stockLabel.Text = $"Количество: {_product.GetStock()}";
            compositionLabel.Text = $"Состав: {_product.Composition}";
            priceLabel.Text = $"Цена:\n {_product.GetPrice()} руб.";
            idLabel.Text = $"Id: {_product.IdProduct}";
            photoPictureBox.Image = _product.GetImage();
        }

        private void HighlightRunningLow()
        {
            if (_product.IsRunningLow())
            {
                this.BackColor = ColorTranslator.FromHtml(Constant.LightRed);
            }
        }

    }
}
