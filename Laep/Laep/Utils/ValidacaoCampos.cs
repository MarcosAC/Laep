using Laep.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.Utils
{
    public class ValidacaoCampos
    {
        public static async Task<bool> Validar(ResultadoDimensionamento campo)
        {
            if (campo.QuantidadeCaixa == "1")
                if (string.IsNullOrEmpty(campo.Tensao) ||
                    string.IsNullOrEmpty(campo.QuantidadeCaixa) ||
                    string.IsNullOrEmpty(campo.ModeloCaixa1))
                {
                    await MensagemDeAlerta();
                    return false;
                }
            else
                {
                    return true;
                }

            if (campo.QuantidadeCaixa == "2")
                if (string.IsNullOrEmpty(campo.Tensao) ||
                    string.IsNullOrEmpty(campo.QuantidadeCaixa) ||
                    string.IsNullOrEmpty(campo.ModeloCaixa1) ||
                    string.IsNullOrEmpty(campo.ModeloCaixa2))
                {
                    await MensagemDeAlerta();
                    return false;
                }
                else
                {
                    return true;
                }

            if (campo.QuantidadeCaixa == "3")
                if (string.IsNullOrEmpty(campo.Tensao) ||
                    string.IsNullOrEmpty(campo.QuantidadeCaixa) ||
                    string.IsNullOrEmpty(campo.ModeloCaixa1) ||
                    string.IsNullOrEmpty(campo.ModeloCaixa2) ||
                    string.IsNullOrEmpty(campo.ModeloCaixa3))
                {
                    await MensagemDeAlerta();
                    return false;
                }
                else
                {
                    return true;
                }

            await MensagemDeAlerta();
            return false;
        }

        private static async Task MensagemDeAlerta()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Preencher todos os campos.", "Ok");
        }
    }
}
