using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    public class Customer : IEquatable<Customer>
    {
        private const char DELIMITER = ';';
        private int id;
        private string name;

        public string CSV
        {
            get { return $"{id}{DELIMITER}{name}"; }
        }

        public int ID
        {
            get { return id; }

        }

        public Customer(int id, string name) 
        { 
            this.id = id;
            this.name = name;
        }

        public Customer(string csvLine)
        {
            string[] splitLine = csvLine.Split(DELIMITER);

            this.id = int.Parse(splitLine[0]);
            this.name = splitLine[1];
        }

        public bool Equals(Customer? other)
        {
            if (other == null) return false;

            return id == other.id && name.Equals(other.name);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
