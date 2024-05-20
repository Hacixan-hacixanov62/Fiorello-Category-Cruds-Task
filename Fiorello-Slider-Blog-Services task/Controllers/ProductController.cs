using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Slider_Blog_Services_task.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            string hashData = Guid.NewGuid().ToString();
            ViewBag.Hash = hashData;
            if (id is null) return BadRequest();
           Product product = await _productService.GetByIdAsync((int)id);
           if (product is null) return NotFound();

            return View(product);
        }
    }
}
