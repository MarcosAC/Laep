using Laep.Models;
using Realms;

namespace Laep.Data
{
    public class DataResultadosDimensionamentos
    {
        Realm realm = Realm.GetInstance();

        public void Insert()
        {
            realm.Write(() =>
            {
                #region 1 Caixa
                #region Monofasico
                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM1 disjuntor 1x40",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q",
                    ValorEntrada = "1",
                    ValorFases = "6mm",
                    ValorNeutro = "6mm",
                    Protecao = "6mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "1",
                    CondutorDeAterramento = "10mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM1 disjuntor 1x50",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q",
                    ValorEntrada = "1",
                    ValorFases = "10mm",
                    ValorNeutro = "10mm",
                    Protecao = "10mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "1",
                    CondutorDeAterramento = "10mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM1 disjuntor 1x70",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "",
                    ValorEntrada = "1",
                    ValorFases = "16mm",
                    ValorNeutro = "16mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "1",
                    CondutorDeAterramento = "16mm",
                });
                #endregion

                #region Bifasico
                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x40",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "",
                    ValorEntrada = "1",
                    ValorFases = "10mm",
                    ValorNeutro = "10mm",
                    Protecao = "10mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "1",
                    CondutorDeAterramento = "10mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM2 disjuntor 2x60",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "",
                    ValorEntrada = "2",
                    ValorFases = "16mm",
                    ValorNeutro = "16mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "1",
                    CondutorDeAterramento = "16mm",
                });
                #endregion

                #region Trifasico
                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM2 disjuntor 3x40",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "",
                    ValorEntrada = "3",
                    ValorFases = "10mm",
                    ValorNeutro = "10mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "1",
                    ModeloCaixa1 = "CM2 disjuntor 3x60",
                    ModeloCaixa2 = "",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "16mm",
                    Protecao = "16mm40mm",
                    EletrodutoPcv = "40mm32mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });
                #endregion
                #endregion

                #region 2 Caixas
                #region Monofasico
                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM1 disjuntor 1x40",
                    ModeloCaixa2 = "CM1 disjuntor 1x40",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "6mm",
                    ValorNeutro = "10mm",
                    Protecao = "10mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM1 disjuntor 1x40",
                    ModeloCaixa2 = "CM1 disjuntor 1x50",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "10mm",
                    ValorNeutro = "16mm",
                    Protecao = "10mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM1 disjuntor 1x40",
                    ModeloCaixa2 = "CM1 disjuntor 1x70",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM1 disjuntor 1x50",
                    ModeloCaixa2 = "CM1 disjuntor 1x70",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM1 disjuntor 1x70",
                    ModeloCaixa2 = "CM1 disjuntor 1x70",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "32mm",
                    EletrodutoAco = "25mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });
                #endregion

                #region Bifasico
                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x40",
                    ModeloCaixa2 = "CM2 disjuntor 2x40",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x40",
                    ModeloCaixa2 = "CM2 disjuntor 2x60",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x60",
                    ModeloCaixa2 = "CM2 disjuntor 2x60",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "T16",
                    ValorEntrada = "2",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x40",
                    ModeloCaixa2 = "CM1 disjuntor 1x40",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x40",
                    ModeloCaixa2 = "CM1 disjuntor 1x50",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x40",
                    ModeloCaixa2 = "CM1 disjuntor 1x70",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x60",
                    ModeloCaixa2 = "CM1 disjuntor 1x40",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x60",
                    ModeloCaixa2 = "CM1 disjuntor 1x50",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 2x60",
                    ModeloCaixa2 = "CM1 disjuntor 1x70",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "16mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });
                #endregion

                #region Trifasico
                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 3x40",
                    ModeloCaixa2 = "M1 disjuntor 1x40",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 3x40",
                    ModeloCaixa2 = "M1 disjuntor 1x50",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 3x40",
                    ModeloCaixa2 = "M1 disjuntor 1x70",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 3x60",
                    ModeloCaixa2 = "M1 disjuntor 1x40",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });

                realm.Add(new ResultadoDimensionamento
                {
                    Tensao = "Sistema Trifásico 127/220V",
                    QuantidadeCaixa = "2",
                    ModeloCaixa1 = "CM2 disjuntor 3x60",
                    ModeloCaixa2 = "M1 disjuntor 1x50",
                    ModeloCaixa3 = "",
                    ValorMultiplex = "Q16",
                    ValorEntrada = "3",
                    ValorFases = "25mm",
                    ValorNeutro = "25mm",
                    Protecao = "16mm",
                    EletrodutoPcv = "40mm",
                    EletrodutoAco = "32mm",
                    NumeroDeEletrodos = "2",
                    CondutorDeAterramento = "16mm",
                });
                #endregion
                #endregion

                #region 3 Caixas
                #region Monofasico

                #endregion

                #region Bifasico

                #endregion

                #region Trifasico

                #endregion
                #endregion
            });
        }
    }
}
