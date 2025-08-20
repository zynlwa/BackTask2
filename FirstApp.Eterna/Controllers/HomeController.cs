using FirstApp.Eterna.Data;
using FirstApp.Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDbContext _context;

        public HomeController(EternaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var slider = _context.Sliders.ToList();
            HomeVm homeVm = new HomeVm()
            {
                Sliders = slider
            };

            return View(homeVm); 
        }
    }
}
