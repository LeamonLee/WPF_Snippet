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

namespace MultipleViews_integrated
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Page1 p1;
        private Page2 p2;
        private Page3 p3;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (p1 == null)
            {
                p1 = new Page1();
            }
            Main.Content = p1.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (p2 == null)
            {
                p2 = new Page2();
            }
            Main.Content = p2.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (p3 == null)
            {
                p3 = new Page3();
            }
            Main.Content = p3.Content;
        }

        // Clear(delete) all pages
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            p1 = null;
            p2 = null;
            p3 = null;
            Main.Content = null;
        }
    }
}
