using Laep.Models;
using Laep.Utils;
using Laep.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    public class CaracteristicaPadraoViewModel : BaseViewModel
    { 
        public List<string> ListaQuantidadeCaixas { get; } = new List<string> { "1", "2", "3" };
        public List<string> ListaTensao { get; } = new List<string> { "Sistema Trifásico 127/220V", "Sistema Monofásico 120/240V" };
        //readonly List<string> ListaDisjuntores = new List<string>();

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

        private string _tensaoSelecionada;
        public string TensaoSelecionada
        {
            get => _tensaoSelecionada;
            set
            {
                SetProperty(ref _tensaoSelecionada, value);
                CarregarModeloCaixa( _tensaoSelecionada);
            }
        }

        private List<string> _modeloCaixas;
        public List<string> ModeloCaixas
        {
            get => _modeloCaixas;
            set => SetProperty(ref _modeloCaixas, value);
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
            }
        }

        private string _modeloCaixaSelecionado2;
        public string ModeloCaixaSelecionado2
        {
            get => _modeloCaixaSelecionado2;
            set
            {
                SetProperty(ref _modeloCaixaSelecionado2, value);
            }
        }

        private string _modeloCaixaSelecionado3;
        public string ModeloCaixaSelecionado3
        {
            get => _modeloCaixaSelecionado3;
            set
            {
                SetProperty(ref _modeloCaixaSelecionado3, value);
            }
        }        
        #endregion

        #region Commands
        private Command _dimensionamentoCommand;
        public Command DimensionamentoCommand =>
            _dimensionamentoCommand ?? (_dimensionamentoCommand = new Command(async () => await ExecuteDimensionamentoCommand()));

        private async Task ExecuteDimensionamentoCommand()
        {
            string recebeDadosDimensionamento = string.Empty;

            if (QuantidadeCaixaSelecionado == "1")
            {
                recebeDadosDimensionamento = $"{TensaoSelecionada}," +
                                             $"{QuantidadeCaixaSelecionado}," +
                                             $"{ModeloCaixaSelecionado1}";
            }

            if (QuantidadeCaixaSelecionado == "2")
            {
                recebeDadosDimensionamento = $"{TensaoSelecionada}," +
                                             $"{QuantidadeCaixaSelecionado}," +
                                             $"{ModeloCaixaSelecionado1}," +
                                             $"{ModeloCaixaSelecionado2}";
            }

            if (QuantidadeCaixaSelecionado == "3")
            {
                recebeDadosDimensionamento = $"{TensaoSelecionada}," +
                                             $"{QuantidadeCaixaSelecionado}," +
                                             $"{ModeloCaixaSelecionado1}," +
                                             $"{ModeloCaixaSelecionado2}," +
                                             $"{ModeloCaixaSelecionado3}";
            }            

            string[] arrayDadosDimensiomanemto = recebeDadosDimensionamento.Split(',');

            foreach (var item in arrayDadosDimensiomanemto)
            {
                if (string.IsNullOrEmpty(item))
                {
                    await Application.Current.MainPage.DisplayAlert("Alerta", "Preencher todos os campos.", "Ok");
                    return;
                }
            }

            List<string> listaDadosDimensionamento = new List<string>();

            foreach (var item in arrayDadosDimensiomanemto)
            {
                listaDadosDimensionamento.Add(item);
            }

            var resultado = listaDadosDimensionamento.FindAll(d => d.Contains("3x"));

            if (resultado.Count > 1)
            {
                await Application.Current.MainPage.DisplayAlert("Observação", "Só é possivel inserir 1 caixa trifásica em um conjunto de 2 ou 3 caixas!", "Ok");
                return;
            }

            var dadosDimensionamento = new ValoresDimensionamento
            {
                Tensao = TensaoSelecionada,
                QuantidadeCaixa = QuantidadeCaixaSelecionado,
                ModeloCaixa1 = ModeloCaixaSelecionado1,
                ModeloCaixa2 = ModeloCaixaSelecionado2,
                ModeloCaixa3 = ModeloCaixaSelecionado3
            };

            string resultadoDimensionamento = GerarDimensionamento.Dimensionar(dadosDimensionamento);

            await Shell.Current.GoToAsync($"//dimensionamento?resultadoDimensionamento={resultadoDimensionamento}");
        }

        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//paginaInicial");

        private Command _RefreshCommand;

        public Command RefreshCommand => _RefreshCommand ?? (_RefreshCommand = new Command(() => RefreshCommandExecute()));

        private void RefreshCommandExecute()
        {
            RefreshCommand.ChangeCanExecute();
        }

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

        private void CarregarModeloCaixa(string modelo)
        {   
            if (modelo == "Sistema Monofásico 120/240V")
            {
                if (ModeloCaixas != null || ModeloCaixas == null)
                {
                    ModeloCaixas = null;

                    List<string> ListaModelosCaixas = new List<string>
                    {
                        "CM1 disjuntor 1x40",
                        "CM1 disjuntor 1x50",
                        "CM1 disjuntor 1x60",
                        "CM2 disjuntor 2x40",
                        "CM2 disjuntor 2x60"
                    };

                    ModeloCaixas = ListaModelosCaixas;
                }
            }                

            if (modelo == "Sistema Trifásico 127/220V")
            {
                if (ModeloCaixas != null || ModeloCaixas == null)
                {
                    if (ModeloCaixas != null)
                        ModeloCaixas = null;

                    List<string> ListaModelosCaixas = new List<string>
                    {
                        "CM1 disjuntor 1x40",
                        "CM1 disjuntor 1x50",
                        "CM1 disjuntor 1x60",
                        "CM2 disjuntor 2x40",
                        "CM2 disjuntor 2x60",
                        "CM2 disjuntor 3x40",
                        "CM2 disjuntor 3x60"
                    };

                    ModeloCaixas = ListaModelosCaixas;
                }
            }                
        }
        #endregion
    }
}
