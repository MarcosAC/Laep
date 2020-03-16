using Laep.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laep.Utils
{
    public class DadosParaGerarDimensionamento
    {
        public static Dimensionamento Resultados(string id, string quantidadeCaixa)
        {
            List<Dimensionamento> lista = new List<Dimensionamento>();

            switch (quantidadeCaixa)
            {
                case "1":
                    lista = new List<Dimensionamento>
                    {
                        new Dimensionamento
                        {
                            Id = "Monofasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 50A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x50"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 70A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x70"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 60A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x60"
                        },

                        new Dimensionamento
                        {
                            Id = "Trifasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 3x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Trifasico 60A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM3 disjuntor 1x60"
                        }
                    };
                    break;
                case "2":
                    lista = new List<Dimensionamento>
                    {
                        new Dimensionamento
                        {
                            Id = "Monofasico 40A, Monofasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x40",
                            ModeloCaixa2 = "CM1 disjuntor 1x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 40A, Monofasico 50A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x40",
                            ModeloCaixa2 = "CM1 disjuntor 1x50"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 40A, Monofasico 70A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x40",
                            ModeloCaixa2 = "CM1 disjuntor 1x70"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 50A, Monofasico 50A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x50",
                            ModeloCaixa2 = "CM1 disjuntor 1x70"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 50A, Monofasico 70A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x50",
                            ModeloCaixa2 = "CM1 disjuntor 1x70"
                        },

                        new Dimensionamento
                        {
                            Id = "Monofasico 70A, Monofasico 70A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM1 disjuntor 1x70",
                            ModeloCaixa2 = "CM1 disjuntor 1x70"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 40A, Bifasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x40",
                            ModeloCaixa2 = "CM2 disjuntor 2x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 40A, Bifasico 60A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 1x40",
                            ModeloCaixa2 = "CM2 disjuntor 1x60"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 60A, Bifasico 60A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x60",
                            ModeloCaixa2 = "CM2 disjuntor 2x60"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 40A, Monofasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x40",
                            ModeloCaixa2 = "CM1 disjuntor 1x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 40A, Monofasico 50A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x40",
                            ModeloCaixa2 = "CM1 disjuntor 1x50"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 40A, Monofasico 70A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x40",
                            ModeloCaixa2 = "CM1 disjuntor 1x70"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 60A, Monofasico 40A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x60",
                            ModeloCaixa2 = "CM1 disjuntor1x70 1x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 60A, Monofasico 50A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x60",
                            ModeloCaixa2 = "CM1 disjuntor1x70 1x40"
                        },

                        new Dimensionamento
                        {
                            Id = "Bifasico 60A, Monofasico 70A",
                            Tensao = "Sistema Trifásico 127/220V",
                            QuantidadeCaixa = "1",
                            ModeloCaixa1 = "CM2 disjuntor 2x60",
                            ModeloCaixa2 = "CM1 disjuntor1x70 1x70"
                        }

                    };
                    break;
                case "3":
                    break;
            }

            List<Dimensionamento> listaDadosParaDimensionamento = new List<Dimensionamento>();

            foreach (var item in lista)
            {
                listaDadosParaDimensionamento.Add(item);
            }

            var dadosParaDimensioanemnto = listaDadosParaDimensionamento.Find(r => r.Id.Contains(id));

            return dadosParaDimensioanemnto;
        }
    }
}
