using Microsoft.Win32;
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

namespace WPFBasic
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private string usersName;

        public MainWindow()
        {
            InitializeComponent();

            // You can set window properties in code
            this.Title = "Hello World";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }

        // When the button is clicked it closes the window
        private void BtnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            // Opens a message box
            MessageBox.Show("The App is Closing");

            // Closes the app
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Opens an open file dialog
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            // Opens a save file dialog
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            //usersName = txtUsersName.Text;
            //MessageBox.Show($"Hello {usersName}");
        }
    }
}
