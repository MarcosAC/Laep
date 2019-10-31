using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laep.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaPrincipal : ContentPage
	{
		public PaginaPrincipal ()
		{
			InitializeComponent ();
		}

        private async void OnClickedProjetoEletrico(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//cadastroProjetoEletrico");
        }
    }
}