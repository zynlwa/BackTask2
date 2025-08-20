using FirstApp.Eterna.Models;

namespace FirstApp.Eterna.ViewModels
{
    public class BlogVm
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> RecentBlogs { get; set; }
        public List<Category> Category { get; set; }
    }
}
