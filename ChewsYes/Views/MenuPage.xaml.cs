using System;
using System.Collections.Generic;
using ChewsYes.ViewModels;

using Xamarin.Forms;

namespace ChewsYes.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            BindingContext = new MenuPageViewModel();
            Title = "Menu";
            InitializeComponent();
        }
    }
}
