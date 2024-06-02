using OrdersMVC.Models;

namespace OrdersMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Product.Any())
            {
                return; //DB has been seeded
            }

            var products = new Product[]
            {
                new Product{ProductId=1,ProductName="Boards",ProductDescription="Description for Boards",ProductQuantityInStock=10},
                new Product{ProductId=2,ProductName="Screws",ProductDescription="Description for Screws",ProductQuantityInStock=150}
            };

            foreach (Product p in products)
            {
                context.Product.Add(p);
            }
            context.SaveChanges();


            var orders = new Order[]
            {
                new Order{ OrderName="MSStore1", OrderDate= DateTime.Now, OrderType = OrderTypes.Store },
                new Order{ OrderName="MSPick1", OrderDate= DateTime.Now, OrderType = OrderTypes.Pick }

            };

            foreach (Order o in orders)
            {
                context.Order.Add(o);
            }
            context.SaveChanges();

            var orderProducts = new OrderProduct[]
            {
                new OrderProduct {OrderId = orders[0].OrderID, ProductId = products[0].ProductId},
                new OrderProduct {OrderId = orders[0].OrderID, ProductId = products[1].ProductId}
            };

            foreach (OrderProduct ops in orderProducts)
            {
                context.OrderProducts.Add(ops);
            }
            context.SaveChanges();
    

    }
    }
}
