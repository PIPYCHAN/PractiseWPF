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
    /// Window_11_4_Sample5.xaml 的交互逻辑
    /// </summary>
    public partial class Window_11_4_Sample5 : Window
    {
        public Window_11_4_Sample5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = this.uc.Template.FindName("txtBox1", this.uc) as TextBox;
            tb.Text = "Hello WPF";
            StackPanel sp = tb.Parent as StackPanel;
            (sp.Children[1] as TextBox).Text = "Hello controlTemplate";
            (sp.Children[2] as TextBox).Text = "i can find you";
        }
    }
}
