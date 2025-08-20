using FirstApp.Eterna.Models;

namespace FirstApp.Eterna.ViewModels
{
    public class BlogDetailVm
    {
        public Blog Blog { get; set; }
        public List<Blog> RecentBlogs { get; set; }
        public List<Category> Category { get; set; }
    }
}
