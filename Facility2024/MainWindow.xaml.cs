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
using System.Windows.Navigation;
using System.Windows.Shapes;

///Alvin Cesar Sanchez Ochoa Alvarez.
using Facility2024.Views;

namespace Facility2024
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ///Alvin Cesar Sanchez Ochoa Alvarez.
        private void HandleOrdersView(object sender, RoutedEventArgs e)
        {
            DataContext = new OrdersView();
        }
        private void HandleProductsView(object sender, RoutedEventArgs e)
        { 
            DataContext = new ProductsView();
        }        
        private void HandleSellersView(object sender, RoutedEventArgs e)
        {
            DataContext = new SellersView();
        }

        private void HandleClientsView(object sender, RoutedEventArgs e)
        {
            DataContext = new ClientsView();
        }

        private void HandleLocationsView(object sender, RoutedEventArgs e)
        {
            DataContext = new LocationsView();
        }
    }
}
