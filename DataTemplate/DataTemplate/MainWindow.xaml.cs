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

namespace DataTemplate
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person cGuy1 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.cGuy1 = new Person()
            {
                strName = "Leamon",
                nAge = 27
            };
            this.DataContext = this;
        }

        
    }

    public class Person
    {
        public string strName { get; set; }
        public int nAge { get; set; }
    }
}
