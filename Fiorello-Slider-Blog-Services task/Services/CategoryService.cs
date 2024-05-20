using Fiorello_Slider_Blog_Services_task.Data;
using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Fiorello_Slider_Blog_Services_task.ViewModels.Categories;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_Slider_Blog_Services_task.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Category category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string Name)
        {
            return  await _context.Categories.AnyAsync(m=>m.Name.Trim() ==  Name.Trim()); 
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public  async Task<IEnumerable<CategoryProductVM>> GetAllWithProductCountAsync()
        {
            IEnumerable<Category> categories = await _context.Categories.Include(m=>m.Products)
                                                                        .OrderByDescending(m=>m.Id)
                                                                        .ToListAsync();


            return categories.Select(m => new CategoryProductVM 
            { 
                Id= m.Id,
                CategoryName = m.Name,
                CreateDate = m.CreateDate.ToString("dd,MM,yyyy"),
                ProductCount = m.Products.Count
            });
        }

       public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        
    }
}
