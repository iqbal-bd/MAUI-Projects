namespace SampleMauiApp.Pages;

public partial class DemoContentPage3 : ContentPage
{
	public DemoContentPage3()
	{
		InitializeComponent();
	}

    private async void closeButton3_clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}