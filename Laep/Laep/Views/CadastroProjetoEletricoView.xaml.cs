using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CadastroProjetoEletricoView : ContentPage
    {
		public CadastroProjetoEletricoView ()
		{
			InitializeComponent ();

            BindingContext = new ProjetoEletricoViewModel();
		}
	}
}