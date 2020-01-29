using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    public class CaracteristicaPadraoViewModel : BaseViewModel
    { 
        public List<string> ListaQuantidadeCaixas { get; } = new List<string> { "1", "2", "3" };
        public List<string> ListaTensao { get; } = new List<string> { "Sistema Trifásico 127/220V", "Sistema Monofásico 120/240V" };
        public List<string> ListaModeloCaixas { get; } = new List<string> { "Monofasico", "Bifasico", "Trifasico" };

        readonly List<string> ListaDisjuntores = new List<string>();

        #region Propriedades
        private bool _visibleCaixa1 = false;
        public bool VisibleCaixa1
        {
            get => _visibleCaixa1;
            set => SetProperty(ref _visibleCaixa1, value);
        }

        private bool _visibleCaixa2 = false;
        public bool VisibleCaixa2
        {
            get => _visibleCaixa2;
            set => SetProperty(ref _visibleCaixa2, value);
        }

        private bool _visibleCaixa3 = false;
        public bool VisibleCaixa3
        {
            get => _visibleCaixa3;
            set => SetProperty(ref _visibleCaixa3, value);
        }

        private bool _visibleDisjuntores1 = false;
        public bool VisibleDisjuntores1
        {
            get => _visibleDisjuntores1;
            set => SetProperty(ref _visibleDisjuntores1, value);
        }

        private bool _visibleDisjuntores2 = false;
        public bool VisibleDisjuntores2
        {
            get => _visibleDisjuntores2;
            set => SetProperty(ref _visibleDisjuntores2, value);
        }

        private bool _visibleDisjuntores3 = false;
        public bool VisibleDisjuntores3
        {
            get => _visibleDisjuntores3;
            set => SetProperty(ref _visibleDisjuntores3, value);
        }

        private string _quantidadeCaixaSelecionado;
        public string QuantidadeCaixaSelecionado
        {
            get => _quantidadeCaixaSelecionado;
            set
            {
                SetProperty(ref _quantidadeCaixaSelecionado, value);
                QuantidadeCaixa(QuantidadeCaixaSelecionado);
            }
        }

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

        private string _disjuntores1Selecionado;
        public string Disjuntores1Selecionado
        {
            get => _disjuntores1Selecionado;
            set => SetProperty(ref _disjuntores1Selecionado, value);
        }

        private string _disjuntores2Selecionado;
        public string Disjuntores2Selecionado
        {
            get => _disjuntores2Selecionado;
            set => SetProperty(ref _disjuntores2Selecionado, value);
        }

        private string _disjuntores3Selecionado;
        public string Disjuntores3Selecionado
        {
            get => _disjuntores3Selecionado;
            set => SetProperty(ref _disjuntores3Selecionado, value);
        }
        #endregion

        #region Commands
        private Command _dimensionamentoCommand;
        public Command DimensionamentoCommand =>
            _dimensionamentoCommand ?? (_dimensionamentoCommand = new Command(async () => await ExecuteDimensionamentoCommand()));

        private async Task ExecuteDimensionamentoCommand()
        {
            string amperagens = $"{Disjuntores1Selecionado}, {Disjuntores2Selecionado}, {Disjuntores3Selecionado}";
             
            await Shell.Current.GoToAsync($"//dimensionamento?amper={amperagens}");
        }

        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//paginaInicial");

        #endregion

        #region Métodos
        private void QuantidadeCaixa(string quantidade)
        {
            if (quantidade == "1")
            {
                VisibleCaixa1 = true;
                VisibleCaixa2 = false;
                VisibleCaixa3 = false;

                VisibleDisjuntores1 = true;
                VisibleDisjuntores2 = false;
                VisibleDisjuntores3 = false;
            }

            if (quantidade == "2")
            {
                VisibleCaixa1 = true;
                VisibleCaixa2 = true;
                VisibleCaixa3 = false;

                VisibleDisjuntores1 = true;
                VisibleDisjuntores2 = true;
                VisibleDisjuntores3 = false;
            }

            if (quantidade == "3")
            {
                VisibleCaixa1 = true;
                VisibleCaixa2 = true;
                VisibleCaixa3 = true;

                VisibleDisjuntores1 = true;
                VisibleDisjuntores2 = true;
                VisibleDisjuntores3 = true;
            }
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
        #endregion
    }
}
