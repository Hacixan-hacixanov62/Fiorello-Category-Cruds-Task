namespace Fiorello_Slider_Blog_Services_task.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
