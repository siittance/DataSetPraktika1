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
    /// Логика взаимодействия для Typee.xaml
    /// </summary>
    public partial class Typee : Window
    {
        TypeeTableAdapter typ = new TypeeTableAdapter();
        public Typee()
        {
            InitializeComponent();
            GridDataType.ItemsSource = typ.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pets pets = new Pets();
            pets.Show();
            Close();
        }

        private void kormreda(object sender, RoutedEventArgs e)
        {
            ReakTypee.Content = new StraniceTypee();
        }
    }
}
