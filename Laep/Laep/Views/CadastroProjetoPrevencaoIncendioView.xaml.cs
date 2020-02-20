using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CadastroProjetoPrevencaoIncendioView : ContentPage
	{
		public CadastroProjetoPrevencaoIncendioView ()
		{
			InitializeComponent ();

            BindingContext = new ProjetoPrevencaoIncendioViewModel();
        }
	}
}