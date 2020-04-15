using Realms;

namespace Laep.Models
{
    public class ResultadoDimensionamento : RealmObject
    {
        public string Id { get; set; }
        public string Tensao { get; set; }
        public string QuantidadeCaixa { get; set; }
        public string ModeloCaixa1 { get; set; }
        public string ModeloCaixa2 { get; set; }
        public string ModeloCaixa3 { get; set; }
        public string ValorMultiplex { get; set; }
        public string ValorEntrada { get; set; }
        public string ValorFases { get; set; }
        public string ValorNeutro { get; set; }
        public string Protecao { get; set; }
        public string EletrodutoPcv { get; set; }
        public string EletrodutoAco { get; set; }
        public string NumeroDeEletrodos { get; set; }
        public string CondutorDeAterramento { get; set; }
    }
}
