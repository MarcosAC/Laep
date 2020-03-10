using System;
using System.Collections.Generic;
using System.Text;

namespace Laep.Models
{
    public class Dimensionamento
    {       
        public string ValorMultiplex { get; set; }
        public string ValorEntrada { get; set; }
        public string ValorFases { get; set; }
        public string ValorNeutro { get; set; }
        public string Protecao { get; set; }
        public string EletrodutoPcv { get; set; }
        public string EletrodutoAco { get; set; }
        public string NumeroDeEletrodos { get; set; }
        public string CondutorDeAterramento { get; set; }
        public string Tensao{ get; set; }
    }
}
