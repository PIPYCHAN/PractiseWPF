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
    /// Window_7_2.xaml 的交互逻辑
    /// </summary>
    public partial class Window_7_2 : Window
    {
        Student stu2;
        public Window_7_2()
        {
            InitializeComponent();
            TestDependency();
        }
        private void TestDependency()
        {
            stu2 = new Student();
            Binding binding = new Binding("Text") { Source = txtBox1 };
            BindingOperations.SetBinding(stu2,Student.NameProperty,binding);
        }
        private void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.SetValue(Student.NameProperty,this.txtBox1.Text);
            txtBox2.Text = (string)stu.GetValue(Student.NameProperty);
        }

        private void btn_Ok2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu2.GetValue(Student.NameProperty).ToString());
        }
    }

    //protected class Student : DependencyObject 
    //{
    //    public static readonly DependencyProperty NameProperty =
    //        DependencyProperty.Register("Name",typeof(string),typeof(Student));
    //}
}
