using backend.Models.Entities;

namespace backend.Models.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(long id);
        void DeleteCategoryById(long id);
        void AddCategory(Category category);
        void UpdateCategoryById(long id);
    }
}
