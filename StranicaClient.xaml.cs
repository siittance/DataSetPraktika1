using DataSetPrakt1.PetShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataSetPrakt1
{
    /// <summary>
    /// Логика взаимодействия для StranicaClient.xaml
    /// </summary>
    public partial class StranicaClient : Page
    {
        ClientsTableAdapter clients = new ClientsTableAdapter();
        public StranicaClient()
        {
            InitializeComponent();
            GridDataClients.ItemsSource = clients.GetData();
        }

        private void GridDataPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var check = (GridDataClients.SelectedItem as DataRowView);
            if (check != null)
            {
                Familia.Text = check.Row[1].ToString();
                Imya.Text = check.Row[2].ToString();
                Otchestvo.Text = check.Row[3].ToString();
                PhoneNumber.Text = check.Row[4].ToString();
                Email.Text = check.Row[5].ToString();
            }
        }

        private void chistota()
        {
            Familia.Text = null;
            Imya.Text = null;
            Otchestvo.Text = null;
            PhoneNumber.Text = null;
            Email.Text = null;
        }

        private void ydal(object sender, RoutedEventArgs e)
        {
            object id = (GridDataClients.SelectedItem as DataRowView).Row[0];
            clients.DeleteQueryClient(Convert.ToInt32(id));
            GridDataClients.ItemsSource = clients.GetData();
            chistota();
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            clients.InsertQueryClient(Convert.ToString(Familia.Text), Convert.ToString(Imya.Text), Convert.ToString(Otchestvo.Text), Convert.ToString(PhoneNumber.Text), Convert.ToString(Email.Text));
            GridDataClients.ItemsSource = clients.GetData();
            chistota();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            object id = (GridDataClients.SelectedItem as DataRowView).Row[0];
            clients.UpdateQueryClient(Convert.ToString(Familia.Text), Convert.ToString(Imya.Text), Convert.ToString(Otchestvo.Text), Convert.ToString(PhoneNumber.Text), Convert.ToString(Email.Text), Convert.ToInt32(id));
            GridDataClients.ItemsSource = clients.GetData();
            chistota();
        }

        private void p(object sender, RoutedEventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }
    }
}
