
using System.Threading.Tasks;

namespace TestChat
{
    public partial class ClientesPage : ContentPage
    {

        public ClientesPage()
        {
            InitializeComponent();
        }
        private async void OnAddClienteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());
        }
    }
}