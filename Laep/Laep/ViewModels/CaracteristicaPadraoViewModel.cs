using Prodfy.ViewModels;
using System.Collections.Generic;

namespace Laep.ViewModels
{
    public class CaracteristicaPadraoViewModel : BaseViewModel
    { 
        public List<string> ListaQuantidadeCaixas { get; } = new List<string> { "1", "2", "3" };
        public List<string> ListaTensao { get; } = new List<string> { "Sistema Trifásico 127/220V", "Sistema Monofásico 120/240V" };
        public List<string> ListaModeloCaixas { get; } = new List<string> { "Monofasico", "Bifasico", "Trifasico" };

        readonly List<string> ListaDisjuntores = new List<string>();

        private string _modeloCaixaSelecionado;
        public string ModeloCaixaSelecionado
        {
            get => _modeloCaixaSelecionado;
            set
            {
                SetProperty(ref _modeloCaixaSelecionado, value);
                ListaDisjuntores.Clear();

                if (Disjuntores != null)
                    Disjuntores = null;

                if (_modeloCaixaSelecionado == "Monofasico")
                {
                    ListaDisjuntores.Add("40A");
                    ListaDisjuntores.Add("50A");
                    ListaDisjuntores.Add("70A");
                    Disjuntores = ListaDisjuntores;
                }
                else
                {
                    ListaDisjuntores.Add("40A");
                    ListaDisjuntores.Add("60A");
                    Disjuntores = ListaDisjuntores;
                }
            }
        }

        private List<string> _disjuntores;
        public List<string> Disjuntores
        {
            get => _disjuntores;
            set => SetProperty(ref _disjuntores, value);
        }
    }
}
