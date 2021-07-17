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
    /// Window_9_1.xaml 的交互逻辑
    /// </summary>
    public partial class Window_9_1 : Window
    {
        public Window_9_1()
        {
            InitializeComponent();
            initialCommand();
            InitialCustomeCommand();
        }

        private void InitialCustomeCommand()
        {
            ClearCommand clearCommand = new ClearCommand();
            this.ctrlClear.Command = clearCommand;
            this.ctrlClear.CommandTarget = this.miniView;
        }
        /// <summary>
        /// 定义声明命令
        /// </summary>
        private RoutedCommand clearCmd = new RoutedCommand("Clear",typeof(Window_9_1));
        private void initialCommand()
        {
            //把命令赋值给命令源（发送者）并指定快捷键
            this.btn1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C,ModifierKeys.Alt));
            //指定命令目标
            this.btn1.CommandTarget = this.txtBoxA;

            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd;//只关注与clearCmd相关的事件
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Executed);
            //把命令关联安置在外围控件上
            this.stackPanel1.CommandBindings.Add(cb);
        }

        private void cb_CanExecute(object sender,CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxA.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            //避免继续向上传而降低程序性能
            e.Handled = true;
        }

        /// <summary>
        /// 当命令送达目标后，此方法被调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.txtBoxA.Clear();
            //避免继续向上传而降低程序性能
            e.Handled = true;
        }


        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.nameTxtBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string name = this.nameTxtBox.Text;
            if (e.Parameter.ToString()=="Teacher")
            {
                this.ListBoxNewItems.Items.Add($"new teacher {name} ,学而不厌，孜孜不倦。");
            }
            else if (e.Parameter.ToString() == "Student")
            {
                this.ListBoxNewItems.Items.Add($"new student {name} ,好好学习，天天向上。");
            }
        }


    }

    public interface IView
    { 
        bool IsChanged { get; set; }

        void SetBinding();
        void Refresh();
        void Clear();
        void Save();
    }

    public class ClearCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            IView view = parameter as IView;
            if (view!=null)
            {
                view.Clear();
            }
        }
    }
    /// <summary>
    /// 自定义命令源
    /// </summary>
    public class MyCommandSource : UserControl, ICommandSource
    {
        public ICommand Command { get; set; }

        public object CommandParameter { get; set; }

        public IInputElement CommandTarget { get; set; }

        ///在组件被单击时连带执行命令
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            ///在命令目标上执行命令，或称让命令作用与命令目标
            if (this.CommandTarget!=null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }
    }
}
