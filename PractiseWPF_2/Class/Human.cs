using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PractiseWPF_2.Class
{
    public class Human:DependencyObject
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }
}
