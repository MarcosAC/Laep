namespace Laep.Models
{
    public class ValoresDimensionamento
    {
        public string Id { get; set; }
        public string Tensao { get; set; }
        public string QuantidadeCaixa { get; set; }
        public string ModeloCaixa1 { get; set; }
        public string ModeloCaixa2 { get; set; }
        public string ModeloCaixa3 { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ValoresDimensionamento dimensionamento)
            {
                if (Tensao == dimensionamento.Tensao &&
                    QuantidadeCaixa == dimensionamento.QuantidadeCaixa &&
                    ModeloCaixa1 == dimensionamento.ModeloCaixa1 &&
                    ModeloCaixa2 == dimensionamento.ModeloCaixa2 &&
                    ModeloCaixa3 == dimensionamento.ModeloCaixa3)
                {
                    return true;
                }

                return false;
            }
            return false;
            }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
