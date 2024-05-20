using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.ViewModels.Blog;

namespace Fiorello_Slider_Blog_Services_task.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync(int? take = null);
        Task<Blog> GetByIdAsync(int id);
        Task<bool> ExistAsync(string Name);
        Task CreateAsync(Blog blog);
        Task DeleteAsync(Blog blog);
    }
}
