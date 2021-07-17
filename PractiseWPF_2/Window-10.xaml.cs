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
    /// Window_10_1.xaml 的交互逻辑
    /// </summary>
    public partial class Window_10_1 : Window
    {
        public Window_10_1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string tmp = (string)this.FindResource("str1");//从外往里
            MessageBox.Show(tmp);
        }



        private void btn_Dynamic_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["res1"] = new TextBlock() { Text = "天涯共此时" };
            this.Resources["res2"] = new TextBlock() { Text = "天涯共此时" };
        }
    }
}
