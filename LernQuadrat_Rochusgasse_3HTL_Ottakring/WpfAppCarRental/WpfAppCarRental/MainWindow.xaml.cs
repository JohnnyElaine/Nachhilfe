using CarRentalCompanyLibrary;
using System;
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

            listBoxCars.ItemsSource = company.Cars;
            listBoxCustomers.ItemsSource = company.Customers;
            listBoxRentals.ItemsSource = company.Rentals;
        }

        private void buttonRent_Click(object sender, RoutedEventArgs e)
        {
            Car selectedCar = (Car) listBoxCars.SelectedItem;
            Customer customer = (Customer) listBoxCustomers.SelectedItem;

            company.RentACar(selectedCar.LicencePlate, customer.ID, DateTime.Now, new TimeSpan(2,0,0));

            listBoxRentals.ItemsSource = company.Rentals;
            listBoxCustomerOfCar.ItemsSource = company.CustomerOfACar(selectedCar);
            listBoxRentals.Items.Refresh();
        }


        private void buttonNewCar_Click(object sender, RoutedEventArgs e)
        {
            company.AddNewCar(new Car(textBoxLicencePlate.Text, textBoxBrand.Text));

            listBoxCars.ItemsSource = company.Cars;
        }

        private void buttonNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(textBoxId.Text, out int id);

            company.AddNewCustomer(new Customer(id, textBoxName.Text));

            listBoxCustomers.Items.Refresh();
        }

        private void dataGridCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car selectedCar = (Car)listBoxCars.SelectedItem;
            labelSelectedCar.Content = selectedCar;
            listBoxCustomerOfCar.ItemsSource = company.CustomerOfACar(selectedCar);
        }

        private void listBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            labelSelectedCustomer.Content = (Customer) listBoxCustomers.SelectedItem;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            company.Dispose();
        }
    }
}
