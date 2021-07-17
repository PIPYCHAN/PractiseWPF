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

namespace PractiseWPF_2
{
    /// <summary>
    /// Window_6.xaml 的交互逻辑
    /// </summary>
    public partial class Window_6_5 : Window
    {
        public Window_6_5()
        {
            InitializeComponent();
            SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            Binding b1 = new Binding("Text") { Source = this.txtBox1 };
            Binding b2 = new Binding("Text") { Source = this.txtBox2 };
            Binding b3 = new Binding("Text") { Source = this.txtBox3 };
            Binding b4 = new Binding("Text") { Source = this.txtBox4 };

            ////准备multiBinding
            MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);
            mb.Bindings.Add(b3);
            mb.Bindings.Add(b4);
            mb.Converter = new LogonMultiBindingConverter();
            //将Button与MultiBinding对象关联
            this.btn_Submit.SetBinding(Button.IsEnabledProperty, mb);
        }
    }

    public class LogonMultiBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!values.Cast<string>().Any(text => string.IsNullOrEmpty(text))
                && values[0].ToString() == values[1].ToString()
                && values[2].ToString() == values[3].ToString()
                )
            {
                return true;
            }
            return false;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
