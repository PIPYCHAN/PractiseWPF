using PractiseWPF_2.Class;
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
    /// Window_11_5.xaml 的交互逻辑
    /// </summary>
    public partial class Window_11_5 : Window
    {
        public Window_11_5()
        {
            InitializeComponent();

            List<Student> stuList = new List<Student> { 
                new Student{ Id=1,Name="Mary",Age=1},
                new Student{ Id=2,Name="Tom",Age=2},
                new Student{ Id=3,Name="Jack",Age=2},
                new Student{ Id=4,Name="Rose",Age=3},
            };
            this.listBoxStudent.ItemsSource = stuList;
        }
    }

    public class L2BConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int txtLen = (int)value;
            return txtLen > 6 ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
