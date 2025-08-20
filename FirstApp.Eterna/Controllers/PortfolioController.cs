using FirstApp.Eterna.Data;
using FirstApp.Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Eterna.Controllers
{
    public class PortfolioController(EternaDbContext eternaDbContext) : Controller
    {
        public IActionResult Index()
        {
            PortfolioVm portfolioVm = new PortfolioVm()
            {
                Portfolios = eternaDbContext.Portfolio
                .Include(p=>p.PortfolioImages)
                .ToList(),
                
                Categories = eternaDbContext.Category.ToList()
            };   



            return View(portfolioVm);
        }
    }
}
