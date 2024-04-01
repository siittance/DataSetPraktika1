using DataSetPrakt1.PetShopDataSetTableAdapters;
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

namespace DataSetPrakt1
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        OrdersTableAdapter orders   = new OrdersTableAdapter();
        public Orders()
        {
            InitializeComponent();
            GridDataOrders.ItemsSource = orders.GetData();
        }

        private void GridDataOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void vixod(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void DobavOrder(object sender, RoutedEventArgs e)
        {
            RedakOrder.Content = new StranicaOrders();
        }
    }
}
