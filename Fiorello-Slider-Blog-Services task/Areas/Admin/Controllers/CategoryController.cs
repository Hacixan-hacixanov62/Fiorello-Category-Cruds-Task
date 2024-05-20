using Fiorello_Slider_Blog_Services_task.Data;
using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Fiorello_Slider_Blog_Services_task.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_Slider_Blog_Services_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly AppDbContext _context;
        public CategoryController(ICategoryService categoryService,
                                  AppDbContext context)
        {
            _categoryService= categoryService;
            _context= context;
         
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetAllWithProductCountAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateVM category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool existCategory = await _categoryService.ExistAsync(category.Name);
            
            if (existCategory)
            {
                ModelState.AddModelError("Name","This category already exist ");
                return View();
            }
            await _categoryService.CreateAsync(new Category { Name = category.Name });
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var category = await _categoryService.GetByIdAsync((int)id);

            if(category is null) return NotFound();

            await _categoryService.DeleteAsync(category);

            return RedirectToAction(nameof(Index));


        }

    }
}
