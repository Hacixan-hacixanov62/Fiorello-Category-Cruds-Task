﻿using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Fiorello_Slider_Blog_Services_task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Slider_Blog_Services_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public HomeController(ISliderService sliderService,
                                  IBlogService blogService,
                                  ICategoryService categoryService,
                                  IProductService productService)
        {
            _sliderService = sliderService;
            _blogService = blogService;
            _categoryService = categoryService;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new()
            {
                Sliders = await _sliderService.GetAllAsync(),
                SliderInfo = await _sliderService.GetSliderInfoAsync(),
                Blogs = await _blogService.GetAllAsync(3),
                Categories = await _categoryService.GetAllAsync(),
                Products = await _productService.GetAllAsync()
            };

            return View(model);
        }
    }
}


