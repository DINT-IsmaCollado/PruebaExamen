using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PruebaExamen
{
    class PrediccionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string prediccion = (string)value;
            string source = "";
            switch (prediccion.ToLower())
            {
                case "sol":
                    source = "sunny.png";
                    break;
                case "nubes":
                    source = "cloudy.png";
                    break;
                case "lluvia":
                    source = "rain.png";
                    break;
                case "nieve":
                    source = "snow.png";
                    break;
            }
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
