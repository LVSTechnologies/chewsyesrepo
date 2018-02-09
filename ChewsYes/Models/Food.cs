using System;
using System.Windows.Input;
using ChewsYes.ViewModels;
using Xamarin.Forms;

namespace ChewsYes.Models
{
    public class Food : ViewModelBase
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Count { get; set; }

        public float Price { get; set; }

        public float TaxAndFees { get; set; } = 1.04f;

        public ImageSource FoodImageSource
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Image))
                    return null;
                return ImageSource.FromUri(new Uri(Image));
            }
        }


        public string PriceToString => $"${Price}";

        public ICommand PlusCommand => new Command((p) =>
        {
            Count++;
            OnPropertyChanged(nameof(Count));
            (p as StoreViewModel).UpdateOrders();
        });

        public ICommand MinusCommand => new Command((p) =>
        {
            if (Count <= 0)
                return;

            Count--;
            OnPropertyChanged(nameof(Count));
            (p as StoreViewModel).UpdateOrders();
        });
    }
}
