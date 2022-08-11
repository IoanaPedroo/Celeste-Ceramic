using backend.Models;
using backend.Models.Entities;

namespace backend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Vaza Ming",
                    Description = "O-la-la",
                    Price = 50,
                    Currency = "Lei",

                },

                 new Product
                {
                    Id = 2,
                    Name = "Vaza Rosa",
                    Description = "O-la-la",
                    Price = 50,
                    Currency = "Lei",

                }
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

        }
    }
}
