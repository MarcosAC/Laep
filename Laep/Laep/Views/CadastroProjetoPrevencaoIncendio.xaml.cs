using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CadastroProjetoPrevencaoIncendio : ContentPage
	{
		public CadastroProjetoPrevencaoIncendio ()
		{
			InitializeComponent ();

            BindingContext = new ProjetoPrevencaoIncendioViewModel();
        }
	}
}