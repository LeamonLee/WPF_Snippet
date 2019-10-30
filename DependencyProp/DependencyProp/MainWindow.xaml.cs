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
using System.Windows.Threading;

namespace DependencyProp
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public cPerson cPerson1 { get; set; }
        public cPerson10 cPerson2 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal,
                                                        delegate
                                                        {
                                                            if (nCounter >= int.MaxValue)
                                                            {
                                                                nCounter = 0;
                                                            }
                                                            else
                                                            {
                                                                nCounter++;
                                                            }
                                                        }, Dispatcher);
             cPerson1= new cPerson()
             {
                 strFirstName = "Leamon",
                 strLastName = "Lee",
                 nAge = 27
             };

            cPerson2 = new cPerson10()
            {
                StrFirstName = "Leamon",
                StrLastName = "Lee",
                
            };
            this.DataContext = this;
        }

        

        public int nCounter
        {
            get { return (int)GetValue(nCounterProperty); }
            set { SetValue(nCounterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for nCounter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nCounterProperty =
            DependencyProperty.Register("nCounter", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


    }
}
