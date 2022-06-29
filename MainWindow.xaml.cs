using System.Windows;
using System.Windows.Input;


namespace СправочникПоVS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Возможность двигать окно в определённый частях
        private void Window_MouseMove(object sender, MouseEventArgs e) 
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }


}
