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
                    ValorMultiplex = arrayResultadoDimensionamento[0];
                    ValorEntrada = arrayResultadoDimensionamento[1];
                    ValorFases = arrayResultadoDimensionamento[2];
                    ValorNeutro = arrayResultadoDimensionamento[3];
                    Protecao = arrayResultadoDimensionamento[4];
                    EletrodutoPvc = arrayResultadoDimensionamento[5];
                    EletrodutoAco = arrayResultadoDimensionamento[6];
                    NumeroDeEletrodos = arrayResultadoDimensionamento[7];
                    CondutorDeAterramento = arrayResultadoDimensionamento[8];

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

        private string _valorMultiplex;
        public string ValorMultiplex
        {
            get => _valorMultiplex;
            set => SetProperty(ref _valorMultiplex, value);
        }

        private string _valorEntrada;
        public string ValorEntrada
        {
            get => _valorEntrada;
            set => SetProperty(ref _valorEntrada, value);
        }

        private string _valorFases;
        public string ValorFases
        {
            get => _valorFases;
            set => SetProperty(ref _valorFases, value);
        }

        private string _valorNeutro;
        public string ValorNeutro
        {
            get => _valorNeutro;
            set => SetProperty(ref _valorNeutro, value);
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
    }
}
