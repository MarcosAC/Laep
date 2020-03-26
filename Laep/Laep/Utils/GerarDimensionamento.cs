using Laep.Models;

namespace Laep.Utils
{
    public class GerarDimensionamento
    {
        public static string Dimensionar(ValoresDimensionamento dimensionamento)
        {
            var resultado = new ResultadoDimensionamento();

            if (dimensionamento.Tensao == "Sistema Trifásico 127/220V")
            {
                switch (dimensionamento.QuantidadeCaixa)
                {
                    case "1":
                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A", "1")))
                        {
                            resultado.ValorMultiplex = "Q";
                            resultado.ValorEntrada = "1";
                            resultado.ValorFases = "6mm";
                            resultado.ValorNeutro = "6mm";
                            resultado.Protecao = "6mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "1";
                            resultado.CondutorDeAterramento = "10mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A", "1")))
                        {
                            resultado.ValorMultiplex = "Q";
                            resultado.ValorEntrada = "1";
                            resultado.ValorFases = "10mm";
                            resultado.ValorNeutro = "10mm";
                            resultado.Protecao = "10mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "1";
                            resultado.CondutorDeAterramento = "10mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 70A", "1")))
                        {
                            resultado.ValorEntrada = "1";
                            resultado.ValorFases = "16mm";
                            resultado.ValorNeutro = "16mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "1";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 40A", "1")))
                        {
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "10mm";
                            resultado.ValorNeutro = "10mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "1";
                            resultado.CondutorDeAterramento = "10mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 60A", "1")))
                        {
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "16mm";
                            resultado.ValorNeutro = "16mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "1";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Trifasico 40A", "1")))
                        {
                            resultado.ValorEntrada = "3";
                            resultado.ValorFases = "10mm";
                            resultado.ValorNeutro = "10mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Trifasico 60A", "1")))
                        {
                            resultado.ValorEntrada = "3";
                            resultado.ValorFases = "16mm";
                            resultado.ValorNeutro = "16mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

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
