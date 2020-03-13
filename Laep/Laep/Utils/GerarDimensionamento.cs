using Laep.Models;
using System.Collections.Generic;

namespace Laep.Utils
{
    public class GerarDimensionamento
    {

        public string Tensao { get; set; }
        public List<string> ListaModeloCaixa { get; set; }

        public static void Dimensionar(Dimensionamento dimensionamento)
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

            var dadosDimencionamento = dimensionamento;

            Dimensionamento teste = new Dimensionamento
            {
                Tensao = "Sistema Trifásico 127/220V",
                QuantidadeCaixa = "1",
                ModeloCaixa1 = "CM1 disjuntor 1x40"
            };

            Dimensionamento teste2 = new Dimensionamento
            {
                Tensao = "Sistema Trifásico 127/220V",
                QuantidadeCaixa = "1",
                ModeloCaixa1 = "CM1 disjuntor 1x50"
            };

            if (dimensionamento.Tensao == "Sistema Trifásico 127/220V")
            {
                switch (dimensionamento.QuantidadeCaixa)
                {
                    case "1":
                        if (dimensionamento.Equals(teste))
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

                            string ramalDeLigacao = valorMultiplex;
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de";
                            string valorFaseNeutro = $"{valorFases} e um neutro de {valorNeutro}";

                            return;
                        }

                        if (dadosDimencionamento.Equals(teste2))
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

                            string ramalDeLigacao = valorMultiplex;
                            string ramalDeEntrada = $"Ramal de entrada {valorEntrada} fase/s de";
                            string valorFaseNeutro = $"{valorFases} e um neutro de {valorNeutro}";

                            return;
                        }
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                        
                }
            }
        }
    }
}
