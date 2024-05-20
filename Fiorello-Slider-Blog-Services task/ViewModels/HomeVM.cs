using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.ViewModels.Blog;

namespace Fiorello_Slider_Blog_Services_task.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public IEnumerable<BlogVM> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}
