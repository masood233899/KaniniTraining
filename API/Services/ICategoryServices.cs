using grocery_api.Models;

namespace grocery_api.Services
{
    public interface ICategoryServices
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryById(int id);

        Task<List<Category>?> PutCategory(int id, Category category);

        Task<List<Category>> PostCategory(Category category);

        Task<List<Category>?> DeleteCategory(int id);

    }
}
