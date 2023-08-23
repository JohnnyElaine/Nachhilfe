using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompanyLibrary
{
    internal class CarPark : Dictionary<string, Car>, IPermanentable
    {
        private const char DELIMITER = ';';

        public bool DeleteCar(string licencePlate)
        {
            return Remove(licencePlate);
        }

        public Car GetCar(string licencePlate)
        {
            return this[licencePlate];
        }

        public void Load(string path)
        {
            Clear();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(DELIMITER);

                    Add(splitLine[0], new Car(splitLine[0], splitLine[1]));
                }
            }
        }

        public void Save(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Car car in this.Values)
                {
                    writer.WriteLine(car.CSV);
                }
            }
        }
    }
}
