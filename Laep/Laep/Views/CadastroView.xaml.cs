using Laep.ViewModels;
using Xamarin.Forms;

namespace Laep.Views
{
    public partial class CadastroView : ContentView
    {
		public CadastroView ()
		{
			InitializeComponent ();

            BindingContext = new CadastroViewModel();
		}
	}
}