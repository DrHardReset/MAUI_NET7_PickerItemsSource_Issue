using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list1 = new List<string>() { "1" };
        List<string> list2 = new List<string>() { "2" };

        public MainWindow()
        {
            InitializeComponent();
            ComboBox1.ItemsSource = list1;
            ComboBox1.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBox1.ItemsSource = list2;
            ComboBox1.SelectedIndex = 0;
        }
    }
}
