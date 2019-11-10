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

using LiveCharts;
using LiveCharts.Wpf;
using System.Threading;

namespace Livechart_Exer
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection1 { get; set; }

        public SeriesCollection SeriesCollection2 { get; set; }
        public List<string> lstLabels { get; set; }
        private double _newData;
        private double[] arrTempData = { 1, 3, 2, 4, -3, 5, 2, 1 };

        public SeriesCollection SeriesCollection3 { get; set; }
        public List<string> lstLabels3 { get; set; }
        private double _newData3;
        private double[] arrTempData3 = { 1, 3, 2, 4, -3, 5, 2, 1 };


        public MainWindow()
        {
            InitializeComponent();
            initLineSeries1();
            initLineSeries2();
            initLineSeries3();
            lsCollection1.DataContext = this;
            lsCollection2.DataContext = this;
            lsCollection3.DataContext = this;
        }

        private void initLineSeries1()
        {
            SeriesCollection1 = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 },
                    Fill = Brushes.Transparent          // Setting Fill property to transparent can remove the background of each lineseries
                    
                },
                new LineSeries
                {
                    Values = new ChartValues<double> { 5, 6, 2, 7 },
                    Fill = Brushes.Transparent          // Setting Fill property to transparent can remove the background of each lineseries
                }
            };
        }

        private void initLineSeries2()
        {
            LineSeries mylineseries = new LineSeries();
            //設置折線的標題
            mylineseries.Title = "Temp";
            //折線圖直線形式
            mylineseries.LineSmoothness = 0;
            //折線圖的無點樣式
            mylineseries.PointGeometry = null;
            //添加橫座標
            lstLabels = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };       // The text shown in X-axis. Later will become Timestamp instead.
            //添加折線圖的數據
            mylineseries.Values = new ChartValues<double>(arrTempData);         // The value shown in Y axis
            SeriesCollection2 = new SeriesCollection { };
            SeriesCollection2.Add(mylineseries);
            _newData = 8;
            lineStartUpdate2();
        }

        //連續折線圖的方法
        private void lineStartUpdate2()
        {
            Task.Run(() =>
            {
                var r = new Random();
                while (true)
                {
                    Thread.Sleep(1000);
                    _newData = r.Next(-10, 10);
                    //通過Dispatcher在工作線程中更新窗體的UI元素
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //更新橫座標時間
                        lstLabels.Add(DateTime.Now.ToString());
                        lstLabels.RemoveAt(0);
                        //更新縱座標數據
                        SeriesCollection2[0].Values.Add(_newData);
                        SeriesCollection2[0].Values.RemoveAt(0);
                    });
                }
            });
        }

        private void initLineSeries3()
        {
            LineSeries mylineseries = new LineSeries();
            //設置折線的標題
            mylineseries.Title = "Temp3";
            //折線圖直線形式
            mylineseries.LineSmoothness = 0;
            //折線圖的無點樣式
            mylineseries.PointGeometry = null;
            //添加橫座標
            lstLabels3 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };       // The text shown in X-axis. Later will become Timestamp instead.
            //添加折線圖的數據
            mylineseries.Values = new ChartValues<double>(arrTempData3);         // The value shown in Y axis

            SeriesCollection3 = new SeriesCollection { };
            SeriesCollection3.Add(mylineseries);
            _newData3 = 8;
            lineStartUpdate3();
        }

        //連續折線圖的方法
        private void lineStartUpdate3()
        {
            Task.Run(() =>
            {
                var r = new Random();
                while (true)
                {
                    Thread.Sleep(100);
                    _newData3 = r.Next(-10, 10);
                    //通過Dispatcher在工作線程中更新窗體的UI元素
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //更新橫座標時間
                        lstLabels3.Add(DateTime.Now.ToString());
                        //更新縱座標數據
                        SeriesCollection3[0].Values.Add(_newData3);
                        
                    });
                }
            });
        }
    }
}
