using System.ComponentModel.DataAnnotations;

namespace LogisticsMVC.Models
{

    public enum Type
    {
        Pick,
        Store
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public Type OrderType { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

}
