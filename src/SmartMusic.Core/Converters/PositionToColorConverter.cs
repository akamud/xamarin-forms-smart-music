using System;
using System.Globalization;
using Xamarin.Forms;

namespace SmartMusic.Core.Converters
{
    public class PositionToColorConverter : IValueConverter
    {
        public PositionToColorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value % 2 == 0 ? "#FBFBFD" : "#FFFFFF";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
