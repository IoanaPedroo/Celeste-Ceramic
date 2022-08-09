using backend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using backend.Models.Entities;
/*using backend.Models.Interfaces;*/

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

        [HttpGet]
        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }
        [HttpGet("{id:long}")]
        public Category GetCategoryById(long id)
        {
            return _categoryRepository.GetCategoryById(id);
        }

        [HttpDelete]
        public void DeleteCategoryById(long id)
        {
            _categoryRepository.DeleteCategoryById(id);
        }
        [HttpPost]
        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        [HttpPut("{id:long}")]
        public void UpdateProductById(long id)
        {
            _categoryRepository.UpdateCategoryById(id);
        }

    }
}
