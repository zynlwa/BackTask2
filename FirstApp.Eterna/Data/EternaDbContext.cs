using FirstApp.Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Eterna.Data
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options) 
        { 
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<PortfolioImages> PortfolioImages { get; set; }
    }
  
}
