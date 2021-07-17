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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PractiseWPF_2
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class MiniView : UserControl,IView
    {
        public MiniView()
        {
            InitializeComponent();
        }

        public bool IsChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Clear()
        {
            this.txtBox1.Clear();
            this.txtBox2.Clear();
            this.txtBox3.Clear();
            this.txtBox4.Clear();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetBinding()
        {
            throw new NotImplementedException();
        }
    }
}
