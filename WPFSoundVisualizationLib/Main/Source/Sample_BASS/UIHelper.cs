// (c) Copyright Jacob Johnston.
// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Sample_BASS
{
    public static class UIHelper
    {
        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp)
        {
            Bind(dataSource, sourcePath, destinationObject, dp, null);
        }

        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string stringFormat)
        {
            Binding binding = new Binding
            {
                Source = dataSource,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Path = new PropertyPath(sourcePath),
                StringFormat = stringFormat
            };
            destinationObject.SetBinding(dp, binding);
        }

        public static T FindParent<T>(this DependencyObject child) where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);
            do
            {
                T matchedParent = parent as T;
                if(matchedParent != null)
                    return matchedParent;
                parent = VisualTreeHelper.GetParent(parent);
            }
            while(parent != null);

            return null;
        }
    }

    public class HalfValueConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)value / 2;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)value * 2;
        }
        #endregion
    }
}
