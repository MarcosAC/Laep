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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new CaracteristicaPadraoViewModel();
            ((CaracteristicaPadraoViewModel)BindingContext).RefreshCommand.Execute(null);
        }
    }
}