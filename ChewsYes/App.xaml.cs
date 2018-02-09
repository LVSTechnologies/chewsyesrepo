using Xamarin.Forms;
using ChewsYes.Views;

namespace ChewsYes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ChewsYesPage());

            //var menuPage = new MenuPage();
            //var rootPage = new RootPage();
            //rootPage.Master = menuPage;
            //rootPage.Detail = new ChewsYesPage();
            //MainPage = rootPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
