using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    [QueryProperty("DadosDimensionamento", "dadosDimensionamento")]
    public class DimensionamentoViewModel : BaseViewModel
    {
        string tensao = string.Empty;

        string quantidadeDeCaixa = string.Empty;

        string amperDisjuntor1 = string.Empty;
        string amperDisjuntor2 = string.Empty;
        string amperDisjuntor3 = string.Empty;

        string tipoCaixa1 = string.Empty;
        string tipoCaixa2 = string.Empty;
        string tipoCaixa3 = string.Empty;

        public string DadosDimensionamento
        {            
            set
            {
                string[] arrayDadosDimensiomanemto = Uri.UnescapeDataString(value).Split(',');

                if (arrayDadosDimensiomanemto != null)
                {
                    tensao = arrayDadosDimensiomanemto[0];
                    quantidadeDeCaixa = arrayDadosDimensiomanemto[1];
                    tipoCaixa1 = arrayDadosDimensiomanemto[2];
                    tipoCaixa2 = arrayDadosDimensiomanemto[3];
                    tipoCaixa2 = arrayDadosDimensiomanemto[4];
                    amperDisjuntor1 = arrayDadosDimensiomanemto[5];
                    amperDisjuntor2 = arrayDadosDimensiomanemto[6];
                    amperDisjuntor3 = arrayDadosDimensiomanemto[7];                                 

                    RelatorioDimensionamento();
                }
            }
        }

        #region Propriedades
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
        #endregion

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

            if (tensao == "Sistema Trifásico 127/220V")
            {
                switch (quantidadeDeCaixa)
                {
                    case "1":
                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "40A" &&
                            amperDisjuntor2 == "40A" &&
                            amperDisjuntor3 == "40A")
                        {
                        }
                        break;

                    case "2":
                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "40A" &&
                            amperDisjuntor2 == "40A" &&
                            amperDisjuntor3 == "40A")
                        {
                        }
                        break;

                    case "3":
                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "40A" &&
                            amperDisjuntor2 == "40A" &&
                            amperDisjuntor3 == "40A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "6mm";
                            valorNeutro = "10mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }                        
                        
                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "50A" &&
                            amperDisjuntor2 == "50A" &&
                            amperDisjuntor3 == "50A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "10mm";
                            valorNeutro = "16mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }                        
                       
                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "70A" &&
                            amperDisjuntor2 == "70A" &&
                            amperDisjuntor3 == "70A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }

                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "40A" &&
                            amperDisjuntor2 == "40A" &&
                            amperDisjuntor3 == "50A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "10mm";
                            valorNeutro = "16mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }

                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "50A" &&
                            amperDisjuntor2 == "50A" &&
                            amperDisjuntor3 == "40A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "10mm";
                            valorNeutro = "16mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }

                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "40A" &&
                            amperDisjuntor2 == "40A" &&
                            amperDisjuntor3 == "70A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }

                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "50A" &&
                            amperDisjuntor2 == "50A" &&
                            amperDisjuntor3 == "70A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }

                        if (tipoCaixa1 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            tipoCaixa2 == "Monofasico" &&
                            amperDisjuntor1 == "70A" &&
                            amperDisjuntor2 == "70A" &&
                            amperDisjuntor3 == "40A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "3";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                            RamalLigacao = ramalDeLigacao;
                            RamalEntrada = ramalDeEntrada;
                            Protecao = protecao;
                            EletrodutoPvc = eletrodutoPcv;
                            EletrodutoAco = eletrodutoAco;
                            NumeroDeEletrodos = numeroDeEletrodos;
                            CondutorDeAterramento = condutorDeAterramento;

                            return;
                        }
                        break;
                }
            }

            if (tensao == "Sistema Monofásico 120/240V")
            {
                //if (quantidadeDeCaixa == "1" &&
                //    tipoCaixa1 == "Monofasico" &&
                //    tipoCaixa2 == "Monofasico" &&
                //    tipoCaixa2 == "Monofasico" &&
                //    amperDisjuntor1 == "40A" &&
                //    amperDisjuntor2 == "40A" &&
                //    amperDisjuntor3 == "40A")
                //{

                //}

                //if (quantidadeDeCaixa == "2" &&
                //    tipoCaixa1 == "Monofasico" &&
                //    tipoCaixa2 == "Monofasico" &&
                //    tipoCaixa2 == "Monofasico" &&
                //    amperDisjuntor1 == "40A" &&
                //    amperDisjuntor2 == "40A" &&
                //    amperDisjuntor3 == "40A")
                //{

                //}

                //if (quantidadeDeCaixa == "3" &&
                //    tipoCaixa1 == "Monofasico" &&
                //    tipoCaixa2 == "Monofasico" &&
                //    tipoCaixa2 == "Monofasico" &&
                //    amperDisjuntor1 == "40A" &&
                //    amperDisjuntor2 == "40A" &&
                //    amperDisjuntor3 == "40A")
                //{
                //    valorMultiplex = "Q16";
                //    valorEntrada = "3";
                //    valorFases = "6mm";
                //    valorNeutro = "10mm";
                //    protecao = "10mm";
                //    eletrodutoPcv = "32mm";
                //    eletrodutoAco = "25mm";
                //    numeroDeEletrodos = "3";
                //    condutorDeAterramento = "16mm";

                //    string ramalDeLigacao = $"Ramal de ligação aereo cabo multiplex {valorMultiplex}";
                //    string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de {valorFases} e um neutro de {valorNeutro}";

                //    RamalLigacao = ramalDeLigacao;
                //    RamalEntrada = ramalDeEntrada;
                //    Protecao = protecao;
                //    EletrodutoPvc = eletrodutoPcv;
                //    EletrodutoAco = eletrodutoAco;
                //    NumeroDeEletrodos = numeroDeEletrodos;
                //    CondutorDeAterramento = condutorDeAterramento;

                //    OnPropertyChanged("RamalLigacao");
                //    OnPropertyChanged("RamalEntrada");
                //    OnPropertyChanged("Protecao");
                //    OnPropertyChanged("EletrodutoPvc");
                //    OnPropertyChanged("EletrodutoAco");
                //    OnPropertyChanged("Eletrodos");
                //    OnPropertyChanged("Condutor");
                //}
            }
        }
    }
}
