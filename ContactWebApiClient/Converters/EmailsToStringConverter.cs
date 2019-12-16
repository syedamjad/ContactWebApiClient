namespace ContactWebApiClient.Converters
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    public class EmailsToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            var items = value as ObservableCollection<Email>;
            var g = items.Select(x => x.MailAddress).ToArray();
            return string.Join("\n", g);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
