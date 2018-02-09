using System;
using System.Windows.Input;
using ChewsYes.Models;
using Xamarin.Forms;

namespace ChewsYes.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        protected Food _food = new Food();

        public Food FoodData
        {
            get => _food;
            set
            {
                _food = value;
                OnPropertyChanged(nameof(FoodImageSource));
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(PriceToString));
                OnPropertyChanged(nameof(Count));
                OnPropertyChanged(nameof(SubTotalToString));
                OnPropertyChanged(nameof(TaxAndFeesToString));
                OnPropertyChanged(nameof(TotalToString));
                OnPropertyChanged(nameof(InstaCashImageSource));
                OnPropertyChanged(nameof(CheckingAccountImageSource));
                OnPropertyChanged(nameof(CreditCardImageSource));
            }
        }

        public ImageSource FoodImageSource => FoodData.FoodImageSource;

        public string Title => FoodData.Title;

        public string Description => FoodData.Description;

        public string PriceToString => FoodData.PriceToString;

        public int Count => FoodData.Count;

        public string SubTotalToString
        {
            get
            {
                return $"${FoodData.Price * FoodData.Count}";
            }
        }

        public string TaxAndFeesToString => $"${FoodData.TaxAndFees}";

        public string TotalToString
        {
            get
            {
                return $"${FoodData.Price * FoodData.Count + FoodData.TaxAndFees}";
            }
        }

        protected ImageSource GetCheckImageSource(bool isChecked)
        {
            return ImageSource.FromResource(isChecked ? "ChewsYes.Images.check2_green_checked.png" : "ChewsYes.Images.check2_green_unchecked.png");
        }


        public bool IsCheckedInstaCash { get; set; } = false;

        public ImageSource InstaCashImageSource => GetCheckImageSource(IsCheckedInstaCash);

        public ICommand InstaCashCommand => new Command(() =>
        {
            IsCheckedInstaCash = !IsCheckedInstaCash;
            OnPropertyChanged(nameof(InstaCashImageSource));
        });

        public bool IsCheckedCheckingAccount { get; set; } = false;

        public ImageSource CheckingAccountImageSource => GetCheckImageSource(IsCheckedCheckingAccount);

        public ICommand CheckingAccountCommand => new Command(() =>
        {
            IsCheckedCheckingAccount = !IsCheckedCheckingAccount;
            OnPropertyChanged(nameof(CheckingAccountImageSource));
        });


        public bool IsCheckedCreditCard { get; set; } = false;

        public ImageSource CreditCardImageSource => GetCheckImageSource(IsCheckedCreditCard);

        public ICommand CreditCardCommand => new Command(() =>
        {
            IsCheckedCreditCard = !IsCheckedCreditCard;
            OnPropertyChanged(nameof(CreditCardImageSource));
        });

        public ICommand PlusCommand => new Command(() =>
        {
            FoodData.Count++;
            OnPropertyChanged(nameof(Count));
            OnPropertyChanged(nameof(SubTotalToString));
            OnPropertyChanged(nameof(TotalToString));
        });

        public ICommand MinusCommand => new Command(() =>
        {
            if (FoodData.Count > 0)
                FoodData.Count--;

            OnPropertyChanged(nameof(Count));
            OnPropertyChanged(nameof(SubTotalToString));
            OnPropertyChanged(nameof(TotalToString));
        });
    }
}
