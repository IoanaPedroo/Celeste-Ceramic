using backend.Models.Entities;
using backend.Models.Interfaces;

namespace backend.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;

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
            throw new NotImplementedException();
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
