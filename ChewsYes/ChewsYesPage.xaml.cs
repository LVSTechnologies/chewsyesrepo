using ChewsYes.Interfaces;
using ChewsYes.Views;
using Xamarin.Forms;

namespace ChewsYes
{
    public partial class ChewsYesPage : ContentPage
    {
        public ChewsYesPage()
        {
            InitializeComponent();
            //ToolbarItems.Add(new ToolbarItem("Hello","qrcodechewsyes.png",));
            //NavigationPage.SetHasNavigationBar(this, false);
            //NavigationPage.SetTitleIcon(this,"qrcodechewsyes.png");
            //btnOrderNow.Clicked += btnOrderNow_Clicked;
            //btnParking.Clicked += btnParking_Clicked;
            //LoadImages();
            if (Device.RuntimePlatform == Device.iOS)
            {
                HamburgerMenu.Icon = "hamburger.png";
                QrCode.Icon = "qrcodechewsyes.png";
            }
            //    HamburgerMenu.Icon = "hamburger.png";
                //HamburgerMenu.Icon = (Xamarin.Forms.FileImageSource)ImageSource.FromResource("hamburger.png");
            //HamburgerMenu.Icon = new ResourceImageSource()     (Xamarin.Forms.FileImageSource)ImageSource.FromResource("ChewsYes.Images.hamburger.png");
        }

        async void btnOrderNow_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OrderNow());
        }

        async void btnParking_Clicked(object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new ParkingPage());
            await Navigation.PushAsync(new ParkingPage());
        }

        async void QrCode_Clicked(object sender, System.EventArgs e)
        {
            //var prompt = DependencyService.Get<IPrompt>();
            //var valueReturned = await prompt.DisplayPrompt("Orders", "Enter the number of Orders");
            await Navigation.PushAsync(new QRCodePage());
        }

        void HamburgerMenu_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Menu Items", "Coming Soon", "Ok");
        }

        void LoadImages()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    QrCode.Icon = (Xamarin.Forms.FileImageSource)ImageSource.FromFile("Image-1");
                    //HamburgerMenu.Icon = (Xamarin.Forms.FileImageSource)ImageSource.FromFile("Image");
                    break;
                case Device.Android:
                    QrCode.Icon = (Xamarin.Forms.FileImageSource)ImageSource.FromResource("qrcodechewsyes");
                    break;
                default:
                    break;
            }

        }
    }
}
