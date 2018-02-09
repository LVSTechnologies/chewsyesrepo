using System;
using System.Collections.Generic;
using ChewsYes.Models;
using Xamarin.Forms;

namespace ChewsYes.Views
{
    public partial class StorePage : ContentPage
    {
        public StorePage(Store storeData)
        {
            InitializeComponent();
            myVM.StoreData = storeData;
        }

        protected void OnSelctedFood(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;

            if (e.SelectedItem == null)
                return;

            Navigation.PushAsync(new OrderPage(e.SelectedItem as Food));
        }
    }
}
