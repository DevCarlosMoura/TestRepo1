
using System.Threading.Tasks;

namespace TestChat
{
    public partial class EspeciesPage : ContentPage
    {
        public EspeciesPage()
        {
            InitializeComponent();
        }
        private async Task OnAddEspeciesClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspeciesPage());
        }

        private async Task OnDeleteEspecieClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspeciesPage());
        }
    }
}