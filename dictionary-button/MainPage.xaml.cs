using dictionary_button.Controls;
using System.Windows.Input;

namespace dictionary_button
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // ANY view can add its commands into the static dictionary.
            DictionaryCommandButton.Commands["Main.Up"] = DisplayUp;
            DictionaryCommandButton.Commands["Main.Down"] = DisplayDown;
            DictionaryCommandButton.Commands["Main.Left"] = DisplayLeft;
            DictionaryCommandButton.Commands["Main.Right"] = DisplayRight;
        }
        ICommand DisplayUp { get; } = new Command(async() =>
        {
            await App.Current.MainPage.DisplayAlert(
                title: "Handled!",
                message: "You clicked Up",
                cancel: "Got it");
        });
        ICommand DisplayDown { get; } = new Command(async () =>
        {
            await App.Current.MainPage.DisplayAlert(
                title: "Handled!",
                message: "You clicked Down",
                cancel: "Got it");
        });
        ICommand DisplayLeft { get; } = new Command(async () =>
        {
            await App.Current.MainPage.DisplayAlert(
                title: "Handled!",
                message: "You clicked Left",
                cancel: "Got it");
        });
        ICommand DisplayRight { get; } = new Command(async () =>
        {
            await App.Current.MainPage.DisplayAlert(
                title: "Handled!",
                message: "You clicked Right",
                cancel: "Got it");
        });
    }
}
