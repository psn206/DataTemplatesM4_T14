using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DataTemplates
{
    internal class ConvertCategoriesProductRus : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if((CategoriesProduct)value == CategoriesProduct.Food)
            {
                return "Еда";
            } else
            {
                return "Бытовая техника";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
          return DependencyProperty.UnsetValue;
        }
    }
}
