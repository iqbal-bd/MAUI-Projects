namespace SampleMauiApp.Pages.NavPageDemo;

public partial class NavContentPage2 : ContentPage
{
	public NavContentPage2()
	{
		InitializeComponent();
	}


    private async void NavContentPage3Button_clicked(Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavContentPage3());
    }

    private async void NavCloseButton_clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}