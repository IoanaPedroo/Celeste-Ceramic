using backend.Models.Entities;
using backend.Models.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace backend.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext _storeContext;
        public CategoryRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public void AddCategory(Category category)
        {
            _storeContext.Categories.Add(category);
            _storeContext.SaveChanges();
        }

        public void DeleteCategoryById(long id)
        {
            var category = _storeContext.Categories.FirstOrDefault(x => x.Id  == id);
            _storeContext.Categories.Remove(category);
            _storeContext.SaveChanges();
        }
       
        public List<Category> GetAllCategories()
        {
           var categories = _storeContext.Categories.ToList();
            return categories;
        }

        public Category GetCategoryById(long id)
        {
            var category = _storeContext.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        public void UpdateCategoryById(long id, Category category)
        {
           var oldCategory = _storeContext.Categories.FirstOrDefault(x => x.Id == id);
            oldCategory.Name = category.Name;
            oldCategory.Description = category.Description;
            _storeContext.SaveChanges();
        }
    }
}
