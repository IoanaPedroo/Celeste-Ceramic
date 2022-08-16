using backend.Models.Entities;
using backend.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        //merge
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        //merge
        public void DeleteProductById(long id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges();        
        }
        //merge
        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products;

        }
        //merge
        public Product GetProductById(long id)
        {
           var product = _context.Products.FirstOrDefault(x => x.Id == id);
           return product;
        }

        //merge
        public void UpdateProductById(long id, Product product)
        {
            var oldProduct = _context.Products.FirstOrDefault(x => x.Id == id);
            oldProduct.Category = product.Category;
            oldProduct.Discount = product.Discount;
            oldProduct.Currency = product.Currency;
            oldProduct.Price = product.Price;
            oldProduct.ProductInventory = product.ProductInventory;
            oldProduct.Image = product.Image;
            oldProduct.Name = product.Name;
            oldProduct.Description = product.Description;
            _context.SaveChanges();
        }
    }
}
