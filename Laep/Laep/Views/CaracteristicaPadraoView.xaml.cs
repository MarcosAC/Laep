using System.Collections.Generic;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CaracteristicaPadraoView : ContentPage
	{
		public CaracteristicaPadraoView ()
		{
			InitializeComponent ();

            ListaModeloCaixa();
		}

        List<string> listaDisjuntorCaixaMonofasico = new List<string> { "40A", "50A", "70A" };
        List<string> listaDisjuntorCaixaBifasicoTrifasico = new List<string> { "40A", "60A" };

        private void ListaModeloCaixa()
        {
            var listaCaixa = new List<string> { "Monofasico", "Bifasico", "Trifasico" };

            foreach (var item in listaCaixa)
            {
                pickerModeloCaixa1.Items.Add(item);
                pickerModeloCaixa2.Items.Add(item);
                pickerModeloCaixa3.Items.Add(item);
            }
        }

        private void ListaDisjuntor()
        {
            pickerDisjuntor1.Items.Clear();
            pickerDisjuntor2.Items.Clear();
            pickerDisjuntor3.Items.Clear();

            foreach (var item in listaDisjuntorCaixaBifasicoTrifasico)
            {
                pickerDisjuntor1.Items.Add(item);
                pickerDisjuntor2.Items.Add(item);
                pickerDisjuntor3.Items.Add(item);
            }
        }

        private void PickerModeloCaixa1SelectedIndexChanged(object sender, System.EventArgs e)
        {
            pickerDisjuntor1.Items.Clear();

            if (pickerModeloCaixa1.SelectedIndex == 0)
                foreach (var item in listaDisjuntorCaixaMonofasico)
                {
                    pickerDisjuntor1.Items.Add(item);
                }
            else
                ListaDisjuntor();
        }

        private void PickerModeloCaixa2SelectedIndexChanged(object sender, System.EventArgs e)
        {
            pickerDisjuntor2.Items.Clear();

            if (pickerModeloCaixa2.SelectedItem.ToString() == "Monofasico")
                foreach (var item in listaDisjuntorCaixaMonofasico)
                {
                    pickerDisjuntor2.Items.Add(item);
                }
            else
                ListaDisjuntor();
        }

        private void PickerModeloCaixa3SelectedIndexChanged(object sender, System.EventArgs e)
        {
            pickerDisjuntor3.Items.Clear();

            if (pickerModeloCaixa3.SelectedItem.ToString() == "Monofasico")
                foreach (var item in listaDisjuntorCaixaMonofasico)
                {
                    pickerDisjuntor3.Items.Add(item);
                }
            else
                ListaDisjuntor();
        }
    }
}