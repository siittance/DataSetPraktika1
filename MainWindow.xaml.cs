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
using DataSetPrakt1.PetShopDataSetTableAdapters;

namespace DataSetPrakt1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void clients(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            Close();
        }

        private void pet(object sender, RoutedEventArgs e)
        {
            Pets pets = new Pets();
            pets.Show();
            Close();
        }

        private void order(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            Close();
        }
    }
}
