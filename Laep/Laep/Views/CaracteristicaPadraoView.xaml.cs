using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CaracteristicaPadraoView : ContentPage
	{
		public CaracteristicaPadraoView ()
		{
			InitializeComponent ();

            BindingContext = new CaracteristicaPadraoViewModel();
		}
    }
}