using System.Collections.ObjectModel;

namespace Laep.ViewModels
{
    public class CaracteristicaPadraoViewModel
    {
        //List<string> listaDisjuntorCaixaBifasicoTrifasico = new List<string> { "40A", "60A" };

        public ObservableCollection<string> Disjuntores { get; } = new ObservableCollection<string> { "40A", "50A", "60A", "70A" };
    }
}
