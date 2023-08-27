using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    public class Rental
    {
        private Car car;
        private Customer customer;
        private TimeSpan duration;
        private DateTime start;

        public Customer Customer
        {
            get { return customer; }
        }

        public Rental(Car car, Customer customer, DateTime start, TimeSpan duration)
        {
            this.car = car;
            this.customer = customer;
            this.start = start;
            this.duration = duration;
        }

        public override string ToString()
        {
            return $"{car}: {customer} - {start} - {duration}";
        }
    }
}
