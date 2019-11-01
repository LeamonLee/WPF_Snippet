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

namespace BasicControl
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person { strFirstName = "Tim", strLastName = "Corey" });
            people.Add(new Person { strFirstName = "Joe", strLastName = "Smith" });
            people.Add(new Person { strFirstName = "Sue", strLastName = "Storm" });

            myComboBox.ItemsSource = people;
        }
    }

    public class Person
    {
        public string strFirstName { get; set; }
        public string strLastName { get; set; }

        public string strFullName
        {
            get
            {
                return $"{strFirstName} {strLastName}";
            }
        }
    }
}
