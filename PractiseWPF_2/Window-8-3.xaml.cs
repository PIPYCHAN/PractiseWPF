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
    /// Window_8_3.xaml 的交互逻辑
    /// </summary>
    public partial class Window_8_3 : Window
    {
        public Window_8_3()
        {
            InitializeComponent();
            //this.gridRoot.AddHandler(Button.ClickEvent,new RoutedEventHandler(ButtonClicked));

            InitialAttachEvent();
        }
        private void InitialAttachEvent()
        {
            this.gridMain.AddHandler(Student.NameChangedEvent,new RoutedEventHandler(this.StudentNameChangedHandler));
        }


        private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).Id.ToString());
        }
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement).Name);
        }
        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format($"{timeStr}到达{element.Name}");
            this.listBox1.Items.Add(content);

            //if (element==this.grid_2)//在grid2处停止传递
            //{
            //    e.Handled = true;
            //}
        }

        private void btn_ClearList_Click(object sender, RoutedEventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void btn_AttachEvent_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student() { Id=101,Name="Tim"};
            stu.Name = "Tom";
            RoutedEventArgs arg = new RoutedEventArgs(Student.NameChangedEvent,stu);
            this.btn_AttachEvent.RaiseEvent(arg);
        }
    }

    class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source) { }

        public DateTime ClickTime { get; set; }

    }

    class TimeButton : Button
    {
        /// <summary>
        /// 声明和注册路由事件
        /// </summary>
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent("ReportTime", RoutingStrategy.Tunnel,
            typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        //CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        //激发路由事件
        protected override void OnClick()
        {
            base.OnClick();

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent,this);
            args.ClickTime= DateTime.Now;
            this.RaiseEvent(args);
        }


    }
}
