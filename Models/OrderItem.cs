namespace LogisticsMVC.Models
{
    public class OrderItem
    {
            public int OrderItemID { get; set; }

            public int QuantityInOrder { get; set; }
            public int ProductID { get; set; }
            
            public virtual Product Product { get; set; }
           
            public int OrderID { get; set; }

           public virtual Order Order { get; set; } 

    }
}
