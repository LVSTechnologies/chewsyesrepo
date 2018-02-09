using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ChewsYes.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ChewsYes.Views
{
    public partial class OrderNow : ContentPage
    {
        public OrderNow()
        {
            InitializeComponent();  

            myVM.Stores = new ObservableCollection<Store>()
            {
                new Store
                {
                    Title = "Store 1",
                    Pos = new Position(41.1,-93.1),
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5a/Crumbs-Bake-Shop-Cupcake-Display.jpg/1200px-Crumbs-Bake-Shop-Cupcake-Display.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 2",
                    Pos = new Position(41.2,-93.2),
                    Image = "http://images.citywebindia.com/Advertisement/saharanpurweb_Bakery-Shop-in-Saharanpur_524ab0e0-5_30-04-2016164637.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }

                },
                new Store
                {
                    Title = "Store 3",
                    Pos = new Position(41.3,-93.3),
                    Image = "https://www.robairesbakery.com/img/6581/530.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 4",
                    Pos = new Position(41.4,-93.4),
                    Image = "https://image.shutterstock.com/z/stock-vector-bakery-shop-design-concept-with-chef-in-uniform-standing-in-front-of-the-shop-window-with-cake-in-629680169.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 5",
                    Pos = new Position(41.5,-93.5),
                    Image = "http://www.thepostread.com/wp-content/uploads/2017/07/bakery-Shop.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 6",
                    Pos = new Position(41.6,-93.6),
                    Image = "https://media.gettyimages.com/photos/business-owner-at-a-bakery-shop-picture-id588598056?s=612x612",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 7",
                    Pos = new Position(41.7,-93.7),
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/02/32/59/1d/a-bakery-shop-on-rue.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 8",
                    Pos = new Position(41.8,-93.8),
                    Image = "http://www.lewisheriz.com/gallery/work/client/thecakeshop/cs-slider-1/cs-02-shopinterior.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 9",
                    Pos = new Position(41.9,-93.9),
                    Image = "http://l7.alamy.com/zooms/277a29267ac84d27bac66598e1466771/germany-bavaria-romantic-road-dinkelsbuhl-bakery-shop-display-hgdgbm.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                },
                new Store
                {
                    Title = "Store 10",
                    Pos = new Position(41.0,-93.0),
                    Image = "http://mccloskeysbakery.ie/wp-content/uploads/2014/07/mccloskeys-shop-navan-11.jpg",
                    Foods = new List<Food>
                    {
                        new Food
                        {
                            Title = "BBQ BACON",
                            Description = "BBQ BACON Description",
                            Price = 10.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"

                        },
                        new Food
                        {
                            Title = "BUFFALO BURGER",
                            Description = "BUFFALO BURGER Description",
                            Price = 10.49f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 1",
                            Description = "CAJUN BURGER 1 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 2",
                            Description = "CAJUN BURGER 2 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        },
                        new Food
                        {
                            Title = "CAJUN BURGER 3",
                            Description = "CAJUN BURGER 3 Description",
                            Price = 9.99f,
                            Image = "https://previews.123rf.com/images/naddya/naddya1307/naddya130700077/20961830-piece-of-chocolate-cake-with-cream-and-cherry-vector-illustration.jpg"
                        }
                    }
                }
            };

            foreach (Store s in myVM.Stores)
            {
                mapView.Pins.Add(new Pin
                {
                    Position = s.Pos,
                    Type = PinType.Place,
                    Label = s.Title
                });
            }

            mapView.MoveToRegion(new MapSpan(new Position(41.5, -93.5), 1, 1));
        }

        protected void OnClickMenu(object sender, EventArgs e)
        {
            DisplayAlert("Test", "Clicked Menu button", "OK");
        //    UserDialogs.Instance.Alert("Clicked Menu button");
        }

        protected void OnClickVideo(object sender, EventArgs e)
        {
            webView.IsVisible = !webView.IsVisible;

        }

        protected void OnClickResource(object sender, EventArgs e)
        {
        //    UserDialogs.Instance.Alert("Clicked Resource button");
            DisplayAlert("Test", "Clicked Menu button", "OK");
        }

        protected void OnClickFavourite(object sender, EventArgs e)
        {
        //    UserDialogs.Instance.Alert("Clicked Favourite button");
            DisplayAlert("Test", "Clicked Favourite button", "OK");
        }

        protected void OnClickDirection(object sender, EventArgs e)
        {
        //    UserDialogs.Instance.Alert("Clicked Direction button");
            DisplayAlert("Test", "Clicked Direction button", "OK");
        }

        protected void OnClickCall(object sender, EventArgs e)
        {
        //    UserDialogs.Instance.Alert("Clicked Call button");
            DisplayAlert("Test", "Clicked Call button", "OK");
        }

        protected void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;

            if (e.SelectedItem == null)
                return;

            Navigation.PushAsync(new StorePage(e.SelectedItem as Store));
        }
    }
}
