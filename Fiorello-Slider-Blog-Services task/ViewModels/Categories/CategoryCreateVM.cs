using System.ComponentModel.DataAnnotations;

namespace Fiorello_Slider_Blog_Services_task.ViewModels.Categories
{
    public class CategoryCreateVM
    {
        [Required(ErrorMessage ="This input can't be empty")]
        [StringLength(20,ErrorMessage = "please, you cannot enter more than 20 symbols")]
        public string Name { get; set; }
    }
}
