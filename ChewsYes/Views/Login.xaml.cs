using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChewsYes.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)         {

            Navigation.PushAsync(new Forgot());

        }
    }
}
