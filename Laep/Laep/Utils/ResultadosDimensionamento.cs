using Laep.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laep.Utils
{
    public static class ResultadosDimensionamento
    {
        public static List<Dimensionamento> CM1_1x40;
        public static List<Dimensionamento> CM1_1x50 = new List<Dimensionamento>();
        public static List<Dimensionamento> CM1_1x70 = new List<Dimensionamento>();
        public static List<Dimensionamento> CM2_2x40 = new List<Dimensionamento>();
        public static List<Dimensionamento> CM2_2x60 = new List<Dimensionamento>();
        public static List<Dimensionamento> CM2_3x40 = new List<Dimensionamento>();
        public static List<Dimensionamento> CM2_3x60 = new List<Dimensionamento>();

        static ResultadosDimensionamento()
        {
            CM1_1x40 = new List<Dimensionamento>();

            CM1_1x40.Add(new Dimensionamento
            {
                Tensao = "Sistema Trifásico 127/220V",
                QuantidadeCaixa = "1",
                ModeloCaixa1 = "CM1 disjuntor 1x40"
            });

            //CM1_1x50.Add(new Dimensionamento
            //{
            //    Tensao = "Sistema Trifásico 127/220V",
            //    QuantidadeCaixa = "1",
            //    ModeloCaixa1 = "CM1 disjuntor 1x50"
            //});
        }
    }
}
