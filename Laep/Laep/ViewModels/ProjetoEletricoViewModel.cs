using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    public class ProjetoEletricoViewModel : CadastroViewModel
    {
        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//paginaInicial");
    }
}
