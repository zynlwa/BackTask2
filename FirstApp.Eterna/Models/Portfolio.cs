namespace FirstApp.Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Client {  get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  
        public ICollection<PortfolioImages> PortfolioImages { get; set; }
    }
}
