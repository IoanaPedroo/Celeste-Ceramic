using backend.Models.Entities;
using backend.Models.Interfaces;

namespace backend.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ICategoryRepository _categoryRepository;

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategoryById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoryById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
