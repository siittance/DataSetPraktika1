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
    /// Логика взаимодействия для StranicaPets.xaml
    /// </summary>
    public partial class StranicaPets : Page
    {
        PetsTableAdapter pet = new PetsTableAdapter();
        public StranicaPets()
        {
            InitializeComponent();
            GridDataPets.ItemsSource = pet.GetData();
        }

        private void GridDataPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var check = (GridDataPets.SelectedItem as DataRowView);
            if (check != null)
            {
                NamePet.Text = check.Row[1].ToString();
                ID_Type.Text = check.Row[2].ToString();
                ID_Feed.Text = check.Row[3].ToString();
                ID_Naim.Text = check.Row[4].ToString();
            }
        }

        private void chistota()
        {
            NamePet.Text = null;
            ID_Type.Text = null;
            ID_Feed.Text = null;
            ID_Naim.Text = null;
        }

        private void ydal(object sender, RoutedEventArgs e)
        {
            object id = (GridDataPets.SelectedItem as DataRowView).Row[0];
            pet.DeleteQuerypet(Convert.ToInt32(id));
            GridDataPets.ItemsSource = pet.GetData();
            chistota();
        }

        private void dobav(object sender, RoutedEventArgs e)
        {
            pet.InsertQueryPets(Convert.ToString(NamePet.Text), Convert.ToInt32(ID_Type.Text), Convert.ToInt32(ID_Feed.Text), Convert.ToInt32(ID_Naim.Text));
            GridDataPets.ItemsSource = pet.GetData();
            chistota();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            object id = (GridDataPets.SelectedItem as DataRowView).Row[0];
            pet.UpdateQueryPet(Convert.ToString(NamePet.Text), Convert.ToInt32(ID_Type.Text), Convert.ToInt32(ID_Feed.Text), Convert.ToInt32(ID_Naim.Text), Convert.ToInt32(id));
            GridDataPets.ItemsSource = pet.GetData();
            chistota();
        }

        private void p(object sender, RoutedEventArgs e)
        {
            Pets pets = new Pets();
            pets.Show();
            Window window = Window.GetWindow(this);
            window.Close();
        }
    }
}
