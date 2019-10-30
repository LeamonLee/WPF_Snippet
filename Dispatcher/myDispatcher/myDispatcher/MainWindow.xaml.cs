using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace myDispatcher
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = string.Empty;
            textBox_2.Text = string.Empty;
        }

        delegate void mySetTextCallbackDelegate(string strMsg);

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(vSetText);
            t.Start();
            vSetText2();
        }

        private void vSetText()
        {
            this.vSetTextCallBack("This is set in traditional thread safe way.");
        }

        private void vSetText2()
        {
            this.Dispatcher.Invoke(() =>
            {
                textBox_2.Text = "This is set by Dispatcher.invoke() method.";
            });
        }

        private void vSetTextCallBack(string strMsg)
        {
            //if(this.textBox.InvokeRequired)                   // not support in WPF. Only works in Winform 
            if(!Dispatcher.CheckAccess())
            {
                mySetTextCallbackDelegate d = new mySetTextCallbackDelegate(vSetTextCallBack);
                Dispatcher.Invoke(d, strMsg);
                //this.Invoke(d, new object[] { strMsg });      // not support in WPF. Only works in Winform 
            }
            else
            {
                this.textBox.Text = strMsg;
            }
        }
    }
}
