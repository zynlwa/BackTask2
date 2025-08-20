using FirstApp.Eterna.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Eterna.Data
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options) 
        { 
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<SectionContent> SectionContents { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<PortfolioImages> PortfolioImages { get; set; }
    }
  
}
