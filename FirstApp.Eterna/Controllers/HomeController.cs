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
            var client= _context.Clients.ToList();
            var clientsSection = _context.SectionContents.FirstOrDefault(s => s.Title == "Clients");
            HomeVm homeVm = new HomeVm()
            {
                Sliders = slider,
                Clients = client,
                ClientsSection=clientsSection
              
            };

            return View(homeVm); 
        }
    }
}
