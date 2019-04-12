using StackCustomForceRender.Pages;
using System.Windows.Input;
using Xamarin.Forms;

namespace StackCustomForceRender.ViewModels
{
    public class UmViewModel : ViewModelBase
    {
        private ICommand _proximaTelaCommand;

        public ICommand ProximaTelaCommand
        {
            get { return _proximaTelaCommand; }
            set { _proximaTelaCommand = value; }
        }

        public UmViewModel()
        {
            ProximaTelaCommand = new Command(ProximaTela);
        }

        private async void ProximaTela()
        {
            await Navigation.PushAsync(new DoisPage());
        }
    }
}
