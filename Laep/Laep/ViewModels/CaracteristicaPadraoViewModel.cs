using System.Collections.ObjectModel;

namespace Laep.ViewModels
{
    public class CaracteristicaPadraoViewModel
    {
        public ObservableCollection<string> QuantidadeCaixas { get; } = new ObservableCollection<string> { "1", "2", "3" };
        public ObservableCollection<string> Tensao { get; } = new ObservableCollection<string> { "Sistema Trifásico 127/220V", "Sistema Monofásico 120/240V" };
        public ObservableCollection<string> ModeloCaixas { get; } = new ObservableCollection<string> { "Monofasico", "Bifasico", "Trifasico" };
        public ObservableCollection<string> Disjuntores { get; } = new ObservableCollection<string> { "40A", "50A", "60A", "70A" };
    }
}
