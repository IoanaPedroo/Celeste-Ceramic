using backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using backend.Models.Entities;
using Microsoft.AspNetCore.Cors;

namespace backend.Controllers
{
    [ApiController, Route("/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        //merge
        [HttpGet]
        [EnableCors("Policy")]
        public JsonResult GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories();
            return Json(categories);
        }
        //merge
        [HttpGet("{id:long}")]
        public JsonResult GetCategoryById(long id)
        {
            return Json(_categoryRepository.GetCategoryById(id));
        }
        //merge
        [HttpDelete]
        public void DeleteCategoryById(long id)
        {
            _categoryRepository.DeleteCategoryById(id);
        }
        //merge
        [HttpPost]
        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
        //merge
        [HttpPut("{id:long}")]
        public void UpdateProductById(long id, Category category)
        {
            _categoryRepository.UpdateCategoryById(id, category);
        }

    }
}
