using LogisticsMVC.Models;

namespace LogisticsMVC.Data
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
        }
    }
}
