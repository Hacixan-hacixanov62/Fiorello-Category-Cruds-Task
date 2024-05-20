using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Slider_Blog_Services_task.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetAllAsync());
        }
    }
}
