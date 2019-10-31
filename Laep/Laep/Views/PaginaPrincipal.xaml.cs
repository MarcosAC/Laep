using System;
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

        private async void OnClickedPrevencaoCombatIcendio(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//cadastroProjetoPrevencaoIncendio");
        }

        private void OnClickedCemig(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("", "Voce é Eletricista?", "Sim", "Não");
        }
    }
}