namespace TestChat
{
    public partial class StartPage : ContentPage
    {

        public StartPage()
        {
            InitializeComponent();
        }
        private async void OnCadastroClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());
        }
        private async void OnIDpetClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnimalPage());
        }
        private async void OnEspeciesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspeciesPage());
        }
        private async void OnHelpPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage());
        }
        private async void OnInfoPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }
    }

}