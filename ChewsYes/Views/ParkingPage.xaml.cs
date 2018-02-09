using System;
using System.Collections.Generic;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace ChewsYes.Views
{
    public partial class ParkingPage : ContentPage
    {
        Plugin.Geolocator.Abstractions.Position phoneGeoPosition;
        
        public ParkingPage()
        {
            InitializeComponent();
            this.Appearing += MainPage_Appearing;
        }

        private async void MainPage_Appearing(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            //if (locator.IsGeolocationAvailable && locator.IsGeolocationEnabled)
            //{
            phoneGeoPosition = await locator.GetPositionAsync();
            //MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(phoneGeoPosition.Latitude, phoneGeoPosition.Longitude), Distance.FromMiles(1)));
            //}
            //else
            //{
            //    await DisplayAlert("", "Geolocation is not available", "Ok");
            //}

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (this.MyMap.VisibleRegion != null)
            {
                await DisplayAlert("", "lat:" + this.MyMap.VisibleRegion.Center.Latitude + "   long:" + this.MyMap.VisibleRegion.Center.Longitude, "Ok");
            }
            else if (this.MyMap.LastMoveToRegion != null)
            {
                await DisplayAlert("", "lat:" + this.MyMap.LastMoveToRegion.Center.Latitude + "   long:" + this.MyMap.LastMoveToRegion.Center.Longitude, "Ok");
            }
        }

    }
}
