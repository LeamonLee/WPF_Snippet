using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAttachedProperty
{
    public class HasTextServices
    {

        // IsEnabled是為了表示是否要使用HasText這個附加屬性。

        // 定義好附加屬性後，接下來就要讓附加屬性可以正常運作，實現我們想要的功能。
        // 實現的方法通常是透過附加屬性改變的回呼(OnPropertyChanged)來達成，在這個回呼裡面註冊事件，由事件驅動的方式來執行我們想要的命令。
        //
        public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached(
        "IsEnabled",
        typeof(bool),
        typeof(HasTextServices),
        new PropertyMetadata(default(bool), OnIsEnabledChanged));

        private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // 先把傳入的相依物件d轉型成TextBox(因為我們確定這個附加屬性一定只有TextBox才可以使用)，
            // 在透過事件參數e.NewValue判斷IsEnabled屬性是否為true，
            // 若是，則註冊Tb_TextChanged方法給TextBox.TextChanged事件；若否，則取消註冊。
            //
            var tb = d as TextBox;
            if ((bool)e.NewValue)
            {
                tb.TextChanged += Tb_TextChanged;
            }
            else
            {
                tb.TextChanged -= Tb_TextChanged;
            }
        }

        private static void Tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            // 每當TextChanged時，我們就要判斷現在TextBox.Text是否為空，並把結果設定給HasText附加屬性。
            // 注意到要設定控件的附加屬性必須要透過當初定義的Set方法來設定。
            var tb = sender as TextBox;
            SetHasText(tb, !string.IsNullOrEmpty(tb.Text));
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsEnabled(DependencyObject obj)
            => (bool)obj.GetValue(IsEnabledProperty);
        public static void SetIsEnabled(DependencyObject obj, bool value)
            => obj.SetValue(IsEnabledProperty, value);



        public static readonly DependencyProperty HasTextProperty = DependencyProperty.RegisterAttached(
            "HasText",
            typeof(bool),
            typeof(HasTextServices),
            new PropertyMetadata(default(bool)));

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetHasText(DependencyObject obj)
            => (bool)obj.GetValue(HasTextProperty);
        public static void SetHasText(DependencyObject obj, bool value)
            => obj.SetValue(HasTextProperty, value);
    }
}
