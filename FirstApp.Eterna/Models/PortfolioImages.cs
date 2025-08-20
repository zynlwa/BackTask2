namespace FirstApp.Eterna.Models
{
    public class PortfolioImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
