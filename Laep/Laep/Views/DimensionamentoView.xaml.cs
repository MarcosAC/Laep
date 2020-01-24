using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class DimensionamentoView : ContentPage
	{
		public DimensionamentoView ()
		{
			InitializeComponent ();

            BindingContext = new DimensionamentoViewModel();
        }
	}
}