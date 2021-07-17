using PractiseWPF_2.Class;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml;
using System.Xml.Linq;
using ss=System.Windows.Shapes;

namespace PractiseWPF_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student stu;
        public List<Student> students;
        public DataTable dtStudent;

        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();

            #region 绑定

            

            #region 绑定textbox和listbox的选中id


            students = new List<Student>() {
                new Student{ Id=1,Name="student1",Age=1},
                new Student{ Id=2,Name="student2",Age=2},
                new Student{ Id=3,Name="student3",Age=3},
                new Student{ Id=4,Name="student4",Age=4},
                new Student{ Id=6,Name="tom",Age=3},
                new Student{ Id=7,Name="jack",Age=6},
                new Student{ Id=8,Name="rose",Age=7},
            };
            this.txtBoxList.ItemsSource = students;
            //this.txtBoxList.DisplayMemberPath = "Name";

             dtStudent = new DataTable();
            dtStudent.Columns.Add("Id");
            dtStudent.Columns.Add("Name");
            dtStudent.Columns.Add("Age");
            DataRow dr1 = dtStudent.NewRow();
            dr1["Id"] = 1;
            dr1["Name"] = "student1";
            dr1["Age"] = 1;
            dtStudent.Rows.Add(dr1);

            DataRow dr2 = dtStudent.NewRow();
            dr2["Id"] = 2;
            dr2["Name"] = "student2";
            dr2["Age"] = 2;
            dtStudent.Rows.Add(dr2);


            DataRow dr3 = dtStudent.NewRow();
            dr3["Id"] = 3;
            dr3["Name"] = "student3";
            dr3["Age"] = 3;
            dtStudent.Rows.Add(dr3);

            DataRow dr4 = dtStudent.NewRow();
            dr4["Id"] = 4;
            dr4["Name"] = "student8";
            dr4["Age"] = 4;
            dtStudent.Rows.Add(dr4);
            //this.listViewStudents.ItemsSource = dtStudent.DefaultView;
            this.listViewStudents.DataContext = dtStudent;
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding());



            Binding binding = new Binding("SelectedItem.Id") { Source= listViewStudents };
            this.txtBoxId.SetBinding(TextBox.TextProperty, binding);

            #endregion



            ///绑定textbox//三合一操作
            //this.txtBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });
            ////绑定textbox Details
            //stu = new Student();
            //Binding binding = new Binding();
            //binding.Source = stu;
            //binding.Path = new PropertyPath("Name");

            //BindingOperations.SetBinding(this.txtBoxName, TextBox.TextProperty, binding);

            //List<string> stringList = new List<string>() { "Tim","Tom","Blog"};
            //this.txtBox1.SetBinding(TextBox.TextProperty,new Binding("/") { Source=stringList});
            //this.txtBox2.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = stringList, Mode = BindingMode.OneWay });
            //this.txtBox3.SetBinding(TextBox.TextProperty,new Binding("/[2]") { Source=stringList,Mode=BindingMode.OneWay});

            //List<Country> countryList = new List<Country>();
            //this.txtBox1.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countryList });
            //this.txtBox2.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList.Name") { Source = countryList });
            //this.txtBox3.SetBinding(TextBox.TextProperty, new Binding("/Provinces/CityList.Name") { Source = countryList });
            #endregion

            InialRelativeSource();
        }
        private void InialRelativeSource()
        {
            //RelativeSource rs = new RelativeSource();
            //rs.AncestorLevel = 1;
            //rs.AncestorType = typeof(Grid);
            //Binding binding = new Binding("Name") { RelativeSource=rs};
            //this.txtBoxRelative.SetBinding(TextBox.TextProperty,binding);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name+= "tom";


            //StackPanel stackPanel = this.Content as StackPanel;
            //TextBox txtBox = stackPanel.Children[0] as TextBox;
            //if (string.IsNullOrEmpty(txtBox.Name))
            //{
            //    txtBox.Name = "NONAME";
            //}
            //else
            //{
            //    txtBox.Text = txtBox.Name;
            //}
            //if (string.IsNullOrEmpty(text2.Name))
            //{
            //    text2.Text = "noName";
            //}
            //else
            //{
            //    text2.Text = text2.Name;
            //}

            //if (string.IsNullOrEmpty(text3.Name))
            //{
            //    text3.Text = "noName";
            //}
            //else
            //{
            //    text3.Text = text3.Name;
            //}


        }

        private void btn_Test_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show("哈哈");
            //Human h = (Human)this.FindResource("human");
            //MessageBox.Show(h.Child.Name);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stu.Name += "Name";
        }

        private void buttonForXML_Click(object sender, RoutedEventArgs e)
        {
            #region 使用XML数据作为Binding的源
            try
            {
                //string test = "<?xml version=\"1.0\" encoding=\"utf-8\"?><StudentList>   <Student Id=\"1\">     <Name>Tim</Name>   </Student>    <Student Id=\"2\">     <Name>Tom</Name>   </Student>    <Student Id=\"3\">     <Name>vina</Name>   </Student>    <Student Id=\"4\">     <Name>Emily</Name>   </Student> </StudentList>";
                //XmlDocument doc = new XmlDocument();
                //doc.LoadXml(test);
                XmlDataProvider xdp = new XmlDataProvider();
                //xdp.Document = doc;
                xdp.Source = new Uri(@"E:\VisualStudio_Repo\PractiseWPF\PractiseWPF_2_NetFramework\PractiseWPF_2\PractiseWPF_2\BindXML.xml");
                xdp.XPath = @"/StudentList/Student";

                this.listViewStudents2.DataContext = xdp;
                this.listViewStudents2.SetBinding(ListView.ItemsSourceProperty, new Binding());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        private void btn_LoadDT_Click(object sender, RoutedEventArgs e)
        {

            ////List
            //this.listViewStudents3.ItemsSource = from stu in students where stu.Age.Equals(3) select stu;


            ////DataTable
            //this.listViewStudents3.ItemsSource = from row in dtStudent.Rows.Cast<DataRow>()
            //                                     where Convert.ToString(row["Age"]).Equals("3")
            //                                     select new Student()
            //                                     {
            //                                         Id = int.Parse(row["Id"].ToString()),
            //                                         Name=row["name"].ToString(),
            //                                         Age=int.Parse(row["Age"].ToString())

            //                                     };

            ////XML
            XDocument xdoc = XDocument.Load(@"E:\VisualStudio_Repo\PractiseWPF\PractiseWPF_2_NetFramework\PractiseWPF_2\PractiseWPF_2\BindXML2.xml");
            this.listViewStudents3.ItemsSource = from element in xdoc.Descendants("Student")
                                                 where element.Attribute("Name").Value.StartsWith("T")
                                                 select new Student()
                                                 { 
                                                    Id=int.Parse(element.Attribute("Id").Value),
                                                    Name=element.Attribute("Name").Value,
                                                    Age=int.Parse(element.Attribute("Age").Value)
                                                 };


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            Binding bindingtoArg1 = new Binding("MethodParameters[0]")
            { 
                Source=odp,
                BindsDirectlyToSource=true,
                UpdateSourceTrigger=UpdateSourceTrigger.PropertyChanged
            };
            Binding bindingtoArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            Binding bindingToResult = new Binding(".") { Source=odp};

            this.txtBoxArg1.SetBinding(TextBox.TextProperty,bindingtoArg1);
            this.txtBoxArg2.SetBinding(TextBox.TextProperty, bindingtoArg2);
            this.txtBoxResult.SetBinding(TextBox.TextProperty, bindingToResult);


            MessageBox.Show(odp.Data.ToString());
        }
    }

    class City
    { 
        public string Name { get; set; }
    }
    class Province
    { 
        public string Name { get; set; }
        public List<City> CityList { get; set; }
    }

    class Country
    { 
        public string Name { get; set; }
        public List<Province> ProvinceList { get; set; }
    }

    class Calculator
    {
        public string Add(string arg1, string arg2)
        {
            double x = 0,
                    y = 0,
                    z = 0;
            if (double.TryParse(arg1,out x)&&double.TryParse(arg2,out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "Input error";
            
        }
    }
}
