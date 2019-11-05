using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class Cadastro : ContentView
    {
		public Cadastro ()
		{
			InitializeComponent ();

            BindingContext = new CadastroViewModel();
		}
	}
}