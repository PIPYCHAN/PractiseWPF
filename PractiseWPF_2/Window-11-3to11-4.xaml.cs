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
using System.Xml;

namespace PractiseWPF_2
{
    /// <summary>
    /// Window_11_3.xaml 的交互逻辑
    /// </summary>
    public partial class Window_11_3 : Window
    {
        public Window_11_3()
        {
            InitializeComponent();

            var test1 = this.Resources["dsXML"];
            var test = this.Resources["ds"];
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = e.OriginalSource as MenuItem;
            XmlElement xe = mi.Header as XmlElement;
            MessageBox.Show(xe.Attributes["Name"].Value) ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = this.uc.Template.FindName("txtBox1",this.uc) as TextBox;
            tb.Text = "Hello WPF";
            StackPanel sp = tb.Parent as StackPanel;
            (sp.Children[1] as TextBox).Text = "Hello controlTemplate";
            (sp.Children[2] as TextBox).Text = "i can find you";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBlock tb = this.cp.ContentTemplate.FindName("txtBlockName", this.cp)as TextBlock;
            MessageBox.Show(tb.Text);
        }

        private void txtBoxName_GotFocus(object sender, RoutedEventArgs e)
        {
            ////访问业务逻辑数据
            TextBox tb = e.OriginalSource as TextBox;//获取事件发起的源头
            ContentPresenter cp = tb.TemplatedParent as ContentPresenter;//获取模板数据
            Student stu = cp.Content as Student;//获取业务逻辑数据
            this.listViewStudent.SelectedItem = stu;//设置listView的选中项

            //访问界面元素
            ListViewItem lvi = this.listViewStudent.ItemContainerGenerator.ContainerFromItem(stu) as ListViewItem;
            CheckBox chb = this.FindVisualChild<CheckBox>(lvi);
            MessageBox.Show(chb.Name);
        }
        private ChildType FindVisualChild<ChildType>(DependencyObject obj) where ChildType : DependencyObject 
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child!=null&&child is ChildType)
                {
                    return child as ChildType;
                }
                else
                {
                    ChildType childOfChild = FindVisualChild<ChildType>(child);
                    if (childOfChild!=null)
                    {
                        return childOfChild;
                    }
                }
            
            }
            return null;
        }
    }

    public class Unit
    { 
        public int Price { get; set; }
        public string Year { get; set;}
    }

    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Skill { get; set; }
    //    public bool HasJob { get; set; }

    //    public int Age { get; set; }
    //}


}
