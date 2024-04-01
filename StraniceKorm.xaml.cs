using DataSetPrakt1.PetShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataSetPrakt1
{
    /// <summary>
    /// Логика взаимодействия для StraniceKorm.xaml
    /// </summary>
    public partial class StraniceKorm : Page
    {
        FeedTableAdapter food = new FeedTableAdapter();

        public StraniceKorm()
        {
            InitializeComponent();
            GridDataKorm.ItemsSource = food.GetData();

        }
        private void chistota()
        {
            Kormesh.Text = null;
        }

        private void ydale(object sender, RoutedEventArgs e)
        {
            object id = (GridDataKorm.SelectedItem as DataRowView).Row[0];
            food.DeleteQueryKorm(Convert.ToInt32(id));
            GridDataKorm.ItemsSource = food.GetData();
            chistota();
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            food.InsertQueryKorm(Convert.ToString(Kormesh.Text));
            GridDataKorm.ItemsSource = food.GetData();
            chistota();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            object id = (GridDataKorm.SelectedItem as DataRowView).Row[0];
            food.UpdateQueryKorm(Convert.ToString(Kormesh.Text), Convert.ToInt32(id));
            GridDataKorm.ItemsSource = food.GetData();
            chistota();
        }

        private void Poka(object sender, RoutedEventArgs e)
        {
            Korm korms = new Korm();
            korms.Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }

        private void GridDataOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var check = (GridDataKorm.SelectedItem as DataRowView);
            if (check != null)
            {
                Kormesh.Text = check.Row[1].ToString();
            }
        }
    }
}
