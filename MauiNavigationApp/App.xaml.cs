using SampleMauiApp.Pages;
using SampleMauiApp.Pages.FlyoutPageDemo;
using SampleMauiApp.Pages.NavPageDemo;
using SampleMauiApp.Pages.TabbedPageDemo;

namespace SampleMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new DemoContentPage1();

            //var navigationPage = new NavigationPage(new NavContentPage1());
            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.Black;
            //MainPage = navigationPage;

            //MainPage = new DemoFlyoutPage();

            MainPage = new DemoTabbedPage();
        }
    }
}
