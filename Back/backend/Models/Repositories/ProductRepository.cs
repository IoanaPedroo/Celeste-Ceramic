using backend.Models.Entities;
using backend.Models.Interfaces;

namespace backend.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product GetProductById(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
