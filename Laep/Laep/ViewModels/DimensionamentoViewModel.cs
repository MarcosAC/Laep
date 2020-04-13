using Laep.Models;
using Laep.Utils;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    [QueryProperty("ResultadoDimensionamento", "resultadoDimensionamento")]
    public class DimensionamentoViewModel : BaseViewModel
    {
        public string ResultadoDimensionamento
        {            
            set
            {
                var arrayResultadoDimensionamento = Uri.UnescapeDataString(value).Split(',');

                if (arrayResultadoDimensionamento != null)
                { 
                    ValorFaseNeutro = arrayResultadoDimensionamento[3];
                    Protecao = arrayResultadoDimensionamento[4];
                    EletrodutoPvc = arrayResultadoDimensionamento[5];
                    EletrodutoAco = arrayResultadoDimensionamento[6];
                    NumeroDeEletrodos = arrayResultadoDimensionamento[7];
                    CondutorDeAterramento = arrayResultadoDimensionamento[8];
                    RamalLigacao = arrayResultadoDimensionamento[9];
                    RamalEntrada = arrayResultadoDimensionamento[10];
                    ValorFaseNeutro = arrayResultadoDimensionamento[11];

                    IsVisible("Grid");
                }
                else
                {
                    IsVisible("Label");
                }
            }
        }

        #region Propriedades
        private bool _visibleLabel = false;
        public bool VisibleLabel
        {
            get => _visibleLabel;
            set => SetProperty(ref _visibleLabel, value);
        }

        private bool _visibleGrid = false;
        public bool VisibleGrid
        {
            get => _visibleGrid;
            set => SetProperty(ref _visibleGrid, value);
        }

        private string _ramalLigacao;
        public string RamalLigacao
        {
            get => _ramalLigacao;
            set => SetProperty(ref _ramalLigacao, value);
        }

        private string _ramalEntrada;
        public string RamalEntrada
        {
            get => _ramalEntrada;
            set => SetProperty(ref _ramalEntrada, value);
        }

        private string _valorFaseNeutro;
        public string ValorFaseNeutro
        {
            get => _valorFaseNeutro;
            set => SetProperty(ref _valorFaseNeutro, value);
        }

        private string _protecao;
        public string Protecao
        {
            get => _protecao;
            set => SetProperty(ref _protecao, value);
        }

        private string _eletrodutoPvc;
        public string EletrodutoPvc
        {
            get => _eletrodutoPvc;
            set => SetProperty(ref _eletrodutoPvc, value);
        }

        private string _eletrodutoAco;
        public string EletrodutoAco
        {
            get => _eletrodutoAco;
            set => SetProperty(ref _eletrodutoAco, value);
        }

        private string _numeroDeEletrodos;
        public string NumeroDeEletrodos
        {
            get => _numeroDeEletrodos;
            set => SetProperty(ref _numeroDeEletrodos, value);
        }

        private string _condutorDeAterramento;
        public string CondutorDeAterramento
        {
            get => _condutorDeAterramento;
            set => SetProperty(ref _condutorDeAterramento, value);
        }
        #endregion

        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//caracteriscaPadrao");

        #region Métodos
        private void RelatorioDimensionamento(ValoresDimensionamento valoresDimensionamento)
        {
            //var valores = valoresDimensionamento;

            //GerarDimensionamento.Dimensionar(valores);
        }
       
        private void IsVisible(string controle)
        {
            if (controle == "Grid")
            {
                VisibleGrid = true;
                VisibleLabel = false;
            }
            else if (controle == "Label")
            {
                VisibleGrid = false;
                VisibleLabel = true;
            }
        }
        #endregion
    }
}
