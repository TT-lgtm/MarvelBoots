namespace MarvelBoots.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
            ProductSize = new HashSet<ProductSize>();
        }

        [Key]
        public int IdProduct { get; set; }

        public int CategoryId { get; set; }

        public int SubcategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Photo { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Composition { get; set; }

        public decimal ProductPrice { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        public virtual Subcategory Subcategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSize> ProductSize { get; set; }

        // STUD {
        /// <summary>
        /// STUD
        ///
        /// Рассчитать цену товара (рубли) с учетом скидки: 25% на товары, на
        /// которые не было заказов в апреле текущего года.
        ///
        /// </summary>
        /// <returns>Decimal</returns>
        public Decimal GetPrice()
        {

            int currentYear = DateTime.Now.Year;

            bool hasSales = Program.context.OrderProduct.Count(op => op.ProductId == this.IdProduct &&
                           op.Order.Date.Year == currentYear &&
                           op.Order.Date.Month == 4) > 0; // STUD Апрель.

            Decimal result = ProductPrice;

            if (!hasSales)
            {
                result = Math.Round(ProductPrice * 0.75m, 2); // STUD Скидка 25%.
            }

            return result;
        }

        /// <summary>
        /// STUD
        ///
        /// Количество: «много», если более пяти единиц товарных
        /// позиций и «мало», если менее или равно пяти.
        ///
        /// </summary>
        ///
        /// <returns>String</returns>
        public string GetStock()
        {
            int stock = ProductSize.Sum(p => p.Stock) ?? 0;

            string result = "";

            if (stock > 5)
            {
                result = "Много";
            }
            else
            {
                result = "Мало";
            }

            return result;
        }

        public Image GetImage()
        {
            String imgPath = System.IO.Path.Combine(Application.StartupPath, "Images", Photo);


            Image img = Image.FromFile(imgPath);

            return img;

        }

        /// <summary>
        /// STUD
        ///
        /// Критически мало товара, если
        /// доступное для заказа количество которых меньше или равно трем.
        ///
        /// </summary>
        /// <returns>Bool</returns>
        public bool IsRunningLow()
        {
            int stock = ProductSize.Sum(p => p.Stock) ?? 0;
            bool result = stock <= 3;
            return result;
        }

        // } STUD
    }
}
