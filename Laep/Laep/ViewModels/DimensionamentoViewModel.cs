using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laep.ViewModels
{
    [QueryProperty("Amperes", "amper")]
    public class DimensionamentoViewModel : BaseViewModel
    {
        private Command _botaoVoltarTitleViewCommand;
        public Command BotaoVoltarTitleViewCommand =>
            _botaoVoltarTitleViewCommand ?? (_botaoVoltarTitleViewCommand = new Command(async () => await ExecuteBotaoVoltarTitleViewCommand()));

        public string Amperes
        {            
            set
            {
                string[] arrayAmperes = Uri.UnescapeDataString(value).Split(',');

                if (arrayAmperes != null)
                {
                    Amper = arrayAmperes[0];
                    OnPropertyChanged("Amper");
                }
            }
        }

        public string Amper { get; set; }

        private async Task ExecuteBotaoVoltarTitleViewCommand() => await Shell.Current.GoToAsync("//caracteriscaPadrao");
    }
}
