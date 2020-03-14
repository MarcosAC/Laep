using Laep.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laep.Utils
{
    public static class ResultadosDimensionamento
    {  
        public static Dimensionamento Resultados(string id)
        {
            List<Dimensionamento> lista;

            lista = new List<Dimensionamento>
            {
                new Dimensionamento
                {
                    Id = "1",
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM1 disjuntor 1x40"
                },

                new Dimensionamento
                {
                    Id = "2",
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM1 disjuntor 1x50"
                }
            };

            List<Dimensionamento> listaResultados = new List<Dimensionamento>();

            foreach (var item in lista)
            {
                listaResultados.Add(item);
            }

            var resultado = listaResultados.Find(r => r.Id.Contains(id));

            return resultado;
        }
    }
}
