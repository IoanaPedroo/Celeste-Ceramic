using backend.Models.Entities;
using backend.Models.Interfaces;

namespace backend.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;
        public ProductRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
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
            return _storeContext.Products.ToList();
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
