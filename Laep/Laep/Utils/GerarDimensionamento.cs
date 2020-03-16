using Laep.Models;
using System.Collections.Generic;

namespace Laep.Utils
{
    public class GerarDimensionamento
    {

        public string Tensao { get; set; }
        public List<string> ListaModeloCaixa { get; set; }

        public static string Dimensionar(ValoresDimensionamento dimensionamento)
        {
            string id = string.Empty;

            var lista = new List<ValoresDimensionamento>();

            if (dimensionamento.Tensao == "Sistema Trifásico 127/220V")
            {
                switch (dimensionamento.QuantidadeCaixa)
                {
                    case "1":
                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A", "1")))
                        {
                            var valoresDimensionamento = new ResultadoDimensionamento
                            {
                                ValorMultiplex = "Q",
                                ValorEntrada = "1",
                                ValorFases = "6mm",
                                ValorNeutro = "6mm"
                            };

                            string ramalDeLigacao = valoresDimensionamento.ValorMultiplex;
                            string ramalDeEntrada = $"Ramal de entrada {valoresDimensionamento.ValorEntrada} fase/s de";
                            string valorFaseNeutro = $"{valoresDimensionamento.ValorFases} e um neutro de {valoresDimensionamento.ValorNeutro}";

                            var resultado = new ResultadoDimensionamento
                            {
                                ValorMultiplex = "Q",
                                ValorEntrada = "1",
                                ValorFases = "6mm",
                                ValorNeutro = "6mm",
                                Protecao = "6mm",
                                EletrodutoPcv = "32mm",
                                EletrodutoAco = "25mm",
                                NumeroDeEletrodos = "1",
                                CondutorDeAterramento = "10mm",
                                RamalDeLigacao = ramalDeLigacao,
                                RamalDeEntrada = ramalDeEntrada,
                                ValorFaseNeutro = valorFaseNeutro,
                            };                           

                            string resultadoDimensionamento = $"{resultado.ValorMultiplex}," +
                                                              $"{resultado.ValorEntrada}," +
                                                              $"{resultado.ValorFases}," +
                                                              $"{resultado.ValorNeutro}," +
                                                              $"{resultado.Protecao}," +
                                                              $"{resultado.EletrodutoPcv}," +
                                                              $"{resultado.EletrodutoAco}," +
                                                              $"{resultado.NumeroDeEletrodos}," +
                                                              $"{resultado.CondutorDeAterramento}," +
                                                              $"{resultado.RamalDeLigacao}," +
                                                              $"{resultado.RamalDeEntrada}," +
                                                              $"{resultado.ValorFaseNeutro}";

                            return resultadoDimensionamento;
                        }

                        //if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A", "2")))
                        //{
                        //    valorMultiplex = "Q";
                        //    valorEntrada = "1";
                        //    valorFases = "10mm";
                        //    valorNeutro = "10mm";
                        //    protecao = "10mm";
                        //    eletrodutoPcv = "32mm";
                        //    eletrodutoAco = "25mm";
                        //    numeroDeEletrodos = "1";
                        //    condutorDeAterramento = "10mm";

                        //    string ramalDeLigacao = valorMultiplex;
                        //    string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de";
                        //    string valorFaseNeutro = $"{valorFases} e um neutro de {valorNeutro}";

                        //    return;
                        //}
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            }

            return null;
        }
    }
}
