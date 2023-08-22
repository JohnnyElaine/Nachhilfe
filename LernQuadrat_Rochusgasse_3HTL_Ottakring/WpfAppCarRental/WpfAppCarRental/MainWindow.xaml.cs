using CarRentalCompanyLibrary;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppCarRental
{
    public partial class MainWindow : Window
    {

        private CarRentalCompany company;

        public MainWindow()
        {
            InitializeComponent();

            company = new CarRentalCompany();
        }

        private void buttonRent_Click(object sender, RoutedEventArgs e)
        {
        }


        private void buttonNewCar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void buttonNewCustomer_Click(object sender, RoutedEventArgs e)
        {
        }

        private void dataGridCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void listBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
