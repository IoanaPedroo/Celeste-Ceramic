using backend.Models.Entities;
using backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController, Route("/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]

        public JsonResult GetAllProducts()
        {
            List<Product> products = _productRepository.GetAllProducts();
            return Json(products);
        }
        [HttpGet("{id:long}")]
        public Product GetProductById(long id)
        {
            return _productRepository.GetProductById(id);   
        }

        [HttpDelete]
        public void DeleteProductById(long id)
        {
            _productRepository.DeleteProductById(id);
        }
        [HttpPost]
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        [HttpPut("{id:long}")]
        public void UpdateProductById(long id)
        {
            _productRepository.UpdateProductById(id);
        }

    }
}
