using System.ComponentModel.DataAnnotations;

namespace LogisticsMVC.Models
{



    public class Order
    {

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public enum OrderTypes
        {
            Pick,
            Store
        }

        public OrderTypes OrderType { get; set; }

        public int OrderQuantity { get; set; }
    }

}
