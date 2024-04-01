using DataSetPrakt1.PetShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace DataSetPrakt1
{
    /// <summary>
    /// Логика взаимодействия для StranicaOrders.xaml
    /// </summary>
    public partial class StranicaOrders : Page
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();
        public StranicaOrders()
        {
            InitializeComponent();
            GridDataOrders.ItemsSource = orders.GetData();
        }

        private void Poka(object sender, RoutedEventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }

        private void ydal(object sender, RoutedEventArgs e)
        {
            object id = (GridDataOrders.SelectedItem as DataRowView).Row[0];
            orders.DeleteQueryOrder(Convert.ToInt32(id));
            GridDataOrders.ItemsSource = orders.GetData();
            chistota();
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            orders.InsertQueryOrder(Convert.ToString(Data.Text), Convert.ToInt32(ID_Client.Text), Convert.ToInt32(ID_Pet.Text));
            GridDataOrders.ItemsSource = orders.GetData();
            chistota();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            object id = (GridDataOrders.SelectedItem as DataRowView).Row[0];
            orders.UpdateQueryOrders(Convert.ToString(Data.Text), Convert.ToInt32(ID_Client.Text), Convert.ToInt32(ID_Pet.Text), Convert.ToInt32(id));
            GridDataOrders.ItemsSource = orders.GetData();
            chistota();
        }

        private void GridDataOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var check = (GridDataOrders.SelectedItem as DataRowView);
            if (check != null)
            {
                Data.Text = check.Row[1].ToString();
                ID_Client.Text = check.Row[2].ToString();
                ID_Pet.Text = check.Row[3].ToString();
            }
        }
        private void chistota()
        {
            Data.Text = null;
            ID_Client.Text = null;
            ID_Pet.Text = null;
        }
    }
}
