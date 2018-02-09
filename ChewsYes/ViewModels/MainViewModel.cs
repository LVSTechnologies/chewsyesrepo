using System;
using System.Collections.ObjectModel;
using ChewsYes.Models;

namespace ChewsYes.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        protected ObservableCollection<Store> _stores = new ObservableCollection<Store>();
        public ObservableCollection<Store> Stores
        {
            get => _stores;
            set
            {
                _stores = value;
                OnPropertyChanged(nameof(Stores));
            }
        }
    }
}
