using System;
using System.Collections.Generic;
using System.Linq;
using ChewsYes.ViewModels;
using Xamarin.Forms.Maps;

namespace ChewsYes.Models
{
    public class Store : ViewModelBase
    {
        protected Position _pos = new Position();
        public Position Pos
        {
            get => _pos;
            set
            {
                _pos = value;

                OnPropertyChanged(nameof(Pos));
                AssignDescription();
            }
        }

        protected async void AssignDescription()
        {
            IEnumerable<string> addrs = (await new Geocoder().GetAddressesForPositionAsync(Pos));
            if (addrs.Count<string>() > 0)
            {
                _description = addrs.First<string>();
            }
            else
            {
                _description = $"{Title} description";
            }
            OnPropertyChanged(nameof(Description));
        }

        protected string _description = string.Empty;

        public string Description
        {
            get => _description;
        }

        public string Title { get; set; }

        public List<Food> Foods { get; set; } = new List<Food>();

        public string Image { get; set; }
    }
}
