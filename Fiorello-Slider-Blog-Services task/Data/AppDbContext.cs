using Fiorello_Slider_Blog_Services_task.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Fiorello_Slider_Blog_Services_task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfo { get; set; }
        //public DbSet<Blog> Blogs { get; set; }
        public DbSet<Expert> Experts { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductImage> ProductImages { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
        //    modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
        //    modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
        //    modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);

        //    modelBuilder.Entity<Blog>().HasData(
        //    new Blog
        //      {
        //        Id = 1,
        //        Title = "title1",
        //        Description = "Reshadin blogu",
        //        Image = "blog-feature-img-1.jpg",
        //        CreateDate = DateTime.Now,
        //    },
        //    new Blog 
        //     {
        //        Id = 2,
        //        Title = "title2",
        //        Description = "Ilqarin blogu",
        //        Image = "blog-feature-img-3.jpg",
        //        CreateDate = DateTime.Now,
        //    },
        //     new Blog
        //     {
        //        Id = 3,
        //        Title = "title3",
        //        Description = "Hacixanin blogu",
        //        Image = "blog-feature-img-4.jpg",
        //        CreateDate = DateTime.Now,
        //     }
        //  );

        //}




    }
}
