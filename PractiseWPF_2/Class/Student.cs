using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PractiseWPF_2.Class
{
    //public class Student:INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    private string name;
    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            name = value;
    //            if (this.PropertyChanged != null)
    //            {
    //                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
    //            }
    //        }
    //    }

    //}
    public class Student:DependencyObject
    {
        public static readonly DependencyProperty NameProperty =
    DependencyProperty.Register("Name", typeof(string), typeof(Student));

        public static readonly RoutedEvent NameChangedEvent =
            EventManager.RegisterRoutedEvent("NameChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Student));


        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Skill { get; set; }
        public bool HasJob { get; set; }

    }
}
