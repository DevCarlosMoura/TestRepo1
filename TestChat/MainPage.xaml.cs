namespace TestChat
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }
    private async void OnEntryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartPage());
        }
    private async void OnAjudaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpLogin());
        }
    }

}
