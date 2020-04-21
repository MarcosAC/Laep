using Laep.Models;
using Realms;
using System.Linq;

namespace Laep.Data
{
    public class DataResultadosDimensionamentos
    {
        public static void CriarBdResultados()
        {
            Realm realmDb = Realm.GetInstance();

            var resutados = realmDb.All<ResultadoDimensionamento>().ToList();

            if (resutados.Count == 0)
            {
                realmDb.Write(() =>
                {
                    #region Sistema Trifásico 127/220V
                    #region 1 Caixa
                    #region Monofasico
                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "1",
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

                    realmDb.Add(new ResultadoDimensionamento
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
                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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
                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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
                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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
                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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

                    realmDb.Add(new ResultadoDimensionamento
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
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "6mm",
                        ValorNeutro = "10mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "10mm",
                        ValorNeutro = "16mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "10mm",
                        ValorNeutro = "16mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "10mm",
                        ValorNeutro = "16mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "10mm",
                        ValorNeutro = "16mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM2 disjuntor 3x60",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM2 disjuntor 3x60",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM2 disjuntor 3x60",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM2 disjuntor 3x60",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });
                    #endregion

                    #region Bifasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM2 disjuntor 3x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM2 disjuntor 3x60",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });
                    #endregion

                    #region Trifasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM2 disjuntor 2x60",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM2 disjuntor 2x60",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM2 disjuntor 2x60",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "25mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "Q35",
                        ValorEntrada = "3",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 3x60",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "3",
                        ValorFases = "25mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });
                    #endregion
                    #endregion
                    #endregion

                    #region Sistema Monofásico 120/240V
                    #region 1 Caixa
                    #region Monofasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
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
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "1",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ModeloCaixa2 = "",
                        ModeloCaixa3 = "",
                        ValorMultiplex = "",
                        ValorEntrada = "2",
                        ValorFases = "10mm",
                        ValorNeutro = "10mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "1",
                        CondutorDeAterramento = "10mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
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
                    #endregion

                    #region 2 Caixas

                    #region Monofasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
                        ModeloCaixa3 = "",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "2",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
                        ModeloCaixa3 = "",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "2",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
                        ModeloCaixa3 = "",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "2",
                        CondutorDeAterramento = "16mm",
                    });
                    #endregion

                    #region Bifasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x60",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x40",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x60",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
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

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "2",
                        ModeloCaixa1 = "CM2 disjuntor 2x60",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
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
                    #endregion
                    #endregion

                    #region 3 Caixas

                    #region Monofasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x50",
                        ModeloCaixa3 = "CM1 disjuntor 1x50",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "Q16",
                        ValorEntrada = "2",
                        ValorFases = "10mm",
                        ValorNeutro = "16mm",
                        Protecao = "10mm",
                        EletrodutoPcv = "32mm",
                        EletrodutoAco = "25mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x40",
                        ModeloCaixa3 = "CM1 disjuntor 1x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "16mm",
                        ValorNeutro = "25mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM1 disjuntor 1x70",
                        ModeloCaixa3 = "CM1 disjuntor 1x70",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "T35",
                        ValorEntrada = "2",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });                    
                    #endregion

                    #region Bifasico
                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "T70",
                        ValorEntrada = "2",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x70",
                        ValorMultiplex = "T70",
                        ValorEntrada = "2",
                        ValorFases = "50mm",
                        ValorNeutro = "50mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "50mm",
                        EletrodutoAco = "40mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Monofásico 120/240V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x40",
                        ModeloCaixa3 = "CM2 disjuntor 2x40",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x40",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });

                    realmDb.Add(new ResultadoDimensionamento
                    {
                        Tensao = "Sistema Trifásico 127/220V",
                        QuantidadeCaixa = "3",
                        ModeloCaixa2 = "CM2 disjuntor 2x60",
                        ModeloCaixa3 = "CM2 disjuntor 2x60",
                        ModeloCaixa1 = "CM1 disjuntor 1x50",
                        ValorMultiplex = "T16",
                        ValorEntrada = "2",
                        ValorFases = "35mm",
                        ValorNeutro = "35mm",
                        Protecao = "16mm",
                        EletrodutoPcv = "40mm",
                        EletrodutoAco = "32mm",
                        NumeroDeEletrodos = "3",
                        CondutorDeAterramento = "16mm",
                    });
                    #endregion
                  
                    #endregion
                    #endregion

                });
            }
        }

        public static string ObterResultado(ResultadoDimensionamento valoresDimensionamento)
        {
            Realm realmDb = Realm.GetInstance();

            var listaResultados = realmDb.All<ResultadoDimensionamento>().ToList();

            var resultadoDimensionamento = from resultado in listaResultados
                                           where resultado.Tensao == valoresDimensionamento.Tensao &&
                                                 resultado.QuantidadeCaixa == valoresDimensionamento.QuantidadeCaixa && 
                                                 resultado.ModeloCaixa1 == valoresDimensionamento.ModeloCaixa1 || 
                                                 resultado.ModeloCaixa2 == valoresDimensionamento.ModeloCaixa2 ||
                                                 resultado.ModeloCaixa3 == valoresDimensionamento.ModeloCaixa3
                                           select resultado;

            string dimensionamento = string.Empty;

            foreach (var item in resultadoDimensionamento)
            {
                dimensionamento = $"{item.ValorMultiplex}," +
                                  $"{item.ValorEntrada}," +
                                  $"{item.ValorFases}," +
                                  $"{item.ValorNeutro}," +
                                  $"{item.Protecao}," +
                                  $"{item.EletrodutoPcv}," +
                                  $"{item.EletrodutoAco}," +
                                  $"{item.NumeroDeEletrodos}," +
                                  $"{item.CondutorDeAterramento}";
            }

            return dimensionamento;
        }
    }
}
