using Laep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laep.Utils
{
    public class GerarDimensionamento
    {

        public string Tensao { get; set; }
        public List<string> ListaModeloCaixa { get; set; }

        public void Dimensionar(List<string> modeloCaixaSelecionado)
        {
            foreach (var item in modeloCaixaSelecionado)
            {
                var teste = new ModeloCaixaSelecionada
                {
                    Caixa1 = item[0].ToString(),
                    Caixa2 = item[1].ToString(),
                    Caixa3 = item[0].ToString(),
                };                    
            }
        }
    }
}
