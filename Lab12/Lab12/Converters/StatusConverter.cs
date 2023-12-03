using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lab12.Converters
{
    public class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool status)
            {
                return status ? "Completado" : "Pendiente";
            }

            return "Pendiente";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
