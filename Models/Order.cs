using System.ComponentModel.DataAnnotations;

namespace LogisticsMVC.Models
{

    public enum OrderType
    {
        Pick,
        Store
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderType Type { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

}
