using System.Windows.Input;

namespace dictionary_button.Controls;

public partial class DictionaryCommandButton : Button
{
	public static Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

	// Bind the OnHandle command here. No need to do it in xaml.
	public DictionaryCommandButton() =>
		Command = new Command<string>(OnHandle);
	public ICommand HandleCommand { get; private set;}
	private async void OnHandle(string key)
	{
		if (Commands.TryGetValue(key, out ICommand? command))
		{
			command?.Execute(this);
		}
		else
		{
			await App.Current.MainPage.DisplayAlert(
				title: "Error", 
				message: "Command not in dictionary",
				cancel: "Got it");
		}
	}
}