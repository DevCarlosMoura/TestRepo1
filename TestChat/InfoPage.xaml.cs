namespace TestChat;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
    private async void OnStartPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StartPage());
    }
}