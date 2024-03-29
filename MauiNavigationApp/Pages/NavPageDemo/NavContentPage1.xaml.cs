namespace SampleMauiApp.Pages.NavPageDemo;

public partial class NavContentPage1 : ContentPage
{
	public NavContentPage1()
	{
		InitializeComponent();
	}

    private async void NavContentPage2Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavContentPage2());
    }
}