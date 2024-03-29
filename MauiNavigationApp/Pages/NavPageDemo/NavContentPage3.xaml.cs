namespace SampleMauiApp.Pages.NavPageDemo;

public partial class NavContentPage3 : ContentPage
{
	public NavContentPage3()
	{
		InitializeComponent();
	}

    private async void NavCloseButton3_clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}