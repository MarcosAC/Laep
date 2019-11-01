using Laep.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentView
    {
		public Cadastro ()
		{
			InitializeComponent ();

            BindingContext = new CadastroViewModel();
		}
	}
}