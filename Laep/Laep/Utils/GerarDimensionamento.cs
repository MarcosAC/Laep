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
                                CondutorDeAterramento = "10mm"
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

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A", "1")))
                        {
                            var resultado = new ResultadoDimensionamento
                            {
                                ValorMultiplex = "Q",
                                ValorEntrada = "1",
                                ValorFases = "10mm",
                                ValorNeutro = "10mm",
                                Protecao = "10mm",
                                EletrodutoPcv = "32mm",
                                EletrodutoAco = "25mm",
                                NumeroDeEletrodos = "1",
                                CondutorDeAterramento = "10mm"
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
