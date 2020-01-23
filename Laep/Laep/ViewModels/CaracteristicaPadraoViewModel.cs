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

        private string _modeloCaixaSelecionado1;
        public string ModeloCaixaSelecionado1
        {
            get => _modeloCaixaSelecionado1;
            set
            {
                SetProperty(ref _modeloCaixaSelecionado1, value);
                AmperagemDisjuntores(_modeloCaixaSelecionado1, "disjuntor1");
            }
        }

        private string _modeloCaixaSelecionado2;
        public string ModeloCaixaSelecionado2
        {
            get => _modeloCaixaSelecionado2;
            set
            {
                SetProperty(ref _modeloCaixaSelecionado2, value);
                AmperagemDisjuntores(_modeloCaixaSelecionado2, "disjuntor2");
            }
        }

        private string _modeloCaixaSelecionado3;
        public string ModeloCaixaSelecionado3
        {
            get => _modeloCaixaSelecionado3;
            set
            {
                SetProperty(ref _modeloCaixaSelecionado3, value);
                AmperagemDisjuntores(_modeloCaixaSelecionado3, "disjuntor3");
            }
        }

        private List<string> _disjuntores1;
        public List<string> Disjuntores1
        {
            get => _disjuntores1;
            set => SetProperty(ref _disjuntores1, value);
        }

        private List<string> _disjuntores2;
        public List<string> Disjuntores2
        {
            get => _disjuntores2;
            set => SetProperty(ref _disjuntores2, value);
        }

        private List<string> _disjuntores3;
        public List<string> Disjuntores3
        {
            get => _disjuntores3;
            set => SetProperty(ref _disjuntores3, value);
        }

        private void AmperagemDisjuntores(string tipoCaixa, string disjuntor)
        {
            if (tipoCaixa == "Monofasico")
            {
                if (ListaDisjuntores != null)
                {
                    ListaDisjuntores.Clear();

                    ListaDisjuntores.Add("40A");
                    ListaDisjuntores.Add("50A");
                    ListaDisjuntores.Add("70A");
                }

                if (disjuntor == "disjuntor1")
                {
                    if (Disjuntores1 != null)
                    {
                        Disjuntores1 = null;
                    }

                    Disjuntores1 = ListaDisjuntores;
                }                    

                if (disjuntor == "disjuntor2")
                {
                    if (Disjuntores2 != null)
                    {
                        Disjuntores2 = null;
                    }

                    Disjuntores2 = ListaDisjuntores;
                }                    

                if (disjuntor == "disjuntor3")
                {
                    if (Disjuntores3 != null)
                    {
                        Disjuntores3 = null;
                    }

                    Disjuntores3 = ListaDisjuntores;
                }
            }
            else
            {
                if (ListaDisjuntores != null)
                {
                    ListaDisjuntores.Clear();

                    ListaDisjuntores.Add("40A");
                    ListaDisjuntores.Add("60A");
                }

                if (disjuntor == "disjuntor1")
                {
                    if (Disjuntores1 != null)
                    {
                        Disjuntores1 = null;
                    }

                    Disjuntores1 = ListaDisjuntores;
                }

                if (disjuntor == "disjuntor2")
                {
                    if (Disjuntores2 != null)
                    {
                        Disjuntores2 = null;
                    }

                    Disjuntores2 = ListaDisjuntores;
                }

                if (disjuntor == "disjuntor3")
                {
                    if (Disjuntores3 != null)
                    {
                        Disjuntores3 = null;
                    }

                   Disjuntores3 = ListaDisjuntores;
                }
            }
        }
    }
}
