using System.ComponentModel.DataAnnotations;

namespace LogisticsMVC.Models
{



    public class Order
    {

        public int OrderID { get; set; }

        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<Product> OrderProducts { get; set; }

        public OrderTypes OrderType { get; set; }


    }

}
