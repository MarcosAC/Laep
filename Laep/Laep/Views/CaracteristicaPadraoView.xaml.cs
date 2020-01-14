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
            ListaDisjuntor();
		}

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
            var listaDisjuntor = new List<string> { "40A", "50A", "60A", "70A" };
                                                   
            foreach (var item in listaDisjuntor)       
            {
                pickerDisjuntor1.Items.Add(item);
                pickerDisjuntor2.Items.Add(item);
                pickerDisjuntor3.Items.Add(item);
            }
        }

    }
}