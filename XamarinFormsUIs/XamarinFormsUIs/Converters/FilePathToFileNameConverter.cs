using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;


namespace XamarinFormsUIs.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class FilePathToFileNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is object == false)
            {
                return default(string);
            }

            var input = (string)value;

            return Path.GetFileName(input);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}