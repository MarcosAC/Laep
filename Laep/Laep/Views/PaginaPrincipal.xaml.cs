using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class PaginaPrincipal : ContentPage
	{
		public PaginaPrincipal ()
		{
			InitializeComponent ();

            BindingContext = new PaginaPrincipalViewModel();
        }
    }
}