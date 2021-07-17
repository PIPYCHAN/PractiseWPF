using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
    /// Window_6.xaml 的交互逻辑
    /// </summary>
    public partial class Window_6 : Window
    {
        public Window_6()
        {
            InitializeComponent();

            InitialValidate();//
        }

        private void InitialValidate()
        {
            Binding binding = new Binding("Value") { Source = this.slider_valid1 };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            RangeValidationRule rvr = new RangeValidationRule();
            rvr.ValidatesOnTargetUpdated = true;//Target校验
            binding.ValidationRules.Add(rvr);
            binding.NotifyOnValidationError = true;//错误时发错信号
            this.txtBox_valid1.SetBinding(TextBox.TextProperty, binding);
            this.txtBox_valid1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));
        }
        private void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(this.txtBox_valid1).Count > 0)
            {
                this.txtBox_valid1.ToolTip = Validation.GetErrors(this.txtBox_valid1)[0].ErrorContent.ToString();
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> planeList = new List<Plane>()
            {
                new Plane(){ Catagory=Catagory.Bomber,Name="B1",State=State.Unknown},
                new Plane(){ Catagory=Catagory.Bomber,Name="B2",State=State.Unknown},
                new Plane(){ Catagory=Catagory.Fighter,Name="F22",State=State.Unknown},
                new Plane(){ Catagory=Catagory.Fighter,Name="SI-47",State=State.Unknown},
                new Plane(){ Catagory=Catagory.Bomber,Name="B52",State=State.Unknown},
                new Plane(){ Catagory=Catagory.Fighter,Name="J10",State=State.Unknown},
            };
            this.listBoxPlane.ItemsSource = planeList;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane p in listBoxPlane.Items)
            {
                sb.AppendLine(string.Format("Catagory={0},Name={1},State={2}", p.Catagory, p.Name, p.State));
            }
            try
            {
                File.WriteAllText(@"E:\VisualStudio_Repo\PractiseWPF\PractiseWPF_2_NetFramework\PractiseWPF_2\PractiseWPF_2\planeList.txt", sb.ToString());
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.ToString());
            }

        }
    }

    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "ValidationFailed");
        }
    }
    public class CatagoryToSourceConverter : IValueConverter
    {
        /// <summary>
        /// 将Catagory转换为Uri
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Catagory c = (Catagory)value;
            switch (c)
            {
                case Catagory.Bomber:
                    return @"\Icons\Bomber.png";
                case Catagory.Fighter:
                    return @"\Icons\Fighter.png";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StateToNullableBoolConverter : IValueConverter
    {
        //将State转换为bool
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State s = (State)value;
            switch (s)
            {
                case State.Available:
                    return true;
                case State.Locked:
                    return false;
                case State.Unknown:
                default:
                    return null;
            }
        }
        /// <summary>
        /// 将bool?转换为State
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nb = (bool?)value;
            switch (nb)
            {
                case true:
                    return State.Available;
                case false:
                    return State.Locked;
                case null:
                default:
                    return State.Unknown;
            }
        }
    }

    public enum Catagory
    {
        Bomber,
        Fighter
    }

    public enum State
    {
        Available,
        Locked,
        Unknown
    }
    public class Plane
    {
        public Catagory Catagory { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
