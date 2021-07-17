using PractiseWPF_2.Class;
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
    /// Window_7_3.xaml 的交互逻辑
    /// </summary>
    public partial class Window_7_3 : Window
    {
        public Window_7_3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human();
            School.SetGrade(human,6);
            int grade = School.GetGrade(human);
            MessageBox.Show(grade.ToString());
        }
    }
}
