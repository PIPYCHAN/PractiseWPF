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
using System.Windows.Shapes;

namespace PractiseWPF_2
{
    /// <summary>
    /// Window_11_4_Sample4.xaml 的交互逻辑
    /// </summary>
    public partial class Window_11_4_Sample4 : Window
    {
        public Window_11_4_Sample4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var test = this.Resources["ds"];
        }
    }
}
