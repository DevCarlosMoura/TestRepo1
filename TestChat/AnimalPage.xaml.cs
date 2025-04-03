using System;

namespace TestChat;

public partial class AnimalPage : ContentPage
{
	public AnimalPage ()
	{
		InitializeComponent();
	}
	private async void OnAddAnimalClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AnimalPage());
	}
    private async void OnUpdateAnimalClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AnimalPage());
    }
    private async void OnDeleteAnimalClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AnimalPage());
    }
}