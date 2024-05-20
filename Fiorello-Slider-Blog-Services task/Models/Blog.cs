namespace Fiorello_Slider_Blog_Services_task.Models
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
