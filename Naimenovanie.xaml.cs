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
using DataSetPrakt1.PetShopDataSetTableAdapters;


namespace DataSetPrakt1
{
    /// <summary>
    /// Логика взаимодействия для Naimenovanie.xaml
    /// </summary>
    
    public partial class Naimenovanie : Window
    {
        NaimenovaniePetsaTableAdapter naim = new NaimenovaniePetsaTableAdapter();
        public Naimenovanie()
        {
            InitializeComponent();
            GridDataNaim.ItemsSource = naim.GetData();
        }

        private void byeb(object sender, RoutedEventArgs e)
        {
            Pets pets = new Pets();
            pets.Show();
            Close();
        }

        private void kormreda(object sender, RoutedEventArgs e)
        {
            ReakNaim.Content = new StranicaNaim();
        }
    }
}
