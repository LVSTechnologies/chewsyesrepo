using System;
using System.Globalization;
using Xamarin.Forms;

namespace ChewsYes.Converters
{
    public class ImageConverter : IValueConverter
    {
        public ImageConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fileName = (value ?? "").ToString();
            return null;
            //return Device.OnPlatform(
              //iOS: (System.Action)ImageSource.FromFile($"Images/{fileName}"),
              //Android: ImageSource.FromFile(fileName));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
