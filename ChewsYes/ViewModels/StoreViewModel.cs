using System;
using System.Collections.ObjectModel;
using ChewsYes.Models;
using Xamarin.Forms;

namespace ChewsYes.ViewModels
{
    public class StoreViewModel : ViewModelBase
    {
        protected Store _store = new Store();

        public Store StoreData
        {
            get => _store;
            set
            {
                _store = value;

                OnPropertyChanged(nameof(StoreData));
                OnPropertyChanged(nameof(StoreImageSource));
                OnPropertyChanged(nameof(FoodsCollection));
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(TotalPrice));
                OnPropertyChanged(nameof(TotalCount));
            }
        }

        public ImageSource StoreImageSource
        {
            get
            {
                if (string.IsNullOrWhiteSpace(StoreData.Image))
                    return null;
                return ImageSource.FromUri(new Uri(StoreData.Image));
            }
        }

        public ObservableCollection<Food> FoodsCollection => new ObservableCollection<Food>(StoreData.Foods);

        public string Title => StoreData.Title;

        public string Description => StoreData.Description;

        public string TotalPrice
        {
            get
            {
                float totalPrice = 0;
                foreach (Food f in FoodsCollection)
                {
                    totalPrice += f.Price * f.Count;
                }
                return $"${totalPrice}";
            }
        }

        public string TotalCount
        {
            get
            {
                return FoodsCollection.Count.ToString();
            }
        }

        public void UpdateOrders()
        {
            OnPropertyChanged(nameof(TotalPrice));
            OnPropertyChanged(nameof(TotalCount));
        }
    }
}
