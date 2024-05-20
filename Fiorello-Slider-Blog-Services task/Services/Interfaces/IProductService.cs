using Fiorello_Slider_Blog_Services_task.Models;

namespace Fiorello_Slider_Blog_Services_task.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
