using System.Xml.Linq;

namespace CarRentalCompanyLibrary
{
    public class Car : IEquatable<Car>
    {
        private const char DELIMITER = ';';

        private string brand;
        private string licencePlate;


        public string LicencePlate
        {
            get { return licencePlate; }

        }

        public string CSV
        {
            get { return $"{licencePlate}{DELIMITER}{brand}"; }
        }

        public Car(string licencePlate, string brand)
        {
            this.brand = brand;
            this.licencePlate = licencePlate;
        }

        public Car(string csvLine)
        {
            string[] splitLine = csvLine.Split(DELIMITER);

            this.licencePlate = splitLine[0];
            this.brand = splitLine[1];
        }

        public bool Equals(Car? other)
        {
            if (other == null) return false;

            return licencePlate.Equals(other.licencePlate);
        }

        public override string ToString()
        {
            return $"{licencePlate} - {brand}";
        }
    }
}