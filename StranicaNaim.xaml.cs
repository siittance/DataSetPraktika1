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
    /// Логика взаимодействия для StranicaNaim.xaml
    /// </summary>
    public partial class StranicaNaim : Page
    {
        NaimenovaniePetsaTableAdapter naim = new NaimenovaniePetsaTableAdapter();
        public StranicaNaim()
        {
            InitializeComponent();
            GridDataNaim.ItemsSource = naim.GetData();
        }

        private void chistota()
        {
            NAIM.Text = null;
        }

        private void ydale(object sender, RoutedEventArgs e)
        {
            object id = (GridDataNaim.SelectedItem as DataRowView).Row[0];
            naim.DeleteQueryNaim(Convert.ToInt32(id));
            GridDataNaim.ItemsSource = naim.GetData();
            chistota();
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            naim.InsertQueryNaim(Convert.ToString(NAIM.Text));
            GridDataNaim.ItemsSource = naim.GetData();
            chistota();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            object id = (GridDataNaim.SelectedItem as DataRowView).Row[0];
            naim.UpdateQueryNaim(Convert.ToString(NAIM.Text),Convert.ToInt32(id));
            GridDataNaim.ItemsSource = naim.GetData();
            chistota();
        }

        private void GridDataOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var check = (GridDataNaim.SelectedItem as DataRowView);
            if (check != null)
            {
                NAIM.Text = check.Row[1].ToString();
            }
        }

        private void Poka(object sender, RoutedEventArgs e)
        {
            Naimenovanie naim = new Naimenovanie();
            naim.Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }
    }
}
