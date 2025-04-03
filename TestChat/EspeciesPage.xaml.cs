using System;

namespace TestChat
{
    public partial class EspeciesPage : ContentPage
    {
        public EspeciesPage()
        {
            InitializeComponent();
        }
        private async void OnAddEspecieClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspeciesPage());
        }
    }
}