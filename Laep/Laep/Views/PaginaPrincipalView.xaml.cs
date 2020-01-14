using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class PaginaPrincipalView : ContentPage
	{
		public PaginaPrincipalView ()
		{
			InitializeComponent ();

            BindingContext = new PaginaPrincipalViewModel();
        }
    }
}