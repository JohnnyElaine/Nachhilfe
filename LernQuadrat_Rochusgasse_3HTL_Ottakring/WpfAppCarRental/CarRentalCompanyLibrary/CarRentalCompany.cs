using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    /**
     * IDisposable:
     * 
     * Durch IDisposable kann CarRentalCompany innerhalb des using() Feldes verwendet werden.
     * Dadurch wird am Ende des usign() Feldes automatisch  public void Dispose() aufgerufen werden.
     * 
     * in Dispose() sollten dann alle offenen Resourcen (offene Files, DB-Connections) geschlossen werden
     */
    public class CarRentalCompany : IDisposable
    {

        private const string CARS_CSV_PATH = "../../../cars.csv";
        private const string CUSTOMER_CSV_PATH = "../../../customers.csv";

        private CarPark cars;
        private CustomerManagement customers;
        private Dictionary<Car, List<Rental>> rentals;

        public List<Car> Cars
        {
            get { return cars.Values.ToList(); }
        }

        public List<Customer> Customers
        {
            get { return customers; }
        }

        public List<Rental> Rentals
        {
            get { return rentals.SelectMany(rental => rental.Value).ToList(); }
        }


        public CarRentalCompany()
        {
            cars = new CarPark();
            customers = new CustomerManagement();
            rentals = new Dictionary<Car, List<Rental>>();

            Init(cars, CARS_CSV_PATH);
            Init(customers, CUSTOMER_CSV_PATH);
        }

        public void AddNewCar(Car c)
        {
            cars[c.LicencePlate] = c;
        }

        public void AddNewCustomer(Customer c)
        {
            customers.Add(c);
        }

        public List<Customer> CustomerOfACar(Car car)
        {
            return rentals.ContainsKey(car) ? rentals[car].Select(rental => rental.Customer).ToList() : new List<Customer>();
            //return rentals.SelectMany(dict => dict.Value).Select(rental => rental.Customer).ToList();
            //return rentals.ContainsKey(car) ? rentals[car] : new List<Rental>();
        }

        public void RentACar(string licencePlate, int customerId, DateTime start, TimeSpan duration)
        {
            Car c = cars.GetCar(licencePlate);
            Customer customer = customers.GetCustomer(customerId);

            Rental r = new Rental(c, customer, start, duration);

            if (!rentals.ContainsKey(c)) rentals[c] = new List<Rental>();

            rentals[c].Add(r);
        }

        private void Final(IPermanentable objectToSave, string path)
        {
            objectToSave.Save(path);
        }

        private void Init(IPermanentable objectToLoad, string path)
        {
            objectToLoad.Load(path);
        }

        public void Dispose()
        {
            Final(cars, CARS_CSV_PATH);
            Final(customers, CUSTOMER_CSV_PATH);
        }
    }
}
