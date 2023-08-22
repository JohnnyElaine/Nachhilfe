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

        public Rental(Car car, Customer customer, DateTime start, TimeSpan duration)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
