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

namespace WPFApp.WithoutViewModel
{
    /// <summary>
    /// UcWithoutViewModel.xaml 的互動邏輯
    /// </summary>
    public partial class UcWithoutViewModel : UserControl
    {
        public UcWithoutViewModel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button click");
        }

        private void TbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbOutput.Text = $"Input is : {tbInput.Text}";
        }
    }
}
