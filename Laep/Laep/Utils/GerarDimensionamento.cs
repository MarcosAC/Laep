﻿using Laep.Models;

namespace Laep.Utils
{
    public class GerarDimensionamento
    {
        public static string Dimensionar(ValoresDimensionamento dimensionamento)
        {
            var resultado = new ResultadoDimensionamento();
            var resultadoDimensionamento = string.Empty;

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

                        break;

                    case "2":
                        if (dimensionamento.Equals(dimensionamento))
                        {
                            resultado.ValorMultiplex = "T16";
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "6mm";
                            resultado.ValorNeutro = "10mm";
                            resultado.Protecao = "10mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";

                            return resultadoDimensionamento = $"{resultado.ValorMultiplex}," +
                                                  $"{resultado.ValorEntrada}," +
                                                  $"{resultado.ValorFases}," +
                                                  $"{resultado.ValorNeutro}," +
                                                  $"{resultado.Protecao}," +
                                                  $"{resultado.EletrodutoPcv}," +
                                                  $"{resultado.EletrodutoAco}," +
                                                  $"{resultado.NumeroDeEletrodos}," +
                                                  $"{resultado.CondutorDeAterramento}";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("1", "2")))
                        {
                            resultado.ValorMultiplex = "T16";
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "10mm";
                            resultado.ValorNeutro = "16mm";
                            resultado.Protecao = "10mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";

                            return resultadoDimensionamento = $"{resultado.ValorMultiplex}," +
                                                  $"{resultado.ValorEntrada}," +
                                                  $"{resultado.ValorFases}," +
                                                  $"{resultado.ValorNeutro}," +
                                                  $"{resultado.Protecao}," +
                                                  $"{resultado.EletrodutoPcv}," +
                                                  $"{resultado.EletrodutoAco}," +
                                                  $"{resultado.NumeroDeEletrodos}," +
                                                  $"{resultado.CondutorDeAterramento}";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A, Monofasico 70A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A, Monofasico 70A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 70A, Monofasico 70A", "2")))
                        {
                            resultado.ValorMultiplex = "T16";
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "16mm";
                            resultado.ValorNeutro = "25mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "32mm";
                            resultado.EletrodutoAco = "25mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        //* Verificar se o valor de entrada é 2 ou 3
                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A, Bifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A, Bifasico 60A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A, Bifasico 60A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 70A, Bifasico 40A", "2")))
                        {
                            resultado.ValorMultiplex = "Q16";
                            resultado.ValorEntrada = "3";
                            resultado.ValorFases = "16mm";
                            resultado.ValorNeutro = "25mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A, Monofasico 70A", "2")))
                        {
                            resultado.ValorMultiplex = "T16";
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "16mm";
                            resultado.ValorNeutro = "25mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 40A, Bifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 40A, Bifasico 60A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 60A, Bifasico 60A", "2")))
                        {
                            resultado.ValorMultiplex = "T16";
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "25mm";
                            resultado.ValorNeutro = "25mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 40A, Trifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 40A, Trifasico 60A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 60A, Trifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 60A, Trifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Bifasico 60A, Trifasico 60A", "2")))
                        {
                            resultado.ValorMultiplex = "Q16";
                            resultado.ValorEntrada = "2";
                            resultado.ValorFases = "25mm";
                            resultado.ValorNeutro = "25mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        if (dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A, Trifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 40A, Trifasico 60A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A, Trifasico 40A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 50A, Trifasico 60A", "2")) ||
                            dimensionamento.Equals(VerificarValoresParaGerarDimensionamento.VerificarValores("Monofasico 70A, Trifasico 60A", "2")))
                        {
                            resultado.ValorMultiplex = "Q16";
                            resultado.ValorEntrada = "3";
                            resultado.ValorFases = "25mm";
                            resultado.ValorNeutro = "25mm";
                            resultado.Protecao = "16mm";
                            resultado.EletrodutoPcv = "40mm";
                            resultado.EletrodutoAco = "32mm";
                            resultado.NumeroDeEletrodos = "2";
                            resultado.CondutorDeAterramento = "16mm";
                        }

                        break;

                    case "3":
                        break;
                }

                //return resultadoDimensionamento = $"{resultado.ValorMultiplex}," +
                //                                  $"{resultado.ValorEntrada}," +
                //                                  $"{resultado.ValorFases}," +
                //                                  $"{resultado.ValorNeutro}," +
                //                                  $"{resultado.Protecao}," +
                //                                  $"{resultado.EletrodutoPcv}," +
                //                                  $"{resultado.EletrodutoAco}," +
                //                                  $"{resultado.NumeroDeEletrodos}," +
                //                                  $"{resultado.CondutorDeAterramento}," +
                //                                  $"{resultado.RamalDeLigacao}," +
                //                                  $"{resultado.RamalDeEntrada}," +
                //                                  $"{resultado.ValorFaseNeutro}";
            }

            return null;
        }
    }
}
