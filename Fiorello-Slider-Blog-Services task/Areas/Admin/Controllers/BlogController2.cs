using Fiorello_Slider_Blog_Services_task.Data;
using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Fiorello_Slider_Blog_Services_task.ViewModels.Blog;
using Fiorello_Slider_Blog_Services_task.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Slider_Blog_Services_task.Areas.Admin.Controllers
{
    public class BlogController2 : Controller
    {
        private readonly IBlogService _blogService;
        private readonly AppDbContext _context;
        public BlogController2(IBlogService blogService,
                                AppDbContext context )
        {
            _blogService = blogService;
            _context = context; 
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCreateVM blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool existblog = await _blogService.ExistAsync(blog.Title);

            if (existblog)
            {
                ModelState.AddModelError("Name", "This category already exist ");
                return View();
            }
            await _blogService.CreateAsync(new Blog { Title = blog.Title });
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var blog = await _blogService.GetByIdAsync((int)id);

            if (blog is null) return NotFound();

            await _blogService.DeleteAsync(blog);

            return RedirectToAction(nameof(Index));


        }
    }
}
