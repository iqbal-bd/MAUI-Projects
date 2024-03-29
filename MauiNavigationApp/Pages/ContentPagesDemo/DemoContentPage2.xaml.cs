namespace SampleMauiApp.Pages;

public partial class DemoContentPage2 : ContentPage
{
	public DemoContentPage2()
	{
		InitializeComponent();
	}

	private async void closeButton_clicked(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}

	private async void contentPage3Button_clicked(Object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new DemoContentPage3());
	}
}