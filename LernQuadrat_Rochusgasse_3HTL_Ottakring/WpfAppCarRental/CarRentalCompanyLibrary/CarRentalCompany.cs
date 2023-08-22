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

        }

        public void AddNewCar(Car c)
        {

        }

        public void AddNewCustomer(Customer c)
        {

        }

        public List<Customer> CustomerOfACar(Car car)
        {
            return new List<Customer>();
        }

        public void RentACar(string licencePlate, int customerId, DateTime start, TimeSpan duration)
        {

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
            throw new NotImplementedException();
        }
    }
}
