using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace СправочникПоVS.MVVM.View
{
    public partial class HomeView_0 : UserControl
    {
        public HomeView_0()
        {
            InitializeComponent();
        }

        //открытие ссылки в браузере
        void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://visualstudio.microsoft.com/ru/"); 
        }
    }
}
