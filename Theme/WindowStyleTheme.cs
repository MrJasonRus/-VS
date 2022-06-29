using System;
using System.Windows;
using System.Windows.Controls;

namespace ChatClient.Theme
{
    partial class WindowStyleTheme {

        //Загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as System.Windows.Window).StateChanged += Window_StateChanged;
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            System.Windows.Window me = (sender as System.Windows.Window);
            Button maximizeCaptionButton = me.Template.FindName("MaxRestoreButton", me) as Button;
            if (maximizeCaptionButton is null)
            { //is not null
                maximizeCaptionButton.Content = me.WindowState == WindowState.Maximized ? "2" : "1";
            }
        }

        //Функции кнопки Topmost
        #region Attached property TopmostButtonVisible : bool - Видимость кнопки "Поверх всех окон"

        public static readonly DependencyProperty TopmostButtonVisibleProperty =
            DependencyProperty.RegisterAttached(
                "TopmostButtonVisible",
                typeof(bool),
                typeof(WindowStyleTheme),
                new PropertyMetadata(true));

        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetTopmostButtonVisible(DependencyObject d, bool value) => d.SetValue(TopmostButtonVisibleProperty, value);

        public static bool GetTopmostButtonVisible(DependencyObject d) => (bool)d.GetValue(TopmostButtonVisibleProperty);

        #endregion

        //Функция кнопки закрытия приложения
        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window).Close();
        }
        //Функция кнопки расширения приложения
        private void MaxRestoreButton_Click(object sender, RoutedEventArgs e) {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState = (((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }
        //Функция кнопки сворачивания приложения
        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState = WindowState.Minimized;
        }
    }
}
