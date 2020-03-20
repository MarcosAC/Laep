namespace Laep.Models
{
    public class ResultadoDimensionamento
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
        public string RamalDeLigacao { get { return ValorMultiplex; } set => RamalDeLigacao = value; }
        public string RamalDeEntrada { get { return $"Ramal de entrada {ValorEntrada} fase/s de"; } set => RamalDeEntrada = value; }
        public string ValorFaseNeutro { get { return $"{ValorFases} e um neutro de {ValorNeutro}"; } set => ValorFaseNeutro = value; }
    }
}
