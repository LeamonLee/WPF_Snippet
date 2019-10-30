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

namespace MyAttachedProp
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

        public void OnUIElement_Click(object sender, RoutedEventArgs e)
        {
            UIElement uIElement = (UIElement)sender;
            MessageBox.Show("Your Element's new name is " + GetNewName(uIElement), "AttachedProperty_Test");
        }

        public static string GetNewName(DependencyObject obj)
        {
            return (string)obj.GetValue(NewNameProperty);
        }

        public static void SetNewName(DependencyObject obj, string value)
        {
            obj.SetValue(NewNameProperty, value);
        }

        // Using a DependencyProperty as the backing store for NewName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NewNameProperty =
            DependencyProperty.RegisterAttached("NewName", typeof(string), typeof(MainWindow), new PropertyMetadata());
    }


}
