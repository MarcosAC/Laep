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

                    if (quantidadeDeCaixa == "1")
                    {
                        tipoCaixaAmperDisjuntor = $"{arrayDadosDimensiomanemto[2]} {arrayDadosDimensiomanemto[3]}";

                        RelatorioDimensionamento();

                        return;
                    }

                    if (quantidadeDeCaixa == "2")
                    {
                        tipoCaixaAmperDisjuntor = $"{arrayDadosDimensiomanemto[2]} {arrayDadosDimensiomanemto[4]}, " +
                                                  $"{arrayDadosDimensiomanemto[3]} {arrayDadosDimensiomanemto[5]}";

                        RelatorioDimensionamento();

                        return;
                    }

                    if (quantidadeDeCaixa == "3")
                    {
                        tipoCaixaAmperDisjuntor = $"{arrayDadosDimensiomanemto[2]} {arrayDadosDimensiomanemto[5]}, " +
                                                  $"{arrayDadosDimensiomanemto[3]} {arrayDadosDimensiomanemto[6]}, " +
                                                  $"{arrayDadosDimensiomanemto[4]} {arrayDadosDimensiomanemto[7]}";

                        RelatorioDimensionamento();
                    }                    
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
                        #region Monofasico
                        // Monofasico->40
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A")
                        {
                            valorMultiplex = "Q";
                            valorEntrada = "1";
                            valorFases = "6mm";
                            valorNeutro = "6mm";
                            protecao = "6mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "1";
                            condutorDeAterramento = "10mm";

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

                        // Monofasico->50
                        if (tipoCaixaAmperDisjuntor == "Monofasico 50A")
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

                        // Monofasico->50
                        if (tipoCaixaAmperDisjuntor == "Monofasico 70A")
                        {                            
                            valorEntrada = "1";
                            valorFases = "16mm";
                            valorNeutro = "16mm";
                            protecao = "16mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "1";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo duplex";
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
                        #endregion

                        #region Bifasico
                        // Bifasico->40
                        if (tipoCaixaAmperDisjuntor == "Bifasico 40A")
                        {
                            valorEntrada = "2";
                            valorFases = "10mm";
                            valorNeutro = "10mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "1";
                            condutorDeAterramento = "10mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo triplex";
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

                        if (tipoCaixaAmperDisjuntor == "Bifasico 60A")
                        {
                            valorEntrada = "2";
                            valorFases = "16mm";
                            valorNeutro = "16mm";
                            protecao = "16mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "1";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo triplex";
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
                        #endregion

                        #region Trifasico
                        // Trifasico->60
                        if (tipoCaixaAmperDisjuntor == "Trifasico 60A")
                        {
                            valorEntrada = "3";
                            valorFases = "16mm";
                            valorNeutro = "16mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
                            condutorDeAterramento = "16mm";

                            string ramalDeLigacao = $"Ramal de ligação aereo cabo quadruplex";
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
                        #endregion
                        break;

                    case "2":
                        #region Monofasico
                        // Monofasico->40 40
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A")
                        {
                            valorMultiplex = "T16";
                            valorEntrada = "2";
                            valorFases = "6mm";
                            valorNeutro = "10mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "2";
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

                        // Monofasico->40 50
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 50A" || tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 40A")
                        {
                            valorMultiplex = "T16";
                            valorEntrada = "2";
                            valorFases = "10mm";
                            valorNeutro = "16mm";
                            protecao = "10mm";
                            eletrodutoPcv = "32mm";
                            eletrodutoAco = "25mm";
                            numeroDeEletrodos = "2";
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

                        // Monofasico->40 70
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 70A" || tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 40A")
                        {
                            valorMultiplex = "T16";
                            valorEntrada = "2";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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
                        #endregion

                        #region Bifasico
                        // Bifasico->40 40 - 60 60 | Bifasico->40 60
                        if (tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 40A")
                        {
                            valorMultiplex = "T16";
                            valorEntrada = "2";
                            valorFases = "25mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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

                        // Bifasico->40 60 | Monofasico->70
                        if (//Bifasico->40 60 | Monofasico->70
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 60A" ||
                            //Bifasico->40 | Monofasico->40 50
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 40A" ||
                            //Bifasico->60 | Monofasico->40 50
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 60A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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

                        // Bifasico->40 60 | Monofasico->70
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 70A" || tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 40A")
                        {
                            valorMultiplex = "T16";
                            valorEntrada = "2";
                            valorFases = "16mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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
                        #endregion

                        #region Trifasico
                        // Trifasico->40 40 - 60 60 | Bifasico->40 60
                        if (tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 60A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "2";
                            valorFases = "25mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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

                        // Trifasico->40 40 - 60 60 | Bifasico->40 60
                        if (tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 60A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "2";
                            valorFases = "25mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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

                        // Trifasico->40 60 |Monofasico->70 / Trifasico->40 60 | Monofasico->70
                        if (// Trifasico->40 - 60 | Monofasico->70 
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Trifasico 60A" ||
                            //Trifasico->40 60 | Monofasico->70
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Trifasico 60A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "25mm";
                            valorNeutro = "25mm";
                            protecao = "16mm";
                            eletrodutoPcv = "40mm";
                            eletrodutoAco = "32mm";
                            numeroDeEletrodos = "2";
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
                        #endregion
                        break;

                    case "3":
                        #region Monofasico
                        #region Monofasico->40 40 40 | 50 50 50 | 70 70 70
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A, Monofasico 40A")
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
                        if (tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 50A, Monofasico 50A")
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
                        if (tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 70A, Monofasico 70A")
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
                        #endregion

                        #region Monofasico->40 40 50 | 50 50 40
                        if (tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 50A, Monofasico 40A "||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 50A, Monofasico 40A" || 
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 50A, Monofasico 50A" || 
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 40A, Monofasico 50A")
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
                        #endregion

                        #region Monofasico->40 40 70 | 50 50 70 | 70 70 40
                        if (//40 40 70
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 70A, Monofasico 40A" ||
                            //50 50 70
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 50A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 50A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 70A, Monofasico 50A" ||
                            //70 70 40
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 70A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 70A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 40A, Monofasico 70A ")
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
                        #endregion
                        #endregion                       

                        #region Bifasico->40 40 40 - 60 60 60 / Bifasico->40 40 40 - 60 60 60| Monofasico->40 - 50 |Trifasico->40 - 60
                        if (tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Bifasico 60A" ||
                            //Trifasico->40 | Bifasico->40 | Monofasico->40
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Trifasico 40A, Bifasico 40A" ||
                            //Trifasico->60 | Bifasico->60 | Monofasico->50
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 60A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 50A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 50A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 60A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 60A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Trifasico 60A, Bifasico 60A" ||
                            //Trifasico->40 | Monofasico->70 | Monofasico->70
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 70A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 70A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Trifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 70A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 70A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Trifasico 60A, Monofasico 70A" ||
                            //Trifasico->40 | Monofasico->70 | Monofasico->40
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 70A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 70A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 40A, Trifasico 40A" ||
                            //Trifasico->40 | Monofasico->70 | Monofasico->50
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 70A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 50A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 70A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 50A, Trifasico 40A" ||
                            //Trifasico->60 | Monofasico->70 | Monofasico->40
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 70A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 70A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 40A, Trifasico 60A" ||
                            //Trifasico->60 | Monofasico->70 | Monofasico->50
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 70A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 50A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 70A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 50A, Trifasico 60A")
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
                        #endregion

                        #region Bifasico->40 40 - 60 60 | 40 60 | Monofasico->40 50 70 | 70 70
                        if (//Bifasico->40 40 | Monofasico->40
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 40A, Bifasico 40A" ||
                            //Bifasico->40 40 | Monofasico->50
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 50A, Bifasico 40A" ||
                            //Bifasico->60 60 | Monofasico->40
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 40A, Bifasico 60A" ||
                            //Bifasico->60 60 | Monofasico->50
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 50A, Bifasico 60A" ||
                            //Bifasico->40 40 | Monofasico->70
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 70A, Bifasico 40A" ||
                            //Bifasico->60 60 | Monofasico->50                            
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 70A, Bifasico 60A" ||
                            //Bifasico->40 | Monofasico->70 70)
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 70A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 70A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 40A, Monofasico 70A" ||
                            //Bifasico->60 | Monofasico->70 70))
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 70A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Monofasico 70A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 60A, Monofasico 70A")
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
                        #endregion

                        #region Bifasico->40 60 | Monofasico->40 50
                        if (//Bifasico->40 | Monofasico-> 40 40
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Bifasico 40A, Monofasico 40A" ||
                            //Bifasico->60 | Monofasico->50 50
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 50A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 50A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Bifasico 60A, Monofasico 50A")
                        {
                            valorMultiplex = "Q35";
                            valorEntrada = "3";
                            valorFases = "25mm";
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
                        #endregion

                        #region Trifasico
                        #region Trifasico->40 - 60 | Bifasico->40 40 - 60 60 | Monofasico 70
                        if (//Trifasico->40 | Bifasico->40 40
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 40A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Bifasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 40A, Bifasico 40A" ||
                            //Trifasico->60 | Bifasico->60 60
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 60A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Bifasico 60A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 60A, Bifasico 60A" ||
                            //Trifasico->40 | Bifasico->40 | Monofasico->70
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Bifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 70A, Bifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Monofasico 70A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 40A, Trifasico 40A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Trifasico 40A, Bifasico 40A" ||
                            //Trifasico->60 | Bifasico->60 | Monofasico->70
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Bifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 70A, Bifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Monofasico 70A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Bifasico 60A, Trifasico 60A, Monofasico 70A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Bifasico 60A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 70A, Trifasico 60A, Bifasico 60A")
                        {
                            valorMultiplex = "Q35";
                            valorEntrada = "3";
                            valorFases = "50mm";
                            valorNeutro = "50mm";
                            protecao = "25mm";
                            eletrodutoPcv = "50mm";
                            eletrodutoAco = "40mm";
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
                        #endregion

                        #region Trifasico->40 - 60 | Monofasico->40 - 50 
                        if (//Trifasico->40 | Monofasico->40 40
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Trifasico 40A, Monofasico 40A" ||
                            //Trifasico->40 | Monofasico->50 50
                            tipoCaixaAmperDisjuntor == "Trifasico 40A, Monofasico 50A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 50A, Trifasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Trifasico 40A, Monofasico 50A" ||
                            //Trifasico->60 | Monofasico->40 40
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 40A, Monofasico 40A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Monofasico 40A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 40A, Trifasico 60A, Monofasico 40A" ||
                            //Trifasico->60 | Monofasico->50 50
                            tipoCaixaAmperDisjuntor == "Trifasico 60A, Monofasico 50A, Monofasico 50A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Monofasico 50A, Trifasico 60A" ||
                            tipoCaixaAmperDisjuntor == "Monofasico 50A, Trifasico 60A, Monofasico 50A")
                        {
                            valorMultiplex = "Q16";
                            valorEntrada = "3";
                            valorFases = "25mm";
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
                        #endregion
                        #endregion
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
