using FirstApp.Eterna.Models;

namespace FirstApp.Eterna.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public List<Client> Clients { get; set; }
        public SectionContent ClientsSection { get; set; }

    }
}
