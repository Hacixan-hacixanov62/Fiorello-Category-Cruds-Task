using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.ViewModels.Categories;

namespace Fiorello_Slider_Blog_Services_task.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<CategoryProductVM>> GetAllWithProductCountAsync();
        Task<Category>GetByIdAsync(int id);
        Task<bool>ExistAsync(string Name);
        Task CreateAsync(Category category);
        Task DeleteAsync(Category category);
    }
}
