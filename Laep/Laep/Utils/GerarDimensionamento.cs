using Laep.Models;
using System.Collections.Generic;
using System.Linq;

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

            string id = string.Empty;

            var lista = new List<Dimensionamento>();

            if (dimensionamento.Tensao == "Sistema Trifásico 127/220V")
            {
                switch (dimensionamento.QuantidadeCaixa)
                {
                    case "1":
                        if (dimensionamento.Equals(ResultadosDimensionamento.Resultados("1")))
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

                        if (dimensionamento.Equals(ResultadosDimensionamento.Resultados("2")))
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
