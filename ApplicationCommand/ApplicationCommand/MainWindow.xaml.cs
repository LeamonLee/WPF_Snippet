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

namespace ApplicationCommand
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Example1
            BindUIWithQuitCommand();

            // Example2
            BindUIWithCutCommand();

        }

        public void BindUIWithQuitCommand()
        {
            

            CommandBinding cbQuit = new CommandBinding(
                MyCommands.SystemCommands.Quit,
                new ExecutedRoutedEventHandler(Quit_Executed),
                new CanExecuteRoutedEventHandler(Quit_CanExecute)
            );
            this.CommandBindings.Add(cbQuit);

            InputBinding ibQuit = new InputBinding(
                MyCommands.SystemCommands.Quit,
                new KeyGesture(Key.Q, ModifierKeys.Control)
            );

            this.InputBindings.Add(ibQuit);
        }

        public void BindUIWithCutCommand()
        {
            //方便解說，就不使用XMAL了
            this.Title = "按下Button就會改變我";
            //這裡是Button定義，就如同XMAL的Button
            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            //Button定義完

            btn.Command = ApplicationCommands.Cut; //定義Button會執行"剪下"的命令
            btn.Content = ApplicationCommands.Cut; //Button的文字為系統的"剪下"字串
            this.Content = btn;

            //利用建構式，一次把"命令"、執行的事件處理器和CanExcute定義完。
            CommandBinding cbCut = new CommandBinding(ApplicationCommands.Cut, cutOnExcute, cutCanExcute);

            //別忘了Windows的CommandBindings要加上CommandBinding才會有效用喔!
            this.CommandBindings.Add(cbCut);
        }

        void cutOnExcute(object sender, ExecutedRoutedEventArgs args)
        {
            //從剪貼簿將文字放到Title
            Title = Clipboard.GetText();
        }

        //只有界面發生改變後(如焦點，按鍵變化，或者按鈕再次被點擊)，WPF才會進行CanExecute事件。
        //如果偵錯模式，則因為焦點一直變動，所以會一直進入此事件。
        void cutCanExcute(object sender, CanExecuteRoutedEventArgs args)
        {
            //利用剪貼簿的ContainsText方法來判斷，是否為文字，
            //是的話會傳回True，
            //而這邊CanExecuteRouredEventArgs的CanExecute會自動將Button enable或是disable
            args.CanExecute = Clipboard.ContainsText();
        }

        void Quit_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButton.YesNo);

            if (dialogResult == MessageBoxResult.Yes)
            {
                this.Close();
            }
            
        }

        void Quit_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }


    }
}
