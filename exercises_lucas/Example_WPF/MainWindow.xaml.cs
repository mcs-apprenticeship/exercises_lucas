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

namespace Example_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWIndowViewModel();
        }

        //private void CounterButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Counter.Text = $"{counter++}";
        //}
    }
}
