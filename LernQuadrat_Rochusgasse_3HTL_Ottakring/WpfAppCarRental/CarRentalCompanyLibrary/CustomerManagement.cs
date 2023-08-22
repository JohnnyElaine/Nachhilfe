using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    public class CustomerManagement : List<Customer>, IPermanentable
    {
        public bool DeleteCustomer(int id)
        {
            Customer target = this.Where(customer => customer.ID == id).First();
            return Remove(target);
        }

        public Customer GetCustomer(int id)
        {
            return this.Where(customer => customer.ID == id).First();
        }

        public void Load(string path)
        {
            Clear();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Add(new Customer(line.Trim()));
                }
            }
        }

        public void Save(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Customer customer in this)
                {
                    writer.WriteLine(customer.CSV);
                }
            }
        }
    }
}
