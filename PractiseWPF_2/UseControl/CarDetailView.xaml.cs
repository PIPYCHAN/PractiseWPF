using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PractiseWPF_2.UseControl
{
    /// <summary>
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        public CarDetailView()
        {
            InitializeComponent();
        }


        private Car car;
        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                this.txtBlockAutomaker.Text = car.Automaker;
                this.txtBlockYear.Text = car.Year;
                this.txtBlockTopSpeed.Text = car.TopSpeed;
                this.txtBlockName.Text = car.Name;
                string uriStr = $@"/Resources/Images/{car.Name}.jpg";
                this.imagePhoto.Source = new BitmapImage(new Uri(uriStr,UriKind.Relative));
            }
        }
    }
}
