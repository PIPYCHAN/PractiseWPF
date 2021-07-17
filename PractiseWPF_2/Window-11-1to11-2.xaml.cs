using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PractiseWPF_2.UseControl;

namespace PractiseWPF_2
{
    /// <summary>
    /// Window_11.xaml 的交互逻辑
    /// </summary>
    public partial class Window_11 : Window
    {
        public Window_11()
        {
            InitializeComponent();
            InitialCarList();
        }
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car(){ Automaker="Lamborghini",Name="Diablo",Year="1990",TopSpeed="340"},
                new Car(){ Automaker="Lamborghini",Name="Murcielago",Year="2001",TopSpeed="350"},
                new Car(){ Automaker="Lamborghini",Name="Gallardo",Year="2003",TopSpeed="325"},
                new Car(){ Automaker="Lamborghini",Name="Reventon",Year="2008",TopSpeed="356"},
            };
            this.listBoxCars.ItemsSource = carList;
            //foreach (Car car in carList)
            //{
            //    CarListItemView view = new CarListItemView();
            //    view.Car = car;
            //    this.listBoxCars.Items.Add(view);
            //}
        }
        private void listBoxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarListItemView view = e.AddedItems[0] as CarListItemView;
            if (view!=null)
            {
                //this.detailView.Car = view.Car;
            }
        }
    }

    public class Car
    { 
        public string Automaker { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }

        public string TopSpeed { get; set; }
    }

    public class AutoMakerToLogoPathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format($@"/Resources/Logos/{(string)value}.jpg");
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class NameToPhotoPathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = $@"/Resources/Images/{(string)value}.jpg";
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
