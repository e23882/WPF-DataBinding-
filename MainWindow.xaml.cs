using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ViewModel main = new ViewModel();
            this.DataContext = main;
        }
    }
}
