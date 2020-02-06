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
        string amperDisjuntor = string.Empty;
        string tipoCaixaAmperDisjuntor = string.Empty;

        public string DadosDimensionamento
        {            
            set
            {
                string[] arrayDadosDimensiomanemto = Uri.UnescapeDataString(value).Split(',');

                if (arrayDadosDimensiomanemto != null)
                {
                    tensao = arrayDadosDimensiomanemto[0];
                    quantidadeDeCaixa = arrayDadosDimensiomanemto[1];
                    tipoCaixaAmperDisjuntor = $"{arrayDadosDimensiomanemto[2]} {arrayDadosDimensiomanemto[5]}, " +
                                $"{arrayDadosDimensiomanemto[3]} {arrayDadosDimensiomanemto[6]}, " +
                                $"{arrayDadosDimensiomanemto[4]} {arrayDadosDimensiomanemto[6]}";
                    amperDisjuntor = $"{arrayDadosDimensiomanemto[5]}, {arrayDadosDimensiomanemto[6]}, {arrayDadosDimensiomanemto[7]}";

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
                        if (amperDisjuntor == "40A, 40A, 40A")
                        {
                        }
                        break;

                    case "2":
                        if (amperDisjuntor == "40A, 40A, 40A")
                        {
                        }
                        break;

                    case "3":
                        switch (tipoCaixaAmperDisjuntor)
                        {
                            case "Monofasico, Monofasico, Monofasico":
                                if (amperDisjuntor == "40A, 40A, 40A")
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
                                if (amperDisjuntor == "50A, 50A, 50A")
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
                                if (amperDisjuntor == "70A, 70A, 70A")
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
                                if (amperDisjuntor == "40A, 40A, 50A" || amperDisjuntor == "50A, 40A, 40A" || amperDisjuntor == "40A, 50A, 40A ")
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
                                if (amperDisjuntor == "50A, 50A, 40A" || amperDisjuntor == "40A, 50A, 50A" || amperDisjuntor == "50A, 40A, 50A ")
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
                                if (amperDisjuntor == "40A, 40A, 70A" || amperDisjuntor == "70A, 40A, 40A" || amperDisjuntor == "40A, 70A, 40A ")
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
                                if (amperDisjuntor == "50A, 50A, 70A" || amperDisjuntor == "70A, 50A, 50A" || amperDisjuntor == "50A, 70A, 50A ")
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
                                if (amperDisjuntor == "70A, 70A, 40A" || amperDisjuntor == "40A, 70A, 70A" || amperDisjuntor == "70A, 40A, 70A ")
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

                            case "Bifasico, Bifasico, Bifasico":
                                if (amperDisjuntor == "40A, 40A, 40A" || amperDisjuntor == "60A, 60A, 60A")
                                {
                                    valorMultiplex = "Q35";
                                    valorEntrada = "3";
                                    valorFases = "35mm";
                                    valorNeutro = "35mm";
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

                        if (//Bipolar->40 60 mono->40 50
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 50A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 50A, Bifasico 60A" ||
                            //Bipolar->40 mono->60 70
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 70A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 70A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 70A, Bifasico 60A")
                            {
                                valorMultiplex = "Q35";
                                valorEntrada = "3";
                                valorFases = "35mm";
                                valorNeutro = "35mm";
                                protecao = "35mm";
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
