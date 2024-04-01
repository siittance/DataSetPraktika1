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
    /// Логика взаимодействия для StraniceTypee.xaml
    /// </summary>
    public partial class StraniceTypee : Page
    {
        TypeeTableAdapter typ = new TypeeTableAdapter();
        public StraniceTypee()
        {
            InitializeComponent();
            GridDataType.ItemsSource = typ.GetData();
        }

        private void Poka(object sender, RoutedEventArgs e)
        {
            Typee typ = new Typee();
            typ.Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }
        private void chistota()
        {
            TYp.Text = null;
        }

        private void ydale(object sender, RoutedEventArgs e)
        {
            object id = (GridDataType.SelectedItem as DataRowView).Row[0];
            typ.DeleteQueryTyp(Convert.ToInt32(id));
            GridDataType.ItemsSource = typ.GetData();
            chistota();
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            typ.InsertQueryTyp(Convert.ToString(TYp.Text));
            GridDataType.ItemsSource = typ.GetData();
            chistota();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            object id = (GridDataType.SelectedItem as DataRowView).Row[0];
            typ.UpdateQueryTyp(Convert.ToString(TYp.Text), Convert.ToInt32(id));
            GridDataType.ItemsSource = typ.GetData();
            chistota();
        }

        private void GridDataOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var check = (GridDataType.SelectedItem as DataRowView);
            if (check != null)
            {
                TYp.Text = check.Row[1].ToString();
            }
        }
    }
}
