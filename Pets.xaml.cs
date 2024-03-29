﻿using DataSetPrakt1.PetShopDataSetTableAdapters;
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
    /// Логика взаимодействия для Pets.xaml
    /// </summary>
    public partial class Pets : Window
    {
        PetsTableAdapter pet = new PetsTableAdapter();
        public Pets()
        {
            InitializeComponent();
            GridDataPets.ItemsSource = pet.GetData();
        }

        private void clickkk(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
