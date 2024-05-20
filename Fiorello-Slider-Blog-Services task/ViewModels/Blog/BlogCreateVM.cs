using System.ComponentModel.DataAnnotations;

namespace Fiorello_Slider_Blog_Services_task.ViewModels.Blog
{
    public class BlogCreateVM
    {
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(20, ErrorMessage = "please, you cannot enter more than 20 symbols")]
        public string Title { get; set; }
    }
}
