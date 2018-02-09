using System;
using System.Collections.Generic;
using System.Diagnostics;
using ChewsYes.Models;
using Xamarin.Forms;

namespace ChewsYes.Views
{
    public partial class OrderPage : ContentPage
    {
        public OrderPage(Food foodData)
        {
            try
            {
                InitializeComponent();
                myVM.FoodData = foodData;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
