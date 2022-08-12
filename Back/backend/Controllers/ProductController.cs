using backend.Models.Entities;
using backend.Models.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController, Route("/product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [EnableCors("Policy")]
        public JsonResult GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Json(products);
        }

        [HttpGet("{id:long}")]
        public JsonResult GetProductById(long id)
        {
            return Json(_productRepository.GetProductById(id));   
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
        public void UpdateProductById(long id, Product product)
        {
            _productRepository.UpdateProductById(id, product);
        }

    }
}
