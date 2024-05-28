using System.ComponentModel;

namespace LogisticsMVC.Models
{
    public class Product
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        [DisplayName("Product Quantity Stocked")]
        public int ProductQuantityInStock { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
