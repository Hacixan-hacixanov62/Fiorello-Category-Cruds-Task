//using Fiorello_Slider_Blog_Services_task.Data;
//using Fiorello_Slider_Blog_Services_task.Models;
//using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
//using Fiorello_Slider_Blog_Services_task.ViewModels.Blog;
//using Fiorello_Slider_Blog_Services_task.ViewModels.Categories;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;

//namespace Fiorello_Slider_Blog_Services_task.Services
//{
//    public class BlogService : IBlogService
//    {
//        private readonly AppDbContext _context;
//        public BlogService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public async Task CreateAsync(Blog blog)
//        {
//            await _context.AddAsync(blog);
//            await _context.SaveChangesAsync();
//        }

//        public async Task DeleteAsync(Blog blog)
//        {
//            _context.Blogs.Remove(blog);
//            await _context.SaveChangesAsync();
//        }

//        public async Task<bool> ExistAsync(string title)
//        {
//            return await _context.Blogs.AnyAsync(m => m.Title.Trim() == title.Trim());

//        }

//        public async Task<IEnumerable<BlogVM>> GetAllAsync(int? take=null)
//        {
//            IEnumerable<Blog> blogs;

//            if (take is null)
//            {
//                blogs = await _context.Blogs.ToListAsync();
//            }
//            else
//            {
//                blogs = await _context.Blogs.Take((int)take).ToListAsync();
//            }

//            return blogs.Select(m => new BlogVM
//            {
//                Id = m.Id,
//                Title = m.Title,
//                Description = m.Description,
//                Image = m.Image,
//                CreateDate = m.CreateDate.ToString("MM.dd.yyyy")
//            });
//        }

//        public async Task<Blog> GetByIdAsync(int id)
//        {
//            return await _context.Blogs.FindAsync();
//        }

//    }
//}
