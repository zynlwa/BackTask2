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
                Categories = eternaDbContext.Category.ToList(),
                Portfolios = eternaDbContext.Portfolio
                .Include(p => p.PortfolioImages)
                .ToList(),


            };
            //var data = eternaDbContext.Portfolio.FirstOrDefault();
            //eternaDbContext.Entry(data) //explicit
            //    .Reference(p => p.Category) //birnece Collection
            //    .Load();


            return View(portfolioVm);
        }
        public IActionResult Detail(int id)
        { 
            var portfolio = eternaDbContext.Portfolio
                .Include (p => p.Category)
                .Include (p => p.PortfolioImages)
                .FirstOrDefault(p=>p.Id == id);
            if(portfolio == null) 
                return NotFound();


            return View(portfolio);
        }
    }
}
