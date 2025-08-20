using FirstApp.Eterna.Data;
using FirstApp.Eterna.Models;
using FirstApp.Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Detail(int id)
        {
            Blog blog = eternaDbContext.Blogs.FirstOrDefault(b => b.Id == id);
            if (blog == null) 
                return NotFound();
            BlogDetailVm blogDetailVm = new BlogDetailVm()
            {
                Blog = blog,
                RecentBlogs = eternaDbContext.Blogs.OrderByDescending(b => b.Id).ToList(),
                Category = eternaDbContext.Category.ToList()
            };

            return View(blogDetailVm);
        }
    }
}
