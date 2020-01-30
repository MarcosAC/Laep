using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    [QueryProperty("Disjuntores", "disjuntores")]
    public class DimensionamentoViewModel : BaseViewModel
    {
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

        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//caracteriscaPadrao");

        private void RelatorioDimensionamento()
        {
            string valorMultiplex = "Q";
            string valorEntrada = "1";
            string valorFases = "10mm";
            string valorNeutro = "10mm";

            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";            

            //if (tipoCaixa1 == "monofasico" && amperDisjuntor1 == "40A")
            //{
            //    RamalLigacao = ramalDeLigacao;
            //    RamalEntrada = ramalDeEntrada;
            //    OnPropertyChanged("RamalLigacao");
            //    OnPropertyChanged("RamalEntrada");
            //}

            if (amperDisjuntor1 == "40A")
            {
                RamalLigacao = ramalDeLigacao;
                RamalEntrada = ramalDeEntrada;
                OnPropertyChanged("RamalLigacao");
                OnPropertyChanged("RamalEntrada");
            }
        }
    }
}
