//using Fiorello_Slider_Blog_Services_task.Data;
//using Fiorello_Slider_Blog_Services_task.Models;
//using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace Fiorello_Slider_Blog_Services_task.Services
//{
//    public class ProductService : IProductService
//    {

//        private readonly AppDbContext _context;
//        public ProductService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public async Task<IEnumerable<Product>> GetAllAsync()
//        {
//            return await _context.Products.Include(m => m.ProductImages).ToListAsync();
//        }

//        public async Task<Product> GetByIdAsync(int id)
//        {
//          return await _context.Products.Where(m => m.Id == id)
//                                             .Include(m=>m.Category)
//                                             .Include(m=>m.ProductImages)
//                                             .FirstOrDefaultAsync();

//        }
//    }
//}
