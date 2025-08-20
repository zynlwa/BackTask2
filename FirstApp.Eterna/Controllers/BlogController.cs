using FirstApp.Eterna.Data;
using FirstApp.Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Eterna.Controllers
{
    public class BlogController(EternaDbContext eternaDbContext): Controller
    {
        public IActionResult Index()
        {
            BlogVm blogVm = new BlogVm()
            {
                Blogs=eternaDbContext.Blogs.ToList(),
                RecentBlogs=eternaDbContext.Blogs.OrderByDescending(b=>b.Id).ToList(),
                Category=eternaDbContext.Category.ToList()
            };

            return View(blogVm);
        }
        public IActionResult Detail()
        {
             return View();
        }
    }
}
