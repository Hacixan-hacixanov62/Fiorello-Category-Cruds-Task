using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Slider_Blog_Services_task.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
