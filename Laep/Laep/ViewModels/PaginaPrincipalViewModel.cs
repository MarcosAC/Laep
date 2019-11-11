using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    public class PaginaPrincipalViewModel : CadastroViewModel
    {
        private Command _projetoEletricoCommand;
        public Command ProjetoEletricoCommand =>
            _projetoEletricoCommand ?? (_projetoEletricoCommand = new Command(async () => await ExecuteProjetoEletricoCommand()));

        private async Task ExecuteProjetoEletricoCommand() => await Shell.Current.GoToAsync("//cadastroProjetoEletrico");

        private Command _projetoPrevecaoIncendioCommand;
        public Command ProjetoPrevecaoIncendioCommand =>
            _projetoPrevecaoIncendioCommand ?? (_projetoPrevecaoIncendioCommand = new Command(async () => await ExecuteProjetoPrevecaoIncendioCommand()));

        private async Task ExecuteProjetoPrevecaoIncendioCommand() => await Shell.Current.GoToAsync("//cadastroProjetoPrevencaoIncendio");
    }
}
