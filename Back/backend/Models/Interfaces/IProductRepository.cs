using backend.Models.Entities;

namespace backend.Models.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(long id);
        void DeleteProductById(long id);
        void AddProduct(Product product);
        void UpdateProductById(long id, Product product);
    }
}
