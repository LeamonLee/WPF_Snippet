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

namespace WpfResources
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // FindResource()必須在InitializeComponent()之後呼叫
            // FindResource 如果搜尋到父控件Application.Resource都沒辦法找到，那就會直接報錯。
            // TryFindResource()找不到資源時，不會直接報錯，而是會回傳null。
            var style = gridMain.TryFindResource("ButtonStyle");


            var buttonStyles = new MyButtonStyles();        // Class定義在資源字典裡面 用 x:Class定義的
            buttonStyles.InitializeComponent();
            var style1 = buttonStyles["ButtonStyle1"];
        }
    }
}
