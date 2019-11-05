using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CadastroProjetoEletrico : ContentPage
    {
		public CadastroProjetoEletrico ()
		{
			InitializeComponent ();

            BindingContext = new ProjetoEletricoViewModel();
		}
	}
}