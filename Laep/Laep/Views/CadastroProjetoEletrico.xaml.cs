using Laep.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroProjetoEletrico : ContentPage
    {
		public CadastroProjetoEletrico ()
		{
			InitializeComponent ();

            BindingContext = new ProjetoEletricoViewModel();
		}
	}
}