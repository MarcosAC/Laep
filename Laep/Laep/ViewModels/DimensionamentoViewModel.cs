using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    [QueryProperty("Disjuntores", "disjuntores")]
    public class DimensionamentoViewModel : BaseViewModel
    {
        string tensao = string.Empty;

        string amperDisjuntor1 = string.Empty;
        string amperDisjuntor2 = string.Empty;
        string amperDisjuntor3 = string.Empty;

        string tipoCaixa1 = string.Empty;
        string tipoCaixa2 = string.Empty;
        string tipoCaixa3 = string.Empty;

        public string Disjuntores
        {            
            set
            {
                string[] arrayAmperes = Uri.UnescapeDataString(value).Split(',');

                if (arrayAmperes != null)
                {
                    amperDisjuntor1 = arrayAmperes[0];
                    amperDisjuntor2 = arrayAmperes[1];
                    amperDisjuntor3 = arrayAmperes[2];
                    //OnPropertyChanged("Amper");

                    RelatorioDimensionamento();
                }
            }
        }

        //Criar array de Tensão

        //public string TipoCaixa
        //{
        //    set
        //    {
        //        string[] arrayTipoCaixas = Uri.UnescapeDataString(value).Split(',');

        //        if (arrayTipoCaixas != null)
        //        {
        //            tipoCaixa1 = arrayTipoCaixas[0];
        //            tipoCaixa2 = arrayTipoCaixas[1];
        //            tipoCaixa3 = arrayTipoCaixas[2];
        //            //OnPropertyChanged("Amper");
        //        }
        //    }
        //}

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

        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//caracteriscaPadrao");

        private void RelatorioDimensionamento()
        {
            string valorMultiplex = string.Empty;
            string valorEntrada = string.Empty;
            string valorFases = string.Empty;
            string valorNeutro = string.Empty;
            string protecao = string.Empty;
            string eletrodutoPcv = string.Empty;
            string eletrodutoAco = string.Empty;
            string numeroDeEletrodos = string.Empty;
            string condutorDeAterramento = string.Empty;

            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

            if (amperDisjuntor1 == "40A" && tensao == "Sistema Trifásico 127/220")
            {
                valorMultiplex = "Q";
                valorEntrada = "1";
                valorFases = "10mm";
                valorNeutro = "10mm";
                protecao = "10mm";
                eletrodutoPcv = "32mm";
                eletrodutoAco = "25mm";
                numeroDeEletrodos = "1";
                condutorDeAterramento = "10mm";

                RamalLigacao = ramalDeLigacao;
                RamalEntrada = ramalDeEntrada;
                Protecao = protecao;
                EletrodutoPvc = eletrodutoPcv;
                EletrodutoAco = eletrodutoAco;
                NumeroDeEletrodos = numeroDeEletrodos;
                CondutorDeAterramento = condutorDeAterramento;

                OnPropertyChanged("RamalLigacao");
                OnPropertyChanged("RamalEntrada");
                OnPropertyChanged("Protecao");
                OnPropertyChanged("EletrodutoPvc");
                OnPropertyChanged("EletrodutoAco");
                OnPropertyChanged("Eletrodos");
                OnPropertyChanged("Condutor");
            }
        }
    }
}
