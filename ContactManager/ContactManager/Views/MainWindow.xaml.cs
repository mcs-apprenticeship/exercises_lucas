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
using System.Windows.Shapes;


namespace ContactManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            var selectedIndex = ContactsList.SelectedIndex;
            if (selectedIndex != -1)
            {
                ((MainWindowViewModel)DataContext).SelectedContact = selectedIndex;
            }

            //((MainWindowViewModel)DataContext).SelectedContact = 
        }

        private void ReloadList(object sender, RoutedEventArgs e)
        {
            ContactsList.ItemsSource = null;
            ContactsList.ItemsSource = ((MainWindowViewModel)DataContext).Contacts;
        }
    }
}
